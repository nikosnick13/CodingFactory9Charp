using static System.Console;

namespace NumberRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatNum = 0F;
            double doubleNum = 0D;
            
            WriteLine("Εισαγετε δύο δεκαδικά αριθμούς:");

            if(!float.TryParse(ReadLine(), out floatNum))
            {
                 WriteLine("Λάθος είσοδος για τον πρώτο αριθμό.");
                return;
            }

            if(!double.TryParse(ReadLine(), out doubleNum))
            {
                WriteLine("Λάθος είσοδος για τον δεύτερο αριθμό.");
                return;
            }

            WriteLine($"Ο πρώτος αριθμός είναι: {floatNum,10:N2}");
            WriteLine($"Ο δεύτερος αριθμός είναι: {doubleNum,3:N2}");
        }
    }
}
