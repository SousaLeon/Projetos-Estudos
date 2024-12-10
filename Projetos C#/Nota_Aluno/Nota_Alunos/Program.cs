using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota_Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.Write("\nO nome do aluno: ");
            string Nome_Aluno = Console.ReadLine();

            Console.Write("Informe quantas provas o aluno fez: ");  
            int Num_Prova = int.Parse(Console.ReadLine());

            float[] NotaProva = new float[Num_Prova];

            float MaiorNota = 0, Media = 0, SomaNota = 0;

            for (int a = 0; a < Num_Prova; a++)
            {
                Console.Write("Informe a(s) nota(s) do aluno: ");
                NotaProva[a] = float.Parse(Console.ReadLine());

                SomaNota = NotaProva[a] + SomaNota;

                if (NotaProva[a] > MaiorNota)
                {
                    MaiorNota = NotaProva[a];
                }
            }

            Media = SomaNota / Num_Prova;

            Console.WriteLine("A média do(a) aluno(a) " + Nome_Aluno + " foi: " + Media + ". Sua maior nota foi: " + MaiorNota);

            goto Inicio;
        }
    }
}