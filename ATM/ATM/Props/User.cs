namespace ATM.Props
{
    public class User
    {
        public User(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
        public int Balance { get; set; }
    }
}