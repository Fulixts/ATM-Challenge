using ATM.Props;
using System;

namespace ATM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var options = new Utils.Utils();

                var user = new User(args[0], int.Parse(args[1]));

                MoneyNotes notes = new(int.Parse(args[2]), int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]));

                Console.WriteLine($"\n Current Account: {user.Name}");
                Console.WriteLine($"\n Balance Available: {user.Balance}");

                options.availableNotes(notes);

                Console.Write("\n Type the amount to withdraw: ");

                var withdraw = int.Parse(Console.ReadLine());

                options.Withdraw(notes, user, withdraw);

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}