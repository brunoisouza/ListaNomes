using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int[] idades = new int[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Informe o nome do {i + 1}º aluno");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Informe a idade do {i + 1}º aluno");
                idades[i] = int.Parse(Console.ReadLine());

                Console.Clear();

            }

            for (int index = 0; index < nomes.Length; index++)
            {
                Console.WriteLine($"nome: {nomes[index]} idade: {idades[index]}");
            }

            Console.ReadKey();

        }
    }
}
