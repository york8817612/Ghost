using System;

namespace Server.Common.Constants
{
    public static class ServerUtilities
    {
        public enum WorldNames : byte
        {
            Wrold01,
            Wrold02,
            Wrold03,
            World04
        }

        public static class WorldNameResolver
        {
            public static byte GetID(string name)
            {
                try
                {
                    return (byte)Enum.Parse(typeof(WorldNames), name.ToCamel());
                }
                catch
                {
                    throw new ArgumentException("The specified World name is invalid.");
                }
            }

            public static string GetName(byte id)
            {
                try
                {
                    return Enum.GetName(typeof(WorldNames), id);
                }
                catch
                {
                    throw new ArgumentException("The specified World ID is invalid.");
                }
            }

            public static bool IsValid(byte id)
            {
                return Enum.IsDefined(typeof(WorldNames), id);
            }

            public static bool IsValid(string name)
            {
                try
                {
                    WorldNameResolver.GetID(name);
                    return true;
                }
                catch (ArgumentException)
                {
                    return false;
                }
            }
        }

        public enum HackAction : byte
        {
            None,
            Disconnection,
            ThirthyDays,
            NinetyDays,
            Permanent
        }

        public enum ServerType
        {
            Login,
            Char,
            Game,
            Message,
            Shop
        }

        public struct Rates
        {
            public int Experience { get; set; }
            public int QuestExperience { get; set; }
            public int PartyQuestExperience { get; set; }

            public int Meso { get; set; }
            public int Loot { get; set; }
        }

        public enum ServerFlag : byte
        {
            None,
            Event,
            New,
            Hot
        }

        public enum ServerStatus : short
        {
            Normal,
            HighlyPopulated,
            Full
        }

        public enum ServerRegistrationResponse : byte
        {
            Valid,
            InvalidIP,
            InvalidCode,
            WorldsFull
        }

        public static class RegistrationResponseResolver
        {
            public static string Explain(ServerRegistrationResponse response)
            {
                switch (response)
                {
                    case ServerRegistrationResponse.Valid:
                        return "The server can be registered.";

                    case ServerRegistrationResponse.InvalidIP:
                        return "The provided external IP is not corresponding.";

                    case ServerRegistrationResponse.InvalidCode:
                        return "The provided security code is not corresponding.";

                    case ServerRegistrationResponse.WorldsFull:
                        return "Cannot register a new Server as all the Worlds spots are occupied.";

                    default:
                        return null;
                }
            }
        }
    }
}
