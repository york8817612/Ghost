namespace Server
{
    public sealed class Shortcut
    {
        public int SkillID { get; set; }
        public byte Type { get; set; }
        public byte Slot { get; set; }

        public Shortcut(int SkillID, byte Type, byte Slot)
        {
            this.SkillID = SkillID;
            this.Type = Type;
            this.Slot = Slot;
        }
    }
}
