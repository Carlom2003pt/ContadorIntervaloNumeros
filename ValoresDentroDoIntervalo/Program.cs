using System;

namespace ValoresDentroDoIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorIn=0, quantidade, contadorOut=0;
            double numeros;
            Console.WriteLine("Insira quantos números deseja!");
            quantidade = Convert.ToInt32(Console.ReadLine());
            
            for(int i =0;i<quantidade;i++)
            {
                Console.WriteLine("Digite um número: ");
                numeros = double.Parse(Console.ReadLine());

                if (numeros >= 10 && numeros <= 20)
                {
                    contadorIn = contadorIn + 1;
                }
                else
                {
                    contadorOut = contadorOut + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total de Números: " + quantidade);
            Console.WriteLine("In: " + contadorIn);
            Console.WriteLine("Out: " + contadorOut);
            
            
        }
    }
}
