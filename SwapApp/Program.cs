namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
           // Swap(a, b);
            SwapRef(ref a, ref b);
            Console.WriteLine($"a:{a}, b:{b}");
            
        }

        public static void Swap(int a, int b) 
        {
            int temp = a;
            a = b;
            b = temp;
            
        }

        public static void SwapRef(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }


        public static (int, int) SwapWithTuple(int a, int b)
        {
            return (b, a);
        }
    }

}
