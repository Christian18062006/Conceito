using System;

namespace Conceito
{
    class Program
    {

        public static string retornaConceito(double media)
        {
            if (media <= 4.9)
            {
                return ("d.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                return ("c");
            }
            else if (media >= 7.0 && media <= 8.9)
            {
                return ("b");
            }
            else
            {
                return ("a");
            }
        }

        static void Main(string[] args)
        {
            double media;
            Console.WriteLine("Conceito média.");
            Console.WriteLine("digite a média final do aluno.");
            media = double.Parse(Console.ReadLine());
            string retornaLetra = retornaConceito(media);
            Console.WriteLine(retornaLetra);

        }
    }
}