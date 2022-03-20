using AccountExceptions.Entities;
using AccountExceptions.Entities.Exceptions;

namespace AccountExceptions
{
    class ProgramAccount
    {
        static void Main(string[] args)
        {
            Start();

            void Start()
            {
                try
                {
                    Console.WriteLine("Enter account data: ");
                    Console.Write("Number: ");
                    int NumberAccount = int.Parse(Console.ReadLine());

                    Console.Write("Holder name: ");
                    string HolderName = Console.ReadLine();

                    Console.Write("Initial balance: ");
                    double Balance = double.Parse(Console.ReadLine());

                    Console.Write("Withdraw limit: ");
                    double Limit = double.Parse(Console.ReadLine());

                    Account account = new Account(NumberAccount, HolderName, Balance, Limit);
                    Console.WriteLine(account.ToString());

                    Console.Write("Enter amount for withdraw: ");
                    double AmountWithdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(AmountWithdraw);
                    Console.WriteLine(account.ToString());
                }
                catch (DomainException e) { Console.WriteLine("Error! " + e.Message); Start(); }
                catch (IOException e) { Console.WriteLine("Error! " + e.Message); Start(); }
                catch (OutOfMemoryException e) { Console.WriteLine("Error! " + e.Message); Start(); }
                catch (ArgumentNullException e) { Console.WriteLine("Error! " + e.Message); Start(); }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine("Error! " + e.Message); Start(); }
                catch (FormatException e) { Console.WriteLine("Error! " + e.Message); Start(); }

            }


        }
    }
}