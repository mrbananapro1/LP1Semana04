using System;

namespace BetterDecorator
{
    /// <summary>
    /// Um programa simples que decora uma string com um caractere específico em ambos os lados.
    /// </summary>
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
            char dec = args[1][0];
            int repeat = int.Parse(args[2]);
            
            Console.WriteLine(Decor(str, dec, repeat));
        }
            /// <summary>
        /// Decora uma string com um caractere específico repetido um certo número de vezes em ambos os lados.
        /// </summary>
        /// <param name="s">A string a ser decorada.</param>
        /// <param name="dec">O caractere usado para decorar a string.</param>
        /// <param name="count">O número de vezes que o caractere de decoração deve ser repetido em ambos os lados.</param>
        /// <returns>A string decorada.</returns>
            private static string Decor(string s, char dec, int repeat)
        {
            string decoration = new string(dec, repeat);
            return $"{decoration}{s}{decoration}";
        }

        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
