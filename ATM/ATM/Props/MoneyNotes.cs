namespace ATM.Props
{
    public class MoneyNotes
    {
        public MoneyNotes(int Note1, int Note5, int Note10, int Note20, int Note50, int Note100)
        {
            Notes1 = Note1;
            Notes5 = Note5;
            Notes10 = Note10;
            Notes20 = Note20;
            Notes50 = Note50;
            Notes100 = Note100;
        }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes1 { get; set; }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes5 { get; set; }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes10 { get; set; }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes20 { get; set; }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes50 { get; set; }

        [System.ComponentModel.DefaultValue(0)]
        public int Notes100 { get; set; }
    }
}