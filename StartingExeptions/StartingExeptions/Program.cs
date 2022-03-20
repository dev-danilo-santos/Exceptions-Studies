namespace ExceptionsMod
{
    public class ExceptionsClass 
    {
        static void Main(string[] args)
        {

            try
            {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
                int Result = N1 / N2;
                Console.WriteLine(Result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! You can't divide a number by zero! please do not do that.");
            }
            catch (FormatException) 
            {
                Console.WriteLine("You can't enter on a alphabetic letter, symbols or floating numbers, only integers numbers! ");
            }
            
        }
    }
}