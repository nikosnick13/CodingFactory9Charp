namespace PrintingApp
{
    /// <summary>
    /// This is a simple console application that demonstrates printing values to the console.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Num = {0}", num); //placeholder
            Console.WriteLine($"Num = {num}");   //interpolation 
        }
    }
}
