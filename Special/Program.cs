using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSpecial(0));
            Console.WriteLine(GetSpecial(2));
            Console.WriteLine(GetSpecial(7));
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
            else
            {
                
                return 2 * GetSpecial(n - 1) + GetSpecial(n - 2);
            }
            
            
            
        }
    }
}
