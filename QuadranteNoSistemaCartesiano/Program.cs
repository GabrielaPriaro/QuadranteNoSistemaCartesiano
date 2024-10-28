//obs: utilizando estrutura repetitiva While:
//Problema "quadrante" (adaptado de URI 1115)
//Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no
//sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence (Q1, Q2, Q3 ou Q4). O
//algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 

namespace QuadranteDoPontoCartesiado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string quadrante;

            Console.WriteLine("Digite os valores das coordenadas X e Y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    quadrante = "Q1";
                }
                else if (x < 0 && y > 0)
                {
                    quadrante = "Q2";
                }
                else if (x < 0 && y < 0)
                {
                    quadrante = "Q3";
                }
                else
                {
                    quadrante = "Q4";
                }

                Console.WriteLine($"QUADRANTE {quadrante}");

                Console.WriteLine("Digite os valores das coordenadas X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
