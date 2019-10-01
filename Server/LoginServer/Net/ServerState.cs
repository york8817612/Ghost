namespace Server.Ghost
{
    public class ServerState
    {
    /* state
          * 07 - Account is frozen due to gameplay using Bug
          * 08 - Account has been frozen due to improper money earning
          * 09 - Account has been frozen due to rumors
          * 10 - The account has been frozen due to frequency washing
          * 11 - Account is temporarily frozen
          * 12 - Account is frozen
          * 13 - Account number is incorrect, please re-enter
          * 14 - The password you entered is incorrect
          * 29 - The game will not be played within 1 hour due to the detection of improper gameplay.
          */
        public enum LoginState
        {
            OK = 0,
            AUTO_REGISTRATION = 1, // 非客戶端
            BUG_LOCK = 7,
            MEMONY_LOCK = 8,
            FUCK_LOCK = 9,
            CHANNEL_LOCK = 10,
            TMPE_LOCK = 11,
            USER_LOCK = 12,
            NO_USERNAME = 13,
            PASSWORD_ERROR = 14,
            HACK_LOCK = 29
        }

       /* state
          * 28 = This is an age-restricted channel, please use another channel
          * 04 = This ID is connected, please try again later
          * else = network status error
          */
        public enum ChannelState
        {
            OK = 0,
            OTHER = 1,
            CONNECTED_WAITE = 4,
            YEARS_OLD = 28
        }
    }
}
