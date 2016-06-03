namespace Server.Ghost.Provider
{
    public class MobFactory
    {
        public static int MonsterHP(int MonsterLevel)
        {
            int MonsterHP = int.MaxValue;
            switch (MonsterLevel)
            {
                case 1: // 賴打
                    MonsterHP = 50;
                    break;
                case 2: // 大目仔
                    MonsterHP = 60;
                    break;
                case 3: // 美人魚
                    MonsterHP = 100;
                    break;
                case 5: // 蘆花
                    MonsterHP = 160;
                    break;
                case 6:
                    MonsterHP = 190;
                    break;
                case 7:
                    MonsterHP = 220;
                    break;
                case 8:
                    MonsterHP = 250;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterHP = 700;
                    break;
                case 12:
                    MonsterHP = 590;
                    break;
                case 14:
                    MonsterHP = 690;
                    break;
                case 16:
                    MonsterHP = 780;
                    break;
                case 18:
                    MonsterHP = 880;
                    break;
                case 20: // 銅鈴眼(Boss)
                    MonsterHP = 2900;
                    break;
                case 21:
                    MonsterHP = 2400;
                    break;
                case 22:
                    MonsterHP = 2600;
                    break;
                case 24:
                    MonsterHP = 2800;
                    break;
                case 26:
                    MonsterHP = 3300;
                    break;
                case 28:
                    MonsterHP = 3600;
                    break;
                case 30: // 豬大長(Boss)
                    MonsterHP = 29200;
                    break;
                case 32:
                    MonsterHP = 4700;
                    break;
                case 34:
                    MonsterHP = 5100;
                    break;
                case 35:
                    MonsterHP = 5300;
                    break;
                case 36:
                    MonsterHP = 5600;
                    break;
                case 37:
                    MonsterHP = 5800;
                    break;
                case 38:
                    MonsterHP = 6200;
                    break;
                case 39:
                    MonsterHP = 6400;
                    break;
                case 40: // 狗骨頭(Boss)
                    MonsterHP = 51000;
                    break;
                case 42:
                    MonsterHP = 10800;
                    break;
                case 43:
                    MonsterHP = 11250;
                    break;
                case 44:
                    MonsterHP = 11500;
                    break;
                case 45:
                    MonsterHP = 12450;
                    break;
                case 46:
                    MonsterHP = 12600;
                    break;
                case 48:
                    MonsterHP = 13500;
                    break;
                case 49:
                    MonsterHP = 13800;
                    break;
                case 50: // 雞冠嗆(Boss)
                    MonsterHP = 87100;
                    break;
                case 51:
                    MonsterHP = 15700;
                    break;
                case 52:
                    MonsterHP = 16500;
                    break;
                case 54:
                    MonsterHP = 18100;
                    break;
                case 55:
                    MonsterHP = 18900;
                    break;
                case 56:
                    MonsterHP = 19700;
                    break;
                case 57:
                    MonsterHP = 20500;
                    break;
                case 59:
                    MonsterHP = 22100;
                    break;
                case 60: // 猴塞雷(Boss)
                    MonsterHP = 127140;
                    break;
                case 70: // 羊桃之(Boss)
                    MonsterHP = 189000;
                    break;
            }
            return MonsterHP;
        }

        public static int MonsterExp(int MonsterLevel)
        {
            int MonsterExp = 0;
            switch (MonsterLevel)
            {
                case 1: // 賴打
                    MonsterExp = 3;
                    break;
                case 2: // 大目仔
                    MonsterExp = 6;
                    break;
                case 3: // 美人魚
                    MonsterExp = 8;
                    break;
                case 5: // 蘆花
                    MonsterExp = 14;
                    break;
                case 6:
                    MonsterExp = 17;
                    break;
                case 7:
                    MonsterExp = 20;
                    break;
                case 8:
                    MonsterExp = 22;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterExp = 42;
                    break;
                case 12:
                    MonsterExp = 36;
                    break;
                case 14:
                    MonsterExp = 42;
                    break;
                case 16:
                    MonsterExp = 48;
                    break;
                case 18:
                    MonsterExp = 54;
                    break;
                case 20: // 銅鈴眼(Boss)
                    MonsterExp = 90;
                    break;
                case 21:
                    MonsterExp = 145;
                    break;
                case 22:
                    MonsterExp = 153;
                    break;
                case 24:
                    MonsterExp = 169;
                    break;
                case 26:
                    MonsterExp = 185;
                    break;
                case 28:
                    MonsterExp = 201;
                    break;
                case 30: // 豬大長(Boss)
                    MonsterExp = 217;
                    break;
                case 32:
                    MonsterExp = 233;
                    break;
                case 34:
                    MonsterExp = 249;
                    break;
                case 35:
                    MonsterExp = 257;
                    break;
                case 36:
                    MonsterExp = 265;
                    break;
                case 37:
                    MonsterExp = 273;
                    break;
                case 38:
                    MonsterExp = 281;
                    break;
                case 39:
                    MonsterExp = 289;
                    break;
                case 40: // 狗骨頭(Boss)
                    MonsterExp = 297;
                    break;
                case 42:
                    MonsterExp = 321;
                    break;
                case 43:
                    MonsterExp = 321;
                    break;
                case 44:
                    MonsterExp = 329;
                    break;
                case 45:
                    MonsterExp = 325;
                    break;
                case 46:
                    MonsterExp = 330;
                    break;
                case 48:
                    MonsterExp = 342;
                    break;
                case 49:
                    MonsterExp = 350;
                    break;
                case 50: // 雞冠嗆(Boss)
                    MonsterExp = 5124;
                    break;
                case 51:
                    MonsterExp = 359;
                    break;
                case 52:
                    MonsterExp = 365;
                    break;
                case 54:
                    MonsterExp = 377;
                    break;
                case 55:
                    MonsterExp = 383;
                    break;
                case 56:
                    MonsterExp = 389;
                    break;
                case 57:
                    MonsterExp = 395;
                    break;
                case 59:
                    MonsterExp = 407;
                    break;
                case 60: // 猴塞雷(Boss)
                    break;
                case 70: // 羊桃之(Boss)
                    break;
            }
            return MonsterExp;
        }
    }
}
