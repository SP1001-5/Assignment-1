using System;


namespace FirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for parameters");
            int i = 43;
            int res = Callbyv(50, 60);
            Console.WriteLine("result : {0}",res);
            Program program = new Program();
            Console.WriteLine("Value of J is", program.Callbyr(ref i));
            Console.ReadKey();  
        }

        public static int  Callbyv(int a, int b)
        {
            return a + b;
        }

        public int Callbyr(ref int j)
        {
            j = 100;
            return j;   
        }
    }
}
