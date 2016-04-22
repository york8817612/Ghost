
namespace Server.Common.Net
{
    public enum InteroperabilityMessage : ushort
    {
        RegistrationRequest,
        RegistrationResponse,

        LoadProportionRequest,
        LoadProportionResponse,

        CharacterEntriesRequest,
        CharacterEntriesResponse,

        CharacterNameCheckRequest,
        CharacterNameCheckResponse,

        CharacterCreationRequest,
        CharacterCreationResponse,

        CharacterDeletionRequest,
        CharacterDeletionResponse,

        CharPortRequest,
        CharPortResponse,

        GamePortRequest,
        GamePortResponse,

        MessagePortRequest,
        MessagePortResponse,

        ShopPortRequest,
        ShopPortResposne,

        WhisperFindRequest,
        WhisperFindResult
    }

    public enum LoginClientMessage : byte
    {
        LOGIN_REQ = 0x30,
        SERVERLIST_REQ = 0x32,
        GAME_REQ = 0x34
    }

    public enum ClientMessage : ushort
    {
        LOGIN_SERVER = 0x55AA,
        SERVER = 0x4D,

        // Char
        MYCHAR_INFO_REQ = 0x8,
        CREATE_MYCHAR_REQ = 0xA,
        CHECK_SAMENAME_REQ = 0xC,
        DELETE_MYCHAR_REQ = 0xE,

        // Game
        COMMAND_REQ = 0x10,
        CHAT_REQ = 0x17,
        GAMELOG_REQ = 0x18,
        ENTER_WARP_ACK_REQ = 0x1D,
        ATTACK_MONSTER = 0x69,
        USE_WATER = 0x6F,
        PLAYER_DAMAGE = 0x70,
        CAN_WARP_ACK_REQ = 0x85
    }

    public enum LoginServerMessage : byte
    {
        // Login
        LOGIN_ACK = 0x31,
        SERVERLIST_ACK = 0x33,
        GAME_ACK = 0x35,
    }

    public enum ServerMessage : ushort
    {
        // Char
        MYCHAR_INFO_ACK = 0x9,
        CREATE_MYCHAR_ACK = 0xB,
        CHECK_SAMENAME_ACK = 0xD,
        DELETE_MYCHAR_ACK = 0xF,

        // Game
        NOTICE = 0x12,
        // 0x13
        GAMELOG = 0x14,

        USER_INFO = 0x16,
        CHAT = 0x17,

        ENTER_FIELD_ACK = 0x19,

        ENTER_MAP_START = 0x1C,
        //ENTER_MAP_END = 0x1C,

        ENTER_WARP_ACK = 0x1E,
        //WARP_ACK = 0x1E,
        LEAVE_WARP_ACK = 0x1F,
        BADUSER = 0x20,

        UDPLOG_ACK = 0x25,

        MON_SPAWN = 0x38, // 2015/10/31

        MON_REGEN = 0x3F,

        MON_ALLCREATE = 0x42,
        MON_HPDOWN = 0x43,
        USER_CREATE = 0x44,

        PLAYER_DEAD_ACK = 0x48,
        // 0x4A
        // 0x4B

        // 0x4D
        // 0x4E
        ITEM_ALLCREATE = 0x4F,
        CHAR_ALL = 0x50,
        CHAR_HPSP = 0x51,
        CHAR_MAXHPPLUS = 0x52,
        CHAR_MAXSPPLUS = 0x53,
        CHAR_ASPPLUS = 0x54,
        CHAR_SPDPLUS = 0x55,
        CHAR_LJUMPPLUS = 0x56,
        CHAR_PAPLUS = 0x57,
        CHAR_MAPLUS = 0x58,
        CHAR_DEFPLUS = 0x59,
        CHAR_DEFPLUS_SKILL = 0x5A,
        CHAR_LVEXP = 0x5B,
        // 0x5C
        CHAR_LEVELUP = 0x5D,

        CHAR_FAME = 0x5F,
        CHAR_STATUP_ACK = 0x60,
        CHAR_HIDE = 0x61,

        CHAR_USERSP_ACK = 0x63,
        INVEN_ALL = 0x64,   // 全部
        INVEN_EQUIP = 0x65, // 裝備
        INVEN_EQUIP1 = 0x66,// 裝備(1)
        INVEN_EQUIP2 = 0x67,// 封印物(2)
        INVEN_SPEND3 = 0x68,// 消耗(3)
        INVEN_OTHER4 = 0x69,// 其他(4)
        INVEN_PET5 = 0x6A,  // 寵物(5)
        INVEN_MONEY = 0x6B, // 錢

        INVEN_SELECTSLOT_ACK = 0x6E,

        INVEN_USESPEND_START = 0x71,
        INVEN_USESPEND_END = 0x72,
        SKILL_ALL = 0x73,

        SKILL_LEVELUP_ACK = 0x75,

        // 0x77,
        // 0x78
        QUEST_ALL = 0x79,

        // 0x80

        CAN_WARP_ACK = 0x86,
        // 0x87
        CONDITION_CLEAR = 0x88,

        // 0x92
        // 0x93
        // 0x94 // 交易準備
        // 0x95 // 交易確認
        // 0x96 // 交易取消
        // 0x97 // 交易失敗
        // 0x98 // 交易成功
        // 0x9A
        // 0x9B
        // 0x9C
        // 0x9D

        // 0xA0 // 離開隊伍
        // 0xA1
        // 0xA2 // 隊伍解散

        PVP_REQ = 0xA4,
        PVP_ACK = 0xA5,
        PVP_START = 0xA6,
        PVP_END = 0xA7,

        QUICKSLOTALL = 0xA9,
        STORE_INFO = 0xAA,
        STORE_MONEYINFO = 0xAB,
        // 0xAC
        // 0xAD

        // 0xB0
        // 0xB1
        // 0xB2

        // 0xB4
        // 0xB5

        LOGOUT_ACK = 0xC9,

        PSHOP_OPENACK = 0xCE,

        PSHOP_SELLSTARTACK = 0xD0,
        PSHOP_SELLEND = 0xD1,
        PSHOP_SELLINFO = 0xD2,

        PSHOP_INFOACK = 0xD4,

        PSHOP_BUYACK = 0xD6,

        EVENTITEM_ACK = 0xD9,

        ALIVE_CHECK = 0xDE,

        FISH_ACK = 0xE1,

        TAROT_ACK = 0xE3,

        INVEN_CASH = 0xE6,

        CASH_BUY_ACK = 0xE8,

        CASH_GIFT_ACK = 0xEA,

        CASH_TO_INVEN_ACK = 0xF0,

        CASH_GUIHONCASH = 0xF2,
        CASH_MGAMECASH_ACK = 0xF3,

        CASH_INVENTOCASHSTORE_ACK = 0xF5,

        INVEN_USESPEND_SHOUT_ACK = 0xFB,

        CASH_CHECKCHARNAME_ACK = 0xFD,

        // 0xFF // 物品賣出
        SERVER_CHAR_SHOWINFO = 0x100,

        PET_NAME_ACK = 0x102,
        PET_LEVUP = 0x103,

        PET_DIE = 0x105,
        PET_HP = 0x106,
        PET_LIFE = 0x107,
        PET_LIFE_END = 0x108,

        BOPEA_ACK = 0x11B,
        T_CHAT = 0x11C,

        // 0x11E
        CASHSHOPLIST1_ACK = 0x11F,
        CASHSHOPLIST2_ACK = 0x120,
        CASHSHOPLIST3_ACK = 0x121,
        CASHSHOPLIST4_ACK = 0x122,
        CASHSHOPLIST5_ACK = 0x123,
        CASHSHOPLIST6_ACK = 0x124,
        CASHSHOPLIST7_ACK = 0x125,
        CASHSHOPLIST8_ACK = 0x126,
        CASHSHOPLIST9_ACK = 0x127,

        PET_SELL_ACK = 0x12A,

        GIFT_STORE = 0x12C,

        // 0x12E,

        // 0x130

        // 0x132

        // 0x134

        // 0x138
        // 0x139

        MINING_ACK = 0x13B,

        MINE_CHANGE_ACK = 0x13D,

        UPGRADE_ITEM_ACK = 0x13F,

        // 0x142

        PETRIDE_ACK = 0x144,
        // 0x145

        UPGRADE_ACCITEM_ACK = 0x147,

        // 0x149
        // 0x14A
        // 0x14B
        // 0x14C
        // 0x14D

        // 0x14F,

        // 0x151,

        // 0x153,

        ENTRY_FW_ACK = 0x158,

        ENTRY_FWINSERT_ACK = 0x15A,

        ENTRY_FWDELETE_ACK = 0x15C,

        ENTER_FW_ACK = 0x15E,
        FW_MANAGER = 0x15F,
        FW_START = 0x160,
        FW_END = 0x161,
        FW_POINTUP = 0x162,
        FW_RESULT = 0x163,
        FW_DISCOUNTFACTION = 0x164,
        FW_SERVERTIME = 0x165,
        FW_MYSTATE = 0x166,
        FW_USERSTATE = 0x167,

        CHANGE_CHARNAME_ACK = 0x169,

        // 0x16D
        // 0x16E

        CHAR_REFLECTION = 0x170,

        // 0x173

        // 0x175
        // 0x176

        MOB_REFLECT = 0x178,

        // 0x17A
        // 0x17B
        CHAR_SKILL_10110 = 0x17C,
        CHAR_SKILL_10408 = 0x17D,
        CHAR_SKILL_10409 = 0x17E,
        CHAR_SKILL_10410 = 0x17F,
        CHAR_SKILL_31402 = 0x180,
        CHAR_SKILL_32402 = 0x181,

        // 0x183
        // 0x184
        // 0x185
        // 0x186
        // 0x187
        // 0x188

        CHAR_GOD = 0x18B,
        CHAR_HEALING = 0x18C,

        CHAR_SHADOW = 0x194,

        // 0x197
        COMMITSHOP = 0x198,

        COMMITSHOP_OPEN_ACK = 0x19D,

        COMMITSHOP_SELLSTART_ACK = 0x19F,

        COMMITSHOP_SELLEND = 0x1A0,
        COMMITSHOP_SELL_INFO_ACK = 0x1A1,

        COMMITSHOP_INFO_ACK = 0x1A3,

        COMMITSHOP_BUY_ACK = 0x1A5,

        CHAR_MAX_SPHP_PLUS = 0x1A7,
        CW_PLAYSTATE = 0x1A8,
        PW_PLAYSTATE = 0x1A9,

        // 0x1AA

        IDENTIFY_ACK = 0x1AD,
        FREE_WARPLIST = 0x1AE,

        BADUSERCHECKSTATE = 0x1B0,
        TOY_LEVUP = 0x1B1,

        TOY_LIFE = 0x1BA,
        TOY_LIFE_END = 0x1BB,
        // 0x1BC
        // 0x1BD

        EXCHANGE_ACK = 0x1C0,

        // 0x1C2

        // 0x1C5

        // 0x1C7

        // 0x1C9

        // 0x1CB
        // 0x1CC
        // 0x1CD,

        OXSYSTEM_MANAGER = 0x1CF,

        OXSYSTEM_QUESTION_ACK = 0x1D1,
        OXSYSTEM_ANSWER = 0x1D2,
        OXSYSTEM_RESULT = 0x1D3,

        // 0x1D6
        CHAR_SKILL_餌熱 = 0x1D7,
        // 0x1D9

        // 0x1DA
        stInDunMessage = 0x1DB,
        stInDunStageEffect = 0x1DC,
        stInDunTimer = 0x1DD,
        stIndunEnterAck = 0x1DF,

        JERYUNG_BIGHIT = 0x1E1,

        // 0x1E4

        // 0x1E6

        // 0x1E8

        // 0x1EA

        // 0x1EC

        // 0x1EE

        // 0x1F0
        // 0x1F1

        // 0x1F3
        COUPLE_EFEECT_ENTERWARP = 0x1F4,
        COUPLE_EFEECT_ALLUSER = 0x1F5,

        // 0x1F7
        // 0x1F8
        // 0x1F9
        EX_USER_CREATE = 0x1FA,

        NOTICE_BOARD_STATE = 0x1FC,

        SOULSTACKWAR_CREATE_ROOM_ACK = 0x201,
        SOULSTACKWAR_REQUEST = 0x202,

        SOULSTACKWAR_CREATE_CHALLENGE_ACK = 0x204,

        SOULSTACKWAR_STATE = 0x206,

        SOULSTACKWAR_TIME = 0x207,

        SOULSTACKWAR_ITEM_USE_ACK = 0x209,
        SOULSTACKWAR_FINISH = 0x20A,

        SOULSTACKWAR_RANKING_ACK = 0x20C,

        SOULSTACKWAR_READY = 0x212,
    }
}
