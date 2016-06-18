using System.Net;

namespace Server.Ghost
{
    public class PartyMember
    {
        public int CharacterID { get; private set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public short MaxHp { get; set; }
        public short Hp { get; set; }
        public short MaxMp { get; set; }
        public short Mp { get; set; }
        public IPAddress IP { get; set; }

        public PartyMember(int CharacterID, string Name, byte Level, short MaxHp, short Hp, short MaxMp, short Mp)
        {
            this.CharacterID = CharacterID;
            this.Name = Name;
            this.Level = Level;
            this.MaxHp = MaxHp;
            this.Hp = Hp;
            this.MaxHp = MaxMp;
            this.Mp = MaxMp;
        }
    }
}
