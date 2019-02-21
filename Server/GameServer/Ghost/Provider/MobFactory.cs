using Server.Common.Data;
using Server.Common.IO;
using System.Collections.Generic;

namespace Server.Ghost.Provider
{
    public static class MobFactory
    {
        public static List<Loot> Drop_Data = new List<Loot>();

        public static int MonsterMaxHP(int MonsterLevel)
        {
            int MonsterHP = short.MaxValue;
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
                case 4:
                    MonsterHP = 120;
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
                case 9:
                    MonsterHP = 280;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterHP = 700;
                    break;

                // 11

                case 12:
                    MonsterHP = 590;
                    break;
                case 13:
                    MonsterHP = 640;
                    break;
                case 14:
                    MonsterHP = 690;
                    break;
                case 15:
                    MonsterHP = 735;
                    break;
                case 16:
                    MonsterHP = 780;
                    break;
                case 17:
                    MonsterHP = 830;
                    break;
                case 18:
                    MonsterHP = 880;
                    break;

                // 19

                case 20: // 銅鈴眼(Boss)
                    MonsterHP = 2900;
                    break;
                case 21:
                    MonsterHP = 2400;
                    break;
                case 22:
                    MonsterHP = 2600;
                    break;
                case 23:
                    MonsterHP = 2700;
                    break;
                case 24:
                    MonsterHP = 2800;
                    break;
                case 25:
                    MonsterHP = 3050;
                    break;
                case 26:
                    MonsterHP = 3300;
                    break;
                case 27:
                    MonsterHP = 3450;
                    break;
                case 28:
                    MonsterHP = 3600;
                    break;

                // 29

                case 30: // 豬大長(Boss)
                    MonsterHP = 29200;
                    break;
                case 32:
                    MonsterHP = 4700;
                    break;
                case 33:
                    MonsterHP = 4900;
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
                case 100:
                    MonsterHP = 420000;
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
                case 4:
                    MonsterExp = 11;
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
                case 9:
                    MonsterExp = 32;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterExp = 42;
                    break;

                // 11

                case 12:
                    MonsterExp = 36;
                    break;
                case 13:
                    MonsterExp = 39;
                    break;
                case 14:
                    MonsterExp = 42;
                    break;
                case 15:
                    MonsterExp = 45;
                    break;
                case 16:
                    MonsterExp = 48;
                    break;
                case 17:
                    MonsterExp = 51;
                    break;
                case 18:
                    MonsterExp = 54;
                    break;

                // 19

                case 20: // 銅鈴眼(Boss)
                    MonsterExp = 90;
                    break;
                case 21:
                    MonsterExp = 145;
                    break;
                case 22:
                    MonsterExp = 153;
                    break;
                case 23:
                    MonsterExp = 161;
                    break;
                case 24:
                    MonsterExp = 169;
                    break;
                case 25:
                    MonsterExp = 177;
                    break;
                case 26:
                    MonsterExp = 185;
                    break;
                case 27:
                    MonsterExp = 193;
                    break;
                case 28:
                    MonsterExp = 201;
                    break;

                // 29

                case 30: // 豬大長(Boss)
                    MonsterExp = 217;
                    break;
                case 32:
                    MonsterExp = 233;
                    break;
                case 33:
                    MonsterExp = 241;
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

        public static byte MoveType(int MonsterID)
        {
            byte MoveType = 1;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    MoveType = 1;
                    break;
                case 1000201: // 大目仔
                    MoveType = 1;
                    break;
                case 1000301: // 美人魚
                    MoveType = 1;
                    break;
                case 1000401:
                    MoveType = 1;
                    break;
                case 1000501: // 蘆花
                    MoveType = 0;
                    break;
                case 1000601:
                    MoveType = 1;
                    break;
                case 1000701:
                    MoveType = 1;
                    break;
                case 1000702:
                    MoveType = 1;
                    break;
                case 1000801:
                    MoveType = 0;
                    break;
                case 1000901:
                    MoveType = 1;
                    break;
                case 1001001: // 毛毛(Boss)
                    MoveType = 1;
                    break;
                case 1001101:
                    MoveType = 1;
                    break;
                case 1001201:
                    MoveType = 1;
                    break;
                case 1001301:
                    MoveType = 1;
                    break;
                case 1001401:
                    MoveType = 1;
                    break;
                case 1001501:
                    MoveType = 1;
                    break;
                case 1001601:
                    MoveType = 1;
                    break;
                case 1001701:
                    MoveType = 1;
                    break;
                case 1001801:
                    MoveType = 1;
                    break;
                case 1001901:
                    MoveType = 0;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    MoveType = 1;
                    break;
                case 1002101:
                    MoveType = 1;
                    break;
                case 1002201:
                    MoveType = 1;
                    break;
                case 1002301:
                    MoveType = 1;
                    break;
                case 1002401:
                    MoveType = 3;
                    break;
                case 1002501:
                    MoveType = 1;
                    break;
                case 1002601:
                    MoveType = 1;
                    break;
                case 1002701:
                    MoveType = 1;
                    break;
                case 1002801:
                    MoveType = 3;
                    break;
                case 1002901:
                    MoveType = 1;
                    break;
                case 1003001: // 豬大長(Boss)
                    MoveType = 3;
                    break;
                case 1003101:
                    MoveType = 1;
                    break;
                case 1003201:
                    MoveType = 1;
                    break;
                case 1003301:
                    MoveType = 1;
                    break;
                case 1003401:
                    MoveType = 1;
                    break;
                case 1003501:
                    MoveType = 0;
                    break;
                case 1003601:
                    MoveType = 1;
                    break;
                case 1003701:
                    MoveType = 1;
                    break;
                case 1003801:
                    MoveType = 1;
                    break;
                case 1003901:
                    MoveType = 1;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    MoveType = 3;
                    break;
                case 1004101:
                    MoveType = 0;
                    break;
                case 1004201:
                    MoveType = 1;
                    break;
                case 1004301:
                    MoveType = 3;
                    break;
                case 1004401:
                    MoveType = 1;
                    break;
                case 1004501:
                    MoveType = 1;
                    break;
                case 1004502: // 閃亮蘆花
                    MoveType = 0;
                    break;
                case 1004601:
                    MoveType = 1;
                    break;
                case 1004701:
                    MoveType = 1;
                    break;
                case 1004801:
                    MoveType = 1;
                    break;
                case 1004802: // 藍帶觸目仔
                    MoveType = 1;
                    break;
                case 1004901:
                    MoveType = 1;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    MoveType = 3;
                    break;
                case 1005101:
                    MoveType = 1;
                    break;
                case 1005201:
                    MoveType = 1;
                    break;
                case 1005301:
                    MoveType = 1;
                    break;
                case 1005401:
                    MoveType = 1;
                    break;
                case 1005501:
                    MoveType = 1;
                    break;
                case 1005601:
                    MoveType = 1;
                    break;
                case 1005701:
                    MoveType = 1;
                    break;
                case 1005801:
                    MoveType = 1;
                    break;
                case 1005901:
                    MoveType = 1;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    MoveType = 3;
                    break;
                case 1007001: // 羊桃之(Boss)
                    MoveType = 3;
                    break;
                case 1008001:
                    MoveType = 3;
                    break;
                case 1010002:
                    MoveType = 1;
                    break;
            }
            return MoveType;
        }

        public static byte AttackType(int MonsterID)
        {
            byte AttackType = 1;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    AttackType = 0;
                    break;
                case 1000201: // 大目仔
                    AttackType = 0;
                    break;
                case 1000301: // 美人魚
                    AttackType = 0;
                    break;
                case 1000401:
                    AttackType = 0;
                    break;
                case 1000501: // 蘆花
                    AttackType = 2;
                    break;
                case 1000601:
                    AttackType = 0;
                    break;
                case 1000701:
                    AttackType = 1;
                    break;
                case 1000702:
                    AttackType = 1;
                    break;
                case 1000801:
                    AttackType = 1;
                    break;
                case 1000901:
                    AttackType = 1;
                    break;
                case 1001001: // 毛毛(Boss)
                    AttackType = 1;
                    break;
                case 1001101:
                    AttackType = 1;
                    break;
                case 1001201:
                    AttackType = 1;
                    break;
                case 1001301:
                    AttackType = 2;
                    break;
                case 1001401:
                    AttackType = 1;
                    break;
                case 1001501:
                    AttackType = 2;
                    break;
                case 1001601:
                    AttackType = 0;
                    break;
                case 1001701:
                    AttackType = 1;
                    break;
                case 1001801:
                    AttackType = 1;
                    break;
                case 1001901:
                    AttackType = 2;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    AttackType = 0;
                    break;
                case 1002101:
                    AttackType = 0;
                    break;
                case 1002201:
                    AttackType = 2;
                    break;
                case 1002301:
                    AttackType = 1;
                    break;
                case 1002401:
                    AttackType = 1;
                    break;
                case 1002501:
                    AttackType = 0;
                    break;
                case 1002601:
                    AttackType = 1;
                    break;
                case 1002701:
                    AttackType = 1;
                    break;
                case 1002801:
                    AttackType = 1;
                    break;
                case 1002901:
                    AttackType = 6;
                    break;
                case 1003001: // 豬大長(Boss)
                    AttackType = 3;
                    break;
                case 1003101:
                    AttackType = 7;
                    break;
                case 1003201:
                    AttackType = 1;
                    break;
                case 1003301:
                    AttackType = 6;
                    break;
                case 1003401:
                    AttackType = 1;
                    break;
                case 1003501:
                    AttackType = 1;
                    break;
                case 1003601:
                    AttackType = 2;
                    break;
                case 1003701:
                    AttackType = 1;
                    break;
                case 1003801:
                    AttackType = 1;
                    break;
                case 1003901:
                    AttackType = 1;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    AttackType = 3;
                    break;
                case 1004101:
                    AttackType = 4;
                    break;
                case 1004201:
                    AttackType = 1;
                    break;
                case 1004301:
                    AttackType = 1;
                    break;
                case 1004401:
                    AttackType = 2;
                    break;
                case 1004501:
                    AttackType = 1;
                    break;
                case 1004502: // 閃亮蘆花
                    AttackType = 2;
                    break;
                case 1004601:
                    AttackType = 1;
                    break;
                case 1004701:
                    AttackType = 1;
                    break;
                case 1004801:
                    AttackType = 1;
                    break;
                case 1004802: // 藍帶觸目仔
                    AttackType = 1;
                    break;
                case 1004901:
                    AttackType = 1;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    AttackType = 3;
                    break;
                case 1005101:
                    AttackType = 1;
                    break;
                case 1005201:
                    AttackType = 1;
                    break;
                case 1005301:
                    AttackType = 1;
                    break;
                case 1005401:
                    AttackType = 1;
                    break;
                case 1005501:
                    AttackType = 1;
                    break;
                case 1005601:
                    AttackType = 2;
                    break;
                case 1005701:
                    AttackType = 2;
                    break;
                case 1005801:
                    AttackType = 1;
                    break;
                case 1005901:
                    AttackType = 1;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    AttackType = 3;
                    break;
                case 1007001: // 羊桃之(Boss)
                    AttackType = 3;
                    break;
                case 1008001:
                    AttackType = 3;
                    break;
                case 1010002:
                    AttackType = 0;
                    break;
            }
            return AttackType;
        }

        public static int Attack1(int MonsterID)
        {
            int Attack = short.MaxValue;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    Attack = 4;
                    break;
                case 1000201: // 大目仔
                    Attack = 6;
                    break;
                case 1000301: // 美人魚
                    Attack = 7;
                    break;
                case 1000401:
                    Attack = 8;
                    break;
                case 1000501: // 蘆花
                    Attack = 14;
                    break;
                case 1000601:
                    Attack = 14;
                    break;
                case 1000701:
                    Attack = 18;
                    break;
                case 1000702:
                    Attack = 18;
                    break;
                case 1000801:
                    Attack = 21;
                    break;
                case 1000901:
                    Attack = 33;
                    break;
                case 1001001: // 毛毛(Boss)
                    Attack = 24;
                    break;
                case 1001101:
                    Attack = 40;
                    break;
                case 1001201:
                    Attack = 39;
                    break;
                case 1001301:
                    Attack = 51;
                    break;
                case 1001401:
                    Attack = 57;
                    break;
                case 1001501:
                    Attack = 67;
                    break;
                case 1001601:
                    Attack = 52;
                    break;
                case 1001701:
                    Attack = 75;
                    break;
                case 1001801:
                    Attack = 87;
                    break;
                case 1001901:
                    Attack = 100;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    Attack = 164;
                    break;
                case 1002101:
                    Attack = 119;
                    break;
                case 1002201:
                    Attack = 124;
                    break;
                case 1002301:
                    Attack = 138;
                    break;
                case 1002401:
                    Attack = 139;
                    break;
                case 1002501:
                    Attack = 132;
                    break;
                case 1002601:
                    Attack = 146;
                    break;
                case 1002701:
                    Attack = 153;
                    break;
                case 1002801:
                    Attack = 158;
                    break;
                case 1002901:
                    Attack = 163;
                    break;
                case 1003001: // 豬大長(Boss)
                    Attack = 256;
                    break;
                case 1003101:
                    Attack = 183;
                    break;
                case 1003201:
                    Attack = 191;
                    break;
                case 1003301:
                    Attack = 185;
                    break;
                case 1003401:
                    Attack = 201;
                    break;
                case 1003501:
                    Attack = 209;
                    break;
                case 1003601:
                    Attack = 214;
                    break;
                case 1003701:
                    Attack = 218;
                    break;
                case 1003801:
                    Attack = 224;
                    break;
                case 1003901:
                    Attack = 230;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    Attack = 413;
                    break;
                case 1004101:
                    Attack = 250;
                    break;
                case 1004201:
                    Attack = 331;
                    break;
                case 1004301:
                    Attack = 342;
                    break;
                case 1004401:
                    Attack = 349;
                    break;
                case 1004501:
                    Attack = 354;
                    break;
                case 1004502: // 閃亮蘆花
                    Attack = 354;
                    break;
                case 1004601:
                    Attack = 363;
                    break;
                case 1004701:
                    Attack = 370;
                    break;
                case 1004801:
                    Attack = 405;
                    break;
                case 1004802: // 藍帶觸目仔
                    Attack = 405;
                    break;
                case 1004901:
                    Attack = 414;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    Attack = 520;
                    break;
                case 1005101:
                    Attack = 481;
                    break;
                case 1005201:
                    Attack = 467;
                    break;
                case 1005301:
                    Attack = 465;
                    break;
                case 1005401:
                    Attack = 481;
                    break;
                case 1005501:
                    Attack = 495;
                    break;
                case 1005601:
                    Attack = 504;
                    break;
                case 1005701:
                    Attack = 516;
                    break;
                case 1005801:
                    Attack = 524;
                    break;
                case 1005901:
                    Attack = 481;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    Attack = 691;
                    break;
                case 1007001: // 羊桃之(Boss)
                    Attack = 1466;
                    break;
                case 1008001:
                    Attack = 1786;
                    break;
                case 1010002:
                    Attack = 0;
                    break;
            }
            return Attack;
        }

        public static int Attack2(int MonsterID)
        {
            int Attack = short.MaxValue;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    Attack = 6;
                    break;
                case 1000201: // 大目仔
                    Attack = 12;
                    break;
                case 1000301: // 美人魚
                    Attack = 18;
                    break;
                case 1000401:
                    Attack = 21;
                    break;
                case 1000501: // 蘆花
                    Attack = 24;
                    break;
                case 1000601:
                    Attack = 40;
                    break;
                case 1000701:
                    Attack = 39;
                    break;
                case 1000702:
                    Attack = 39;
                    break;
                case 1000801:
                    Attack = 47;
                    break;
                case 1000901:
                    Attack = 64;
                    break;
                case 1001001: // 毛毛(Boss)
                    Attack = 89;
                    break;
                case 1001101:
                    Attack = 45;
                    break;
                case 1001201:
                    Attack = 62;
                    break;
                case 1001301:
                    Attack = 70;
                    break;
                case 1001401:
                    Attack = 76;
                    break;
                case 1001501:
                    Attack = 82;
                    break;
                case 1001601:
                    Attack = 86;
                    break;
                case 1001701:
                    Attack = 90;
                    break;
                case 1001801:
                    Attack = 105;
                    break;
                case 1001901:
                    Attack = 120;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    Attack = 197;
                    break;
                case 1002101:
                    Attack = 143;
                    break;
                case 1002201:
                    Attack = 149;
                    break;
                case 1002301:
                    Attack = 166;
                    break;
                case 1002401:
                    Attack = 167;
                    break;
                case 1002501:
                    Attack = 171;
                    break;
                case 1002601:
                    Attack = 176;
                    break;
                case 1002701:
                    Attack = 184;
                    break;
                case 1002801:
                    Attack = 190;
                    break;
                case 1002901:
                    Attack = 196;
                    break;
                case 1003001: // 豬大長(Boss)
                    Attack = 308;
                    break;
                case 1003101:
                    Attack = 245;
                    break;
                case 1003201:
                    Attack = 256;
                    break;
                case 1003301:
                    Attack = 249;
                    break;
                case 1003401:
                    Attack = 272;
                    break;
                case 1003501:
                    Attack = 287;
                    break;
                case 1003601:
                    Attack = 291;
                    break;
                case 1003701:
                    Attack = 297;
                    break;
                case 1003801:
                    Attack = 304;
                    break;
                case 1003901:
                    Attack = 315;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    Attack = 496;
                    break;
                case 1004101:
                    Attack = 0;
                    break;
                case 1004201:
                    Attack = 398;
                    break;
                case 1004301:
                    Attack = 411;
                    break;
                case 1004401:
                    Attack = 419;
                    break;
                case 1004501:
                    Attack = 425;
                    break;
                case 1004502: // 閃亮蘆花
                    Attack = 425;
                    break;
                case 1004601:
                    Attack = 436;
                    break;
                case 1004701:
                    Attack = 444;
                    break;
                case 1004801:
                    Attack = 486;
                    break;
                case 1004802: // 藍帶觸目仔
                    Attack = 486;
                    break;
                case 1004901:
                    Attack = 497;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    Attack = 624;
                    break;
                case 1005101:
                    Attack = 578;
                    break;
                case 1005201:
                    Attack = 561;
                    break;
                case 1005301:
                    Attack = 558;
                    break;
                case 1005401:
                    Attack = 578;
                    break;
                case 1005501:
                    Attack = 594;
                    break;
                case 1005601:
                    Attack = 605;
                    break;
                case 1005701:
                    Attack = 620;
                    break;
                case 1005801:
                    Attack = 629;
                    break;
                case 1005901:
                    Attack = 578;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    Attack = 830;
                    break;
                case 1007001: // 羊桃之(Boss)
                    Attack = 1760;
                    break;
                case 1008001:
                    Attack = 2144;
                    break;
                case 1010002:
                    Attack = 0;
                    break;
            }
            return Attack;
        }

        public static int CrashAttack(int MonsterID)
        {
            int Attack = short.MaxValue;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    Attack = 4;
                    break;
                case 1000201: // 大目仔
                    Attack = 6;
                    break;
                case 1000301: // 美人魚
                    Attack = 7;
                    break;
                case 1000401:
                    Attack = 8;
                    break;
                case 1000501: // 蘆花
                    Attack = 10;
                    break;
                case 1000601:
                    Attack = 14;
                    break;
                case 1000701:
                    Attack = 12;
                    break;
                case 1000702:
                    Attack = 18;
                    break;
                case 1000801:
                    Attack = 14;
                    break;
                case 1000901:
                    Attack = 22;
                    break;
                case 1001001: // 毛毛(Boss)
                    Attack = 18;
                    break;
                case 1001101:
                    Attack = 25;
                    break;
                case 1001201:
                    Attack = 27;
                    break;
                case 1001301:
                    Attack = 33;
                    break;
                case 1001401:
                    Attack = 40;
                    break;
                case 1001501:
                    Attack = 46;
                    break;
                case 1001601:
                    Attack = 52;
                    break;
                case 1001701:
                    Attack = 52;
                    break;
                case 1001801:
                    Attack = 64;
                    break;
                case 1001901:
                    Attack = 70;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    Attack = 102;
                    break;
                case 1002101:
                    Attack = 119;
                    break;
                case 1002201:
                    Attack = 109;
                    break;
                case 1002301:
                    Attack = 114;
                    break;
                case 1002401:
                    Attack = 110;
                    break;
                case 1002501:
                    Attack = 132;
                    break;
                case 1002601:
                    Attack = 117;
                    break;
                case 1002701:
                    Attack = 121;
                    break;
                case 1002801:
                    Attack = 126;
                    break;
                case 1002901:
                    Attack = 130;
                    break;
                case 1003001: // 豬大長(Boss)
                    Attack = 185;
                    break;
                case 1003101:
                    Attack = 151;
                    break;
                case 1003201:
                    Attack = 156;
                    break;
                case 1003301:
                    Attack = 160;
                    break;
                case 1003401:
                    Attack = 163;
                    break;
                case 1003501:
                    Attack = 169;
                    break;
                case 1003601:
                    Attack = 172;
                    break;
                case 1003701:
                    Attack = 177;
                    break;
                case 1003801:
                    Attack = 181;
                    break;
                case 1003901:
                    Attack = 185;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    Attack = 342;
                    break;
                case 1004101:
                    Attack = 250;
                    break;
                case 1004201:
                    Attack = 276;
                    break;
                case 1004301:
                    Attack = 287;
                    break;
                case 1004401:
                    Attack = 289;
                    break;
                case 1004501:
                    Attack = 296;
                    break;
                case 1004502: // 閃亮蘆花
                    Attack = 296;
                    break;
                case 1004601:
                    Attack = 302;
                    break;
                case 1004701:
                    Attack = 309;
                    break;
                case 1004801:
                    Attack = 338;
                    break;
                case 1004802: // 藍帶觸目仔
                    Attack = 338;
                    break;
                case 1004901:
                    Attack = 345;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    Attack = 470;
                    break;
                case 1005101:
                    Attack = 358;
                    break;
                case 1005201:
                    Attack = 366;
                    break;
                case 1005301:
                    Attack = 375;
                    break;
                case 1005401:
                    Attack = 384;
                    break;
                case 1005501:
                    Attack = 393;
                    break;
                case 1005601:
                    Attack = 401;
                    break;
                case 1005701:
                    Attack = 409;
                    break;
                case 1005801:
                    Attack = 418;
                    break;
                case 1005901:
                    Attack = 427;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    Attack = 605;
                    break;
                case 1007001: // 羊桃之(Boss)
                    Attack = 998;
                    break;
                case 1008001:
                    Attack = 1142;
                    break;
                case 1010002:
                    Attack = 250;
                    break;
            }
            return Attack;
        }

        public static int Defense(int MonsterID)
        {
            int Defense = short.MaxValue;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    Defense = 1;
                    break;
                case 1000201: // 大目仔
                    Defense = 1;
                    break;
                case 1000301: // 美人魚
                    Defense = 2;
                    break;
                case 1000401:
                    Defense = 3;
                    break;
                case 1000501: // 蘆花
                    Defense = 3;
                    break;
                case 1000601:
                    Defense = 4;
                    break;
                case 1000701:
                    Defense = 4;
                    break;
                case 1000702:
                    Defense = 6;
                    break;
                case 1000801:
                    Defense = 7;
                    break;
                case 1000901:
                    Defense = 10;
                    break;
                case 1001001: // 毛毛(Boss)
                    Defense = 10;
                    break;
                case 1001101:
                    Defense = 0;
                    break;
                case 1001201:
                    Defense = 28;
                    break;
                case 1001301:
                    Defense = 29;
                    break;
                case 1001401:
                    Defense = 32;
                    break;
                case 1001501:
                    Defense = 30;
                    break;
                case 1001601:
                    Defense = 33;
                    break;
                case 1001701:
                    Defense = 34;
                    break;
                case 1001801:
                    Defense = 35;
                    break;
                case 1001901:
                    Defense = 38;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    Defense = 52;
                    break;
                case 1002101:
                    Defense = 55;
                    break;
                case 1002201:
                    Defense = 56;
                    break;
                case 1002301:
                    Defense = 56;
                    break;
                case 1002401:
                    Defense = 58;
                    break;
                case 1002501:
                    Defense = 60;
                    break;
                case 1002601:
                    Defense = 63;
                    break;
                case 1002701:
                    Defense = 65;
                    break;
                case 1002801:
                    Defense = 63;
                    break;
                case 1002901:
                    Defense = 61;
                    break;
                case 1003001: // 豬大長(Boss)
                    Defense = 151;
                    break;
                case 1003101:
                    Defense = 122;
                    break;
                case 1003201:
                    Defense = 126;
                    break;
                case 1003301:
                    Defense = 128;
                    break;
                case 1003401:
                    Defense = 129;
                    break;
                case 1003501:
                    Defense = 132;
                    break;
                case 1003601:
                    Defense = 132;
                    break;
                case 1003701:
                    Defense = 134;
                    break;
                case 1003801:
                    Defense = 135;
                    break;
                case 1003901:
                    Defense = 137;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    Defense = 210;
                    break;
                case 1004101:
                    Defense = 0;
                    break;
                case 1004201:
                    Defense = 210;
                    break;
                case 1004301:
                    Defense = 211;
                    break;
                case 1004401:
                    Defense = 218;
                    break;
                case 1004501:
                    Defense = 219;
                    break;
                case 1004502: // 閃亮蘆花
                    Defense = 219;
                    break;
                case 1004601:
                    Defense = 220;
                    break;
                case 1004701:
                    Defense = 226;
                    break;
                case 1004801:
                    Defense = 225;
                    break;
                case 1004802: // 藍帶觸目仔
                    Defense = 225;
                    break;
                case 1004901:
                    Defense = 228;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    Defense = 305;
                    break;
                case 1005101:
                    Defense = 272;
                    break;
                case 1005201:
                    Defense = 275;
                    break;
                case 1005301:
                    Defense = 276;
                    break;
                case 1005401:
                    Defense = 278;
                    break;
                case 1005501:
                    Defense = 279;
                    break;
                case 1005601:
                    Defense = 281;
                    break;
                case 1005701:
                    Defense = 283;
                    break;
                case 1005801:
                    Defense = 288;
                    break;
                case 1005901:
                    Defense = 290;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    Defense = 393;
                    break;
                case 1007001: // 羊桃之(Boss)
                    Defense = 544;
                    break;
                case 1008001:
                    Defense = 750;
                    break;
                case 1010002:
                    Defense = 16;
                    break;
            }
            return Defense;
        }

        public static byte AddEffect(int MonsterID)
        {
            byte Effect = 0;
            switch (MonsterID)
            {
                case 1000101: // 賴打
                    Effect = 0;
                    break;
                case 1000201: // 大目仔
                    Effect = 0;
                    break;
                case 1000301: // 美人魚
                    Effect = 0;
                    break;
                case 1000401:
                    Effect = 0;
                    break;
                case 1000501: // 蘆花
                    Effect = 0;
                    break;
                case 1000601:
                    Effect = 0;
                    break;
                case 1000701:
                    Effect = 2;
                    break;
                case 1000702:
                    Effect = 0;
                    break;
                case 1000801:
                    Effect = 0;
                    break;
                case 1000901:
                    Effect = 0;
                    break;
                case 1001001: // 毛毛(Boss)
                    Effect = 0;
                    break;
                case 1001101:
                    Effect = 0;
                    break;
                case 1001201:
                    Effect = 1;
                    break;
                case 1001301:
                    Effect = 0;
                    break;
                case 1001401:
                    Effect = 0;
                    break;
                case 1001501:
                    Effect = 0;
                    break;
                case 1001601:
                    Effect = 0;
                    break;
                case 1001701:
                    Effect = 0;
                    break;
                case 1001801:
                    Effect = 3;
                    break;
                case 1001901:
                    Effect = 2;
                    break;
                case 1002001: // 銅鈴眼(Boss)
                    Effect = 0;
                    break;
                case 1002101:
                    Effect = 2;
                    break;
                case 1002201:
                    Effect = 0;
                    break;
                case 1002301:
                    Effect = 2;
                    break;
                case 1002401:
                    Effect = 0;
                    break;
                case 1002501:
                    Effect = 1;
                    break;
                case 1002601:
                    Effect = 1;
                    break;
                case 1002701:
                    Effect = 6;
                    break;
                case 1002801:
                    Effect = 0;
                    break;
                case 1002901:
                    Effect = 0;
                    break;
                case 1003001: // 豬大長(Boss)
                    Effect = 0;
                    break;
                case 1003101:
                    Effect = 0;
                    break;
                case 1003201:
                    Effect = 0;
                    break;
                case 1003301:
                    Effect = 3;
                    break;
                case 1003401:
                    Effect = 2;
                    break;
                case 1003501:
                    Effect = 0;
                    break;
                case 1003601:
                    Effect = 0;
                    break;
                case 1003701:
                    Effect = 0;
                    break;
                case 1003801:
                    Effect = 3;
                    break;
                case 1003901:
                    Effect = 0;
                    break;
                case 1004001: // 狗骨頭(Boss)
                    Effect = 0;
                    break;
                case 1004101:
                    Effect = 2;
                    break;
                case 1004201:
                    Effect = 0;
                    break;
                case 1004301:
                    Effect = 2;
                    break;
                case 1004401:
                    Effect = 3;
                    break;
                case 1004501:
                    Effect = 2;
                    break;
                case 1004502: // 閃亮蘆花
                    Effect = 0;
                    break;
                case 1004601:
                    Effect = 0;
                    break;
                case 1004701:
                    Effect = 0;
                    break;
                case 1004801:
                    Effect = 0;
                    break;
                case 1004802: // 藍帶觸目仔
                    Effect = 3;
                    break;
                case 1004901:
                    Effect = 0;
                    break;
                case 1005001: // 雞冠嗆(Boss)
                    Effect = 0;
                    break;
                case 1005101:
                    Effect = 0;
                    break;
                case 1005201:
                    Effect = 3;
                    break;
                case 1005301:
                    Effect = 2;
                    break;
                case 1005401:
                    Effect = 0;
                    break;
                case 1005501:
                    Effect = 1;
                    break;
                case 1005601:
                    Effect = 2;
                    break;
                case 1005701:
                    Effect = 0;
                    break;
                case 1005801:
                    Effect = 0;
                    break;
                case 1005901:
                    Effect = 1;
                    break;
                case 1006001: // 猴塞雷(Boss)
                    Effect = 0;
                    break;
                case 1007001: // 羊桃之(Boss)
                    Effect = 0;
                    break;
                case 1008001:
                    Effect = 6;
                    break;
                case 1010002:
                    Effect = 0;
                    break;
            }
            return Effect;
        }

        public static void InitializeMonsterDrop()
        {
            using (Log.Load("Loading Drops"))
            {
                foreach (dynamic datum in new Datums("drop_data").Populate())
                {
                    Drop_Data.Add(new Loot(datum));
                }
            }
        }
    }
}
