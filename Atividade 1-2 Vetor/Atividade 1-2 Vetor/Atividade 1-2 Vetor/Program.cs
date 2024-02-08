using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1_2_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int criando vetor para selcionar os numeros em ordem
            int[] vetor = { 6, 9, 8, 5, -2 };
            
            //usando if e else para o variades 
            if (Verifica(vetor, 8))
            {
                Console.WriteLine("Está em ordem crescente");
            }
            else
            {
                Console.WriteLine("Está em ordem decrescente");

            }
            Console.ReadLine();


        }
        static bool Verifica(int[] vetor, int Mostra)
        {
            // Verifica se o vetor tem menos de 2 elementos, pois um vetor com 0 ou 1 elemento já está ordenado
            if (Mostra < 5)
            {
                return true;
            }

            // Verifica se cada elemento é menor ou igual ao próximo elemento
            for (int i = 0; i < Mostra - 1; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    return false;
                }
            }
            //Se colocar false fica em ordem decrescente, se colocar true fica em crescente
            return true;
        }
    }
}
