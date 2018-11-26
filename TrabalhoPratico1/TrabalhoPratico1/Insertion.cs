using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico1
{
    class Insertion
    {
        int i, j, atual;
        int[] vetor = new int[] { 2, 5, 7, 4 };

        public int[] AlgInsertion(int[] vetor)
        {
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j--;
                }
                vetor[j] = atual;

            }
            return vetor;

        }
    }
}
