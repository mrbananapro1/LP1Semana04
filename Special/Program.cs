using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSpecial(0)); // Devolve 0
            Console.WriteLine(GetSpecial(2)); // Devolve 1
            Console.WriteLine(GetSpecial(7)); // Devolve 43
        }
        private static int GetSpecial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            
            
            
        }
    }
}
