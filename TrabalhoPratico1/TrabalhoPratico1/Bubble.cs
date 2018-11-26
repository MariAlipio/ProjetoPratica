using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico1
{
    class Bubble
    {
        int i, aux, j;
        int[] vetor = new int[] { 2, 5, 7, 4 };

        public int[] AlgBubble(int[] vetor)
        {
            for (i = 0; i < vetor.Length; i++)
            {
                for (j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j + 1];
                        vetor[j + 1] = vetor[j];
                        vetor[j] = aux;
                    }

                }

            }
            return vetor;
        }
    }
}
