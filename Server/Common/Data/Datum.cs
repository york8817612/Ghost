using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using MySql.Data.MySqlClient;

namespace Server.Common.Data
{
    public class Datums : IEnumerable<Datum>
    {
        private List<Datum> Values { get; set; }
        private string Table { get; set; }

        public Datums(string table = null)
        {
            this.Table = table;
        }

        internal void PopulateInternal(string fields, string constraints)
        {
            this.Values = new List<Datum>();

            string query = string.Format("SELECT {0} FROM {1}{2}", fields == null ? "*" : Database.CorrectFields(fields), this.Table, constraints != null ? " WHERE " + constraints : string.Empty);

            using (MySqlDataReader reader = MySqlHelper.ExecuteReader(Database.ConnectionString, query))
            {
                while (reader.Read())
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dictionary.Add(reader.GetName(i), reader.GetValue(i));
                    }

                    this.Values.Add(new Datum(this.Table, dictionary));
                }
            }
        }

        internal void PopulateInternalFree(string query)
        {
            this.Values = new List<Datum>();

            using (MySqlDataReader reader = MySqlHelper.ExecuteReader(Database.ConnectionString, query))
            {
                while (reader.Read())
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dictionary.Add(reader.GetName(i), reader.GetValue(i));
                    }

                    this.Values.Add(new Datum(this.Table, dictionary));
                }
            }
        }

        public dynamic Populate()
        {
            this.PopulateInternal(null, null);

            return this;
        }

        public dynamic Populate(string constraints, params object[] args)
        {
            this.PopulateInternal(null, string.Format(constraints, args));

            return this;
        }

        public dynamic PopulateWith(string fields)
        {
            this.PopulateInternal(fields, null);

            return this;
        }

        public dynamic PopulateWith(string fields, string constraints, params object[] args)
        {
            this.PopulateInternal(fields, string.Format(constraints, args));

            return this;
        }

        public dynamic PopulateFree(string query)
        {
            this.PopulateInternalFree(query);

            return this;
        }

        public IEnumerator<Datum> GetEnumerator()
        {
            foreach (Datum loopDatum in this.Values)
            {
                yield return loopDatum;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }
    }

    public class Datum : DynamicObject
    {
        public string Table { get; private set; }

        internal Dictionary<string, object> Dictionary { get; set; }

        public Datum(string table)
        {
            this.Table = table;
            this.Dictionary = new Dictionary<string, object>();
        }

        internal Datum(string table, Dictionary<string, object> values)
        {
            this.Table = table;
            this.Dictionary = values;
        }

        internal void Populate(string query)
        {
            using (MySqlDataReader reader = MySqlHelper.ExecuteReader(Database.ConnectionString, query))
            {
                if (reader.RecordsAffected > 1)
                {
                    throw new RowNotUniqueException();
                }

                if (!reader.HasRows)
                {
                    throw new RowNotInTableException();
                }

                reader.Read();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    object value = reader.GetValue(i);

                    if (this.Dictionary.ContainsKey(name))
                    {
                        this.Dictionary[name] = value;
                    }
                    else
                    {
                        this.Dictionary.Add(name, value);
                    }
                }
            }
        }

        public dynamic Populate(string constraints, params object[] args)
        {
            this.Populate(string.Format("SELECT * FROM {0} WHERE {1}", this.Table, string.Format(constraints, args)));

            return this;
        }

        public dynamic PopulateWith(string fields, string constraints, params object[] args)
        {
            this.Populate(string.Format("SELECT {0} FROM {1} WHERE {2}", Database.CorrectFields(fields), this.Table, string.Format(constraints, args)));

            return this;
        }

        public void Insert()
        {
            string fields = "( ";

            int processed = 0;

            foreach (KeyValuePair<string, object> loopPair in this.Dictionary)
            {
                fields += loopPair.Key;
                processed++;

                if (processed < this.Dictionary.Count)
                {
                    fields += ", ";
                }
            }

            fields += " ) VALUES ( ";

            processed = 0;

            foreach (KeyValuePair<string, object> loopPair in this.Dictionary)
            {
                fields += string.Format("'{0}'", loopPair.Value is bool ? (((bool)loopPair.Value) ? 1 : 0) : loopPair.Value);
                processed++;

                if (processed < this.Dictionary.Count)
                {
                    fields += ", ";
                }
            }

            fields += " )";

            Database.Execute("INSERT INTO {0} {1}", this.Table, fields);
        }

        public void Update(string constraints, params object[] args)
        {
            int processed = 0;

            string fields = string.Empty;

            foreach (KeyValuePair<string, object> loopPair in this.Dictionary)
            {
                fields += string.Format("{0}='{1}'", loopPair.Key, loopPair.Value is bool ? (((bool)loopPair.Value) ? 1 : 0) : loopPair.Value);
                processed++;

                if (processed < this.Dictionary.Count)
                {
                    fields += ", ";
                }
            }

            Database.Execute("UPDATE {0} SET {1} WHERE {2}", this.Table, fields, string.Format(constraints, args));
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (this.Dictionary.ContainsKey(binder.Name))
            {
                if (this.Dictionary[binder.Name] is DBNull)
                {
                    result = null;
                }
                else if (this.Dictionary[binder.Name] is byte && Meta.IsBool(this.Table, binder.Name))
                {
                    result = (byte)this.Dictionary[binder.Name] > 0;
                }
                else
                {
                    result = this.Dictionary[binder.Name];
                }

                return true;
            }
            else
            {
                result = default(object);
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (value is DateTime)
            {
                if (Meta.IsDate(this.Table, binder.Name))
                {
                    value = ((DateTime)value).ToString("yyyy-MM-dd");
                }
                else if (Meta.IsDateTime(this.Table, binder.Name))
                {
                    value = ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            if (this.Dictionary.ContainsKey(binder.Name))
            {
                this.Dictionary[binder.Name] = value;
            }
            else
            {
                this.Dictionary.Add(binder.Name, value);
            }

            return true;
        }

        public override string ToString()
        {
            string result = this.Table + " [ ";

            int processed = 0;

            foreach (KeyValuePair<string, object> value in this.Dictionary)
            {
                result += value.Key;
                processed++;

                if (processed < this.Dictionary.Count)
                {
                    result += ", ";
                }
            }

            result += " ]";

            return result;
        }
    }
}
