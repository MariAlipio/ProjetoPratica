using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico1
{
    class Selection
    {
        int min, aux;
        int[] vetor = new int[] { 2, 5, 7, 4 };

        public int[] AlgSelection(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)

                    if (vetor[j] < vetor[min])
                        min = j;
                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }

            }
            return vetor;
        }
    }
}
