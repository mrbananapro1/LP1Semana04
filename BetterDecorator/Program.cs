using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Erro: Faltam argumentos. Por favor, forneça uma string, um char e um número inteiro.");
                return;
            }
            string str = args[0];
            char dec = args[1][0]; // Pegando o primeiro caractere da segunda string
            int repeat = int.Parse(args[2]);
            
            Console.WriteLine(Decor(str, dec, repeat));
        }

            private static string Decor(string s, char dec, int repeat)
        {
            string decoration = new string(dec, repeat);
            return $"{decoration}{s}{decoration}";
        }
    }
}
