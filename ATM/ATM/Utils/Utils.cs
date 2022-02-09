using ATM.Props;
using System;

namespace ATM.Utils
{
    public class Utils
    {
        public void Withdraw(MoneyNotes notes, User user, int withdraw)
        {
            try
            {
                var Count1 = 0;
                var Count5 = 0;
                var Count10 = 0;
                var Count20 = 0;
                var Count50 = 0;
                var Count100 = 0;

                checkValues(user.Balance, withdraw, notes.Notes1, notes.Notes5, notes.Notes10, notes.Notes20, notes.Notes50, notes.Notes100);

                Console.WriteLine($"\n Withdraw Value: {withdraw}");

                if (user.Balance <= 0 || (user.Balance - withdraw < 0) || withdraw < 1 || withdraw > user.Balance)
                {
                    Console.WriteLine("\n Impossible to withdraw!!");
                }
                else
                {
                    while (withdraw > 0)
                    {
                        if (withdraw - 100 >= 0 && notes.Notes100 > 0)
                        {
                            user.Balance -= 100;
                            notes.Notes100--;
                            withdraw -= 100;
                            Count100++;
                        }
                        else if (withdraw - 50 >= 0 && notes.Notes50 > 0)
                        {
                            user.Balance -= 50;
                            notes.Notes50--;
                            withdraw -= 50;
                            Count50++;
                        }
                        else if (withdraw - 20 >= 0 && notes.Notes20 > 0)
                        {
                            user.Balance -= 20;
                            notes.Notes20--;
                            withdraw -= 20;
                            Count20++;
                        }
                        else if (withdraw - 10 >= 0 && notes.Notes10 > 0)
                        {
                            user.Balance -= 10;
                            notes.Notes10--;
                            withdraw -= 10;
                            Count10++;
                        }
                        else if (withdraw - 5 >= 0 && notes.Notes5 > 0)
                        {
                            user.Balance -= 5;
                            notes.Notes5--;
                            withdraw -= 5;
                            Count5++;
                        }
                        else if (withdraw - 1 >= 0 && notes.Notes1 > 0)
                        {
                            user.Balance -= 1;
                            notes.Notes1--;
                            withdraw -= 1;
                            Count1++;
                        }
                        else
                        {
                            Console.WriteLine("\n Impossible to Withdraw, the ATM is out of notes");
                            break;
                        }
                    }
                }

                Console.WriteLine($"\n Current Balance: {user.Balance}");
                notesToWithdraw(Count1, Count5, Count10, Count20, Count50, Count100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void checkValues(int balance, int withdraw, int n1, int n5, int n10, int n20, int n50, int n100)
        {
            int[] array =
            {
                balance, withdraw, n1, n5, n10, n20, n50, n100
            };

            foreach (var value in array)
            {
                if (value < 0)
                {
                    Console.WriteLine($"\n Value cannot be negative: {value}");
                    Console.WriteLine($"\n The value: {value}, will be replaced by: 0");
                    array.SetValue(value, 0);
                }
            }
            if (n1 == 0 && n5 == 0 && n10 == 0 && n20 == 0 && n50 == 0 && n100 == 0)
            {
                Console.WriteLine("\n Impossible to Withdraw, the ATM is out of notes");
            }
        }

        public void availableNotes(MoneyNotes notes)
        {
            Console.WriteLine("\n Available Notes: ");
            Console.WriteLine($"\n 100 bills: {notes.Notes100}");
            Console.WriteLine($"\n 50 bills: {notes.Notes50}");
            Console.WriteLine($"\n 20 bills: {notes.Notes20}");
            Console.WriteLine($"\n 10 bills: {notes.Notes10}");
            Console.WriteLine($"\n 5 bills: {notes.Notes5}");
            Console.WriteLine($"\n 1 bill: {notes.Notes1}");
        }

        public void notesToWithdraw(int Count1, int Count5, int Count10, int Count20, int Count50, int Count100)
        {
            Console.WriteLine("\n Notes to Withdraw: ");
            Console.WriteLine($"\n 100 bills: {Count100}");
            Console.WriteLine($"\n 50 bills: {Count50}");
            Console.WriteLine($"\n 20 bills: {Count20}");
            Console.WriteLine($"\n 10 bills: {Count10}");
            Console.WriteLine($"\n 5 bills: {Count5}");
            Console.WriteLine($"\n 1 bill: {Count1}");
        }
    }
}