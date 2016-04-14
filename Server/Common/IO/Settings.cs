using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Server.Common.Data;
using Server.Common.IO.Packet;

namespace Server.Common.IO
{
    public class TemporaryConfiguration : IDisposable
    {
        internal TemporaryConfiguration(string configuration)
        {
            Settings.Initialize(configuration);
        }

        public void Dispose()
        {
            Settings.Initialize();
        }
    }

    public static class Settings
    {
        private static int Line { get; set; }
        private static List<string> Text { get; set; }

        public static string Path { get; set; }

        public static void Initialize(string path = null, bool showRefresh = false)
        {
            if (path == null)
            {
                path = Application.ExecutablePath + "Configuration.ini";
            }

            if (Settings.Text != null)
            {
                Settings.Text.Clear();
            }

            Settings.Path = path;
            Settings.Text = new List<string>();

            string[] array = Settings.Path.Split('\\');
            string name = array[array.Length - 1];

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(string.Format("Unable to find configuration file '{0}'.", name));
            }
            else
            {
                string item;

                using (StreamReader file = new StreamReader(path))
                {
                    while ((item = file.ReadLine()) != null)
                    {
                        item = item.Replace("\t", string.Empty);
                        item = item.Trim();

                        Settings.Text.Add(item);
                    }
                }

                Log.Inform("Settings file '{0}' {1}.", name, showRefresh ? "refreshed" : "loaded");

                if (Settings.Path.Contains("Configuration"))
                {
                    PacketBase.LogLevel = Settings.GetEnum<LogLevel>("Packets", "Log");
                    Log.ShowStackTrace = Settings.GetBool("StackTrace", "Log");
                    LoadingIndicator.ShowTime = Settings.GetBool("LoadTime", "Log");

                    Database.Host = Settings.GetString("Host", "Database");
                    Database.Schema = Settings.GetString("Schema", "Database");
                    Database.Username = Settings.GetString("Username", "Database");
                    Database.Password = Settings.GetString("Password", "Database");
                }
            }
        }

        public static void Refresh()
        {
            Settings.Initialize(Settings.Path, true);
        }

        public static TemporaryConfiguration TemporaryConfiguration(string configuration)
        {
            return new TemporaryConfiguration(configuration);
        }

        private static string GetValue(string block, string parameter)
        {
            bool start = false;
            string ret = string.Empty;
            Settings.Line = 0;

            foreach (string item in Settings.Text)
            {
                Settings.Line++;

                if (block != string.Empty && !start && item == block + " = {")
                {
                    start = true;
                }
                else if (start && item == "}")
                {
                    break;
                }
                else if (item.StartsWith(parameter + " = "))
                {
                    if (block == string.Empty)
                    {
                        ret = item.Replace(parameter + " = ", string.Empty);

                        break;
                    }
                    else if (block != string.Empty && start)
                    {
                        ret = item.Replace(parameter + " = ", string.Empty);

                        break;
                    }
                }
            }

            return ret.Trim();
        }

        public static bool GetBool(string parameter, string block = "")
        {
            try
            {
                return bool.Parse(Settings.GetValue(block, parameter));
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static byte GetByte(string parameter, string block = "")
        {
            try
            {
                return byte.Parse(Settings.GetValue(block, parameter));
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static short GetShort(string parameter, string block = "")
        {
            try
            {
                return short.Parse(Settings.GetValue(block, parameter));
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static int GetInt(string parameter, string block = "")
        {
            try
            {
                return int.Parse(Settings.GetValue(block, parameter));
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static string GetString(string parameter, string block = "")
        {
            return Settings.GetValue(block, parameter);
        }

        public static IPAddress GetIPAddress(string parameter, string block = "")
        {
            try
            {
                if (Settings.GetValue(block, parameter) == "localhost")
                {
                    return IPAddress.Loopback;
                }
                else
                {
                    return IPAddress.Parse(Settings.GetValue(block, parameter));
                }
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static T GetEnum<T>(string parameter, string block = "")
        {
            try
            {
                return (T)Enum.Parse(typeof(T), Settings.GetValue(block, parameter));
            }
            catch
            {
                throw new SettingReadException(parameter);
            }
        }

        public static List<string> GetBlocks(string sMainBlock, bool skipBlocksInsideBlock)
        {
            List<string> ret = new List<string>();

            bool block = false;

            foreach (string line in Settings.Text)
            {
                Settings.Line++;

                if (!block && line.Contains(sMainBlock + " = {"))
                {
                    // NOTE: Found start of the block.

                    block = true;
                }
                else if (block && line.Contains("}"))
                {
                    // NOTE: Found end of the blcok.

                    break;
                }
                else if (block)
                {
                    ret.Add(line);
                }
            }

            return ret;
        }

        public static List<string> GetBlocksFromBlock(string sMainBlock, int innerBlock)
        {
            List<string> ret = new List<string>();
            int block = sMainBlock == "" ? 1 : 0;
            int skipBlock = 0;
            foreach (string line in Settings.Text)
            {
                Line++;
                if (block == 0 && line == sMainBlock + " = {")
                {
                    block = 1;
                }
                else if (block == 1 && line == "}")
                {
                    block = 0;
                    break;
                }
                else
                {
                    if (block >= 1)
                    {
                        if (line.Contains(" = {"))
                        {
                            // Another block found
                            if (block <= innerBlock)
                            {
                                block++;
                                ret.Add(line.Replace(" = {", ""));
                            }
                            else
                            {
                                skipBlock++; // For skipping the '}' 's
                            }
                        }
                        else if (line == "}")
                        {
                            // Block end found
                            if (skipBlock == 0)
                                block--;
                            else
                                skipBlock--;
                        }
                    }
                }
            }
            return ret;
        }
    }
}
