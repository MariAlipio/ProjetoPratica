using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TrabalhoPratico1
{
    class Program
    {
        static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static int[] FormaVetorCres(int[] vetor)
        {
            int j = 1;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                {
                    vetor[i] = j;
                    j++;
                }

                //Console.Write(vetor[i] + " ");
            }
            return vetor;
        }

        static int[] FormaVetorDecres(int[] vetor)
        {
            int j = vetor.Length - 1;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                {
                    vetor[i] = j;
                    j--;
                }

                //Console.Write(vetor[i] + " ");
            }
            return vetor;
        }

        static int[] FormaVetorRan(int[] vetor)
        {

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                {
                    vetor[i] = RandomNum(1, 10000);

                }

                //Console.Write( vetor[i] + " ");
            }
            return vetor;
        }
        static void Main(string[] args)
        {
            Selection VetorS = new Selection();
            Insertion VetorI = new Insertion();
            Bubble VetorBu = new Bubble();
            Merge VetorMe = new Merge();
            Quick VetorQ = new Quick();

            int[] vetorA = new int[10001];
            int[] vetorB = new int[10001];
            int[] vetorC = new int[10001];

            //Formar Vetores
            FormaVetorCres(vetorA);
            //Console.WriteLine("");
            FormaVetorDecres(vetorB);
            //Console.WriteLine("");
            FormaVetorRan(vetorC);
            //Console.WriteLine("");


            //Medir tempo Selection
            //Vetor A
            Console.WriteLine("Tempo de execução Selection Sort");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vetor A");
            Stopwatch selection = new Stopwatch();
            selection.Start();

            VetorS.AlgSelection(vetorA);

            selection.Stop();
            TimeSpan tempoSa = selection.Elapsed;
            Console.WriteLine(tempoSa);
            Console.WriteLine("\n");

            //Vetor B
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vetor B");
            selection.Restart();

            VetorS.AlgSelection(vetorB);

            selection.Stop();
            TimeSpan tempoSb = selection.Elapsed;
            Console.WriteLine(tempoSb);
            Console.WriteLine("\n");

            //Vetor C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vetor C");
            selection.Restart();

            VetorS.AlgSelection(vetorC);

            selection.Stop();
            TimeSpan tempoSc = selection.Elapsed;
            Console.WriteLine(tempoSc);
            Console.WriteLine("\n");

            //Medir tempo Insertion
            //Vetor A
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tempo de execução Insertion Sort");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vetor A");
            Stopwatch insertion = new Stopwatch();
            insertion.Restart();

            VetorI.AlgInsertion(vetorA);

            insertion.Stop();
            TimeSpan tempoIa = insertion.Elapsed;
            Console.WriteLine(tempoIa);
            Console.WriteLine("\n");

            //Vetor B
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vetor B");
            insertion.Restart();

            VetorI.AlgInsertion(vetorB);

            insertion.Stop();
            TimeSpan tempoIb = insertion.Elapsed;
            Console.WriteLine(tempoIb);
            Console.WriteLine("\n");

            //Vetor C 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vetor C");
            insertion.Restart();

            VetorI.AlgInsertion(vetorC);

            insertion.Stop();
            TimeSpan tempoIc = insertion.Elapsed;
            Console.WriteLine(tempoIc);
            Console.WriteLine("\n");

            //Medir tempo Bubble
            //Vetor A
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tempo de execução Bubble Sort");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vetor A");
            Stopwatch bubble = new Stopwatch();
            bubble.Restart();

            VetorBu.AlgBubble(vetorA);

            bubble.Stop();
            TimeSpan tempoBa = bubble.Elapsed;
            Console.WriteLine(tempoBa);
            Console.WriteLine("\n");

            //Vetor B
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vetor B");
            bubble.Restart();

            VetorBu.AlgBubble(vetorB);

            bubble.Stop();
            TimeSpan tempoBb = bubble.Elapsed;
            Console.WriteLine(tempoBb);
            Console.WriteLine("\n");

            //Vetor C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vetor C");
            bubble.Restart();

            VetorBu.AlgBubble(vetorC);

            bubble.Stop();
            TimeSpan tempoBc = bubble.Elapsed;
            Console.WriteLine(tempoBc);
            Console.WriteLine("\n");


            //Medir tempo Merge
            //Vetor A
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tempo de execução Merge Sort");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vetor A");
            List<int> vetormergeA = new List<int>(vetorA);
            Stopwatch merge = new Stopwatch();
            merge.Restart();

            VetorMe.MergeSort(vetormergeA);

            merge.Stop();
            TimeSpan tempoMa = merge.Elapsed;
            Console.WriteLine(tempoMa);
            Console.WriteLine("\n");

            //Vetor B
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vetor B");
            List<int> vetormergeB = new List<int>(vetorB);
            merge.Restart();

            VetorMe.MergeSort(vetormergeB);

            merge.Stop();
            TimeSpan tempoMb = merge.Elapsed;
            Console.WriteLine(tempoMb);
            Console.WriteLine("\n");

            //Vetor C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vetor C");
            List<int> vetormergeC = new List<int>(vetorC);
            merge.Restart();

            VetorMe.MergeSort(vetormergeC);

            merge.Stop();
            TimeSpan tempoMc = merge.Elapsed;
            Console.WriteLine(tempoMc);
            Console.WriteLine("\n");

            //Medir tempo Quick
            //Vetor A
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tempo de execução Quick Sort");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vetor A");
            Stopwatch quick = new Stopwatch();
            quick.Restart();

            VetorQ.QuickSort(vetorA, 0, vetorA.Length - 1);

            quick.Stop();
            TimeSpan tempoQa = quick.Elapsed;
            Console.WriteLine(tempoQa);
            Console.WriteLine("\n");

            //Vetor B
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Vetor B");
            quick.Restart();

            VetorQ.QuickSort(vetorA, 0, vetorA.Length - 1);

            quick.Stop();
            TimeSpan tempoQb = quick.Elapsed;
            Console.WriteLine(tempoQb);
            Console.WriteLine("\n");

            //Vetor C
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Vetor C");
            quick.Restart();

            VetorQ.QuickSort(vetorA, 0, vetorA.Length - 1);

            quick.Stop();
            TimeSpan tempoQc = quick.Elapsed;
            Console.WriteLine(tempoQc);
            Console.WriteLine("\n");
                                                               
            Console.ReadKey();
        }
    }
}
