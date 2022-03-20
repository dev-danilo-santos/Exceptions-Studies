using CustomExceptions.Entities;
using CustomExceptions.Entities.Exceptions;

namespace CustomExceptions
{
    public class CustomExp
    {
        static void Main(string[] args)
        {
            Start();
            void Start()
            {
                try
                {
                    Console.Write("Room Number ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Check-in date (dd/MM/yyy): ");
                    DateTime In = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyy): ");
                    DateTime Out = DateTime.Parse(Console.ReadLine());
                    Reservation reservation = new Reservation(n, In, Out);
                    Console.WriteLine(reservation);
                    Console.Write("Enter data to update the reservation for the future. ");
                    Console.Write("Check-in date (dd/MM/yyy): ");
                    DateTime Inn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyy): ");
                    DateTime Outt = DateTime.Parse(Console.ReadLine());
                    reservation.UpdateDates(Inn, Outt);
                    Console.WriteLine("\n" + reservation);
                }
                catch (DomainException e) { Console.WriteLine(e.Message);Start(); }
                catch (IOException e) { Console.WriteLine(e.Message); Start(); }
                catch (OutOfMemoryException e) { Console.WriteLine(e.Message); Start(); }
                catch (ArgumentException e) { Console.WriteLine(e.Message); Start(); }
                catch (FormatException e) { Console.WriteLine("Format Error! "+e.Message); Start(); }
                catch (Exception e) { Console.WriteLine("Unexpected Error: "+ e.Message); Start(); }
            }

        }
    }
}