using System;
using System.Collections.Generic;

namespace Server.Common.Data
{
    internal static class Meta
    {
        public static Dictionary<string, Dictionary<string, Column>> Tables = new Dictionary<string, Dictionary<string, Column>>();

        public static void Initialize(bool mcdb)
        {
            Meta.Tables.Clear();

            foreach (dynamic datum in new Datums("COLUMNS").Populate("TABLE_SCHEMA = '{0}'{1}", Database.DefaultSchema, mcdb ? " OR TABLE_SCHEMA = 'mcdb'" : string.Empty))
            {
                Meta.Add(datum);
            }
        }

        private static void Add(dynamic datum)
        {
            Dictionary<string, Column> table;

            string tableName = datum.TABLE_NAME;

            if (Meta.Tables.ContainsKey(tableName))
            {
                table = Meta.Tables[tableName];
            }
            else
            {
                table = new Dictionary<string, Column>();
                Meta.Tables.Add(tableName, table);
            }

            table.Add(datum.COLUMN_NAME, new Column(datum));
        }

        public static bool IsBool(String tableName, String fieldName)
        {
            return Meta.Tables[tableName][fieldName].ColumnType == "tinyint(1) unsigned";
        }

        public static bool IsDate(String tableName, String fieldName)
        {
            return Meta.Tables[tableName][fieldName].ColumnType == "date";
        }

        public static bool IsDateTime(String tableName, String fieldName)
        {
            return Meta.Tables[tableName][fieldName].ColumnType == "datetime";
        }
    }

    internal class Column
    {
        public string Name { get; private set; }
        public bool IsPrimaryKey { get; private set; }
        public bool IsUniqueKey { get; private set; }
        public string ColumnType { get; private set; }

        public Column(dynamic datum)
        {
            this.Name = datum.COLUMN_NAME;
            this.IsPrimaryKey = datum.COLUMN_KEY == "PRI";
            this.IsUniqueKey = datum.COLUMN_KEY == "UNI";
            this.ColumnType = datum.COLUMN_TYPE;
        }
    }
}
