using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double v1, v2, v3, v4, v5, m1, m2, m3, m4, m5, media;
            Console.Write("Escreva o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o terceiro valor: ");
            v3 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o quarto valor: ");
            v4 = double.Parse(Console.ReadLine());

            Console.Write("Escreva o quinto valor: ");
            v5 = double.Parse(Console.ReadLine());

            m1 = 0;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = 0;

            if (v1 > 4)
            {
                m1 = v1;
            }

            if (v2 > 4)
            {
                m2 = v2;
            }

            if (v3 > 4)
            {
                m3 = v3;
            }

            if (v4 > 4)
            {
                m4 = v4;
            }
            if (v5 > 4)
            {
                m5 = v5;
            }

            media = (m1 + m2 + m3 + m4 + m5) / 5;

            Console.WriteLine("A média é: " + media);
            Console.ReadKey();
            */

            /* string c1, c2, c3, c4, c5;
            int azul;

            azul = 0;

            Console.Write("Escreva a cor do primeiro carro: ");
            c1 = Console.ReadLine().ToLower();

            Console.Write("Escreva a cor do segundo carro: ");
            c2 = Console.ReadLine().ToLower();

            Console.Write("Escreva a cor do terceiro carro: ");
            c3 = Console.ReadLine().ToLower();

            Console.Write("Escreva a cor do quarto carro: ");
            c4 = Console.ReadLine().ToLower();

            Console.Write("Escreva a cor do quinto quinto: ");
            c5 = Console.ReadLine().ToLower();

            if (c1 == "azul")
            {
                azul = azul + 1;
            }

            if (c2 == "azul")
            {
                azul = azul + 1;
            }

            if (c3 == "azul")
            {
                azul = azul + 1;
            }
            if (c4 == "azul")
            {
                azul = azul + 1;
            }
            if (c5 == "azul")
            {
                azul = azul + 1;
            }

            Console.WriteLine("A quantidade de carros azuis é: " + azul);
            */

            int v1, v2, v3, maior, meio, menor;

            Console.Write("Insira o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            v3 = int.Parse(Console.ReadLine());

            if (v1 > v2 && v2 > v3)
            {
                Console.Write("a ordem dos valores é: {0} {1} {2}", v1, v2, v3);
            }
            else if (v2 > v1 && v1 > v3)
            {
                Console.Write("a ordem dos valores é: {0} {1} {2}", v2, v1, v3);
            }


            Console.ReadKey();
        }
    }
}
