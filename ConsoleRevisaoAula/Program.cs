using System;

namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media <5)
            {
                
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }

            Console.WriteLine("A média é " + media);

        }
    }
}
