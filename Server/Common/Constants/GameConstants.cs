namespace Server.Common.Constants
{
    public class GameConstants
    {
        private static int[] exp = { 10, 25, 65, 150, 250, 500, 795, 1185, 1690, 2660 };

        public static int getExpNeededForLevel(byte level)
        {
            if (level > 10)
            { // 未完成
                return 2660;
            }
            return exp[level - 1];
        }
    }
}
