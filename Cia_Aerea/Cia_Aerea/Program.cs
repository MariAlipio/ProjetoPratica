using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cia_Aerea
{
    class Program
    {

        public static CadastroPassageiro pesquisaporCPF { get; private set; }

        static void Main(string[] args)
        {
            DateTime BHRecife = new DateTime(2017, 6, 10, 5, 0, 0);
            DateTime BHRio = new DateTime(2017, 6, 11, 11, 0, 0);
            DateTime BHSP = new DateTime(2017, 6, 12, 13, 0, 0);

            var MenuAtual = NivelMenu.Primeiro;
            var Voo = CadastraVoo.Recife;

            //Queue FilaVooRecife = new Queue();
            //Queue FilaVooRio = new Queue();
            //Queue FilaVooSp = new Queue();

            List<CadastroPassageiro> ListaVooRecife = new List<CadastroPassageiro>();
            List<CadastroPassageiro> ListaVooRio = new List<CadastroPassageiro>();
            List<CadastroPassageiro> ListaVooSp = new List<CadastroPassageiro>();

            List<Voo> listaVoos = new List<Voo>();

            Queue FilaEsperaRecife = new Queue();
            Queue FilaEsperaRio = new Queue();
            Queue FilaEsperaSp = new Queue();

            List<CadastroPassageiro> ListaEsperaRecife = new List<CadastroPassageiro>();
            List<CadastroPassageiro> ListaEsperaRio = new List<CadastroPassageiro>();
            List<CadastroPassageiro> ListaEsperaSp = new List<CadastroPassageiro>();

            Voo BhRecife = new Voo
            {
                NVoo = 001,
                Descricao = "BH/RECIFE",
                HoraVoo = BHRecife
            };

            Voo BhRio = new Voo
            {
                NVoo = 002,
                Descricao = "BH/Rio",
                HoraVoo = BHRio
            };

            Voo BhSp = new Voo
            {
                NVoo = 003,
                Descricao = "BH/SP",
                HoraVoo = BHSP
            };

            listaVoos.Add(BhRecife);
            listaVoos.Add(BhRio);
            listaVoos.Add(BhSp);

            CadastroPassageiro Passageiro1Recife = new CadastroPassageiro()
            {
                CPF = 12065874528,
                Nome = "Maria",
                Sobrenome = "Almeida",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1258,
                NVoo = BhRecife,
                NPoltrona = 29,
                Telefone = 31991651545

            };
            ListaVooRecife.Add(Passageiro1Recife);

            CadastroPassageiro Passageiro2Recife = new CadastroPassageiro()
            {
                CPF = 12058796352,
                Nome = "Mariana",
                Sobrenome = "Alipio",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1298,
                NVoo = BhRecife,
                NPoltrona = 12,
                Telefone = 31991651545

            };
            ListaVooRecife.Add(Passageiro2Recife);

            CadastroPassageiro Passageiro3Recife = new CadastroPassageiro()
            {
                CPF = 85236985214,
                Nome = "Filipe",
                Sobrenome = "Silva",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1260,
                NVoo = BhRecife,
                NPoltrona = 15,
                Telefone = 31991651545

            };
            ListaVooRecife.Add(Passageiro3Recife);

            CadastroPassageiro Passageiro4Recife = new CadastroPassageiro()
            {
                CPF = 85696325874,
                Nome = "Guilherme",
                Sobrenome = "Fonseca",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1212,
                NVoo = BhRecife,
                NPoltrona = 16,
                Telefone = 31991651545

            };
            ListaVooRecife.Add(Passageiro4Recife);

            CadastroPassageiro Passageiro1Rio = new CadastroPassageiro()
            {
                CPF = 42587569858,
                Nome = "Jose",
                Sobrenome = "Almeida",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1259,
                NVoo = BhRio,
                NPoltrona = 30,
                Telefone = 31991651545

            };
            ListaVooRio.Add(Passageiro1Rio);

            CadastroPassageiro Passageiro1Sp = new CadastroPassageiro()
            {
                CPF = 25896345682,
                Nome = "Cristina",
                Sobrenome = "Almeida",
                Endereco = "Av. Marte 554, J. Riacho, Contagem - MG",
                NPassagem = 1260,
                NVoo = BhRecife,
                NPoltrona = 32,
                Telefone = 31985426587

            };
            ListaVooSp.Add(Passageiro1Sp);

            bool sair = false;
            PrimeiroMenu();
            do
            {
                ConsoleKeyInfo Menu = Console.ReadKey();

                switch (Menu.Key)
                {
                    case ConsoleKey.F1:
                        SegundoMenu(BhRecife);
                        MenuAtual = NivelMenu.Segundo;
                        Voo = CadastraVoo.Recife;
                        break;

                    case ConsoleKey.F2:
                        SegundoMenu(BhRio);
                        MenuAtual = NivelMenu.Segundo;
                        Voo = CadastraVoo.Rio;
                        break;


                    case ConsoleKey.F3:
                        SegundoMenu(BhSp);
                        MenuAtual = NivelMenu.Segundo;
                        Voo = CadastraVoo.SaoPaulo;
                        break;

                    case ConsoleKey.Escape:
                        switch (MenuAtual)
                        {
                            case NivelMenu.Primeiro:
                                Console.Clear();
                                Console.WriteLine("Sair");
                                sair = Menu.Key == ConsoleKey.Escape;
                                break;
                            case NivelMenu.Segundo:
                                PrimeiroMenu();
                                MenuAtual = NivelMenu.Primeiro;
                                break;
                            case NivelMenu.Terceiro:
                                SegundoMenu(BhRecife);
                                MenuAtual = NivelMenu.Segundo;
                                break;
                            default:
                                break;
                        }
                        break;

                    case ConsoleKey.F4:
                        switch (Voo)
                        {
                            case CadastraVoo.Recife:
                                ListarPassageiros(ListaVooRecife);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.Rio:
                                ListarPassageiros(ListaVooRio);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.SaoPaulo:
                                ListarPassageiros(ListaVooSp);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                        }
                        break;

                    case ConsoleKey.F5:
                        switch (Voo)
                        {
                            case CadastraVoo.Recife:
                                PesquisarporCPF(ListaVooRecife);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.Rio:
                                PesquisarporCPF(ListaVooRio);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.SaoPaulo:
                                PesquisarporCPF(ListaVooSp);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                        }
                        break;

                    case ConsoleKey.F6:
                        switch (Voo)
                        {
                            case CadastraVoo.Recife:
                                CadastraPassageiro(ListaVooRecife, FilaEsperaRecife, ListaEsperaRecife);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.Rio:
                                CadastraPassageiro(ListaVooRio, FilaEsperaRio, ListaEsperaRio);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.SaoPaulo:
                                CadastraPassageiro(ListaVooSp, FilaEsperaSp, ListaEsperaSp);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                        }
                        break;

                    case ConsoleKey.F7:
                        switch (Voo)
                        {
                            case CadastraVoo.Recife:
                                ExcluirPassageiro(FilaEsperaRecife, ListaVooRecife);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.Rio:
                                ExcluirPassageiro(FilaEsperaRio, ListaVooRio);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.SaoPaulo:
                                ExcluirPassageiro(FilaEsperaSp, ListaVooSp);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                        }
                        break;

                    case ConsoleKey.F8:
                        switch (Voo)
                        {
                            case CadastraVoo.Recife:
                                ListarPassageiros(ListaEsperaRecife);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.Rio:
                                ListarPassageiros(ListaEsperaRio);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                            case CadastraVoo.SaoPaulo:
                                ListarPassageiros(ListaEsperaSp);
                                MenuAtual = NivelMenu.Terceiro;
                                break;

                        }
                        break;
                }
            } while (!sair);
        }


        private static void ExcluirPassageiro(Queue FilaEspera, List<CadastroPassageiro> ListaVoo)
        {
            Console.Clear();
            Console.Write("Insira o CPF por favor: ");
            int pesquisaporCPF = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < ListaVoo.Count; i++)
            {

                if (pesquisaporCPF == ListaVoo[i].CPF)
                {
                    ListaVoo.RemoveAt(i);
                    CadastroPassageiro excluido = (CadastroPassageiro) FilaEspera.Dequeue();
                    ListaVoo.Add(excluido);

                    Console.WriteLine("Usuário removido com sucesso");
                }

            }

        }


        private static void PesquisarporCPF(List<CadastroPassageiro> ListaVoo)
        {
            Console.Clear();
            Console.Write("Insira o CPF por favor: ");
            long pesquisaporCPF = long.Parse(Console.ReadLine());

            for (int i = 0; i < ListaVoo.Count; i++)
            {

                if (pesquisaporCPF == ListaVoo[i].CPF)
                {
                    Console.WriteLine("Nome: {0} \n" +
                                      "Numero da Passagem: {1} \n" +
                                      "Numero da Poltrona: {2} \n",
                        ListaVoo[i].Nome, ListaVoo[i].NPassagem, ListaVoo[i].NPoltrona);

                    Console.WriteLine();
                }

            }
        }


        private static void CadastraPassageiro(List<CadastroPassageiro> ListaVoo, Queue FilaEspera, List<CadastroPassageiro> ListaEspera)
        {
            bool retornar = true;
            do
            {
                Console.Clear();
                Console.Write("Insira o nome: ");

                CadastroPassageiro PassageiroC = new CadastroPassageiro();
                Voo Recife = new Voo();

                PassageiroC.Nome = Console.ReadLine();
                Console.Write("Insira seu CPF(APENAS NUMEROS)");
                PassageiroC.CPF = long.Parse(Console.ReadLine());

                Console.Write("Insira seu Numero do Voo(3 DÍGITOS)");
                Recife.NVoo = int.Parse(Console.ReadLine());

                Console.Write("Insira seu Numero de passagem(APENAS NUMEROS)");
                PassageiroC.NPassagem = int.Parse(Console.ReadLine());

                Console.Write("Insira seu Telefone(APENAS NUMEROS)");
                PassageiroC.Telefone = long.Parse(Console.ReadLine());


                if (ListaVoo.Count <= 5)
                {
                    ListaVoo.Add(PassageiroC);
                }
                else if (FilaEspera.Count > 10)
                {
                    Console.WriteLine("Reserva não pode ser feita, fila de espera cheia!");
                }
                else
                {
                    ListaEspera.Add(PassageiroC);
                    FilaEspera.Enqueue(PassageiroC);
                }

                Console.WriteLine("Deseja cadastrar mais um? Caso deseje retornar aperte barra ");
                var finalizar = Console.ReadKey();
                retornar = finalizar.Key == ConsoleKey.Spacebar;
                Console.WriteLine();

            } while (retornar);
        }


        private static int ListarPassageiros(List<CadastroPassageiro> Lista)
        {
            Console.Clear();
            int PosicaoLista = 1;
            if (Lista.Count > 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    Console.WriteLine("\n" + PosicaoLista + "°: " + "CPF: {0} \n" +
                                                                   "Nome: {1} \n" +
                                                                   "Numero da Passagem: {2} \n" +
                                                                   "Numero da Poltrona: {3} \n",
                    Lista[i].CPF, Lista[i].Nome, Lista[i].NPassagem, Lista[i].NPoltrona);
                    PosicaoLista++;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não possui Passageiros cadastrados!");
            }

            return PosicaoLista;
        }

        private static void SegundoMenu(Voo voo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\t\t\t\t    Bem vindo!!\t\t\t {0} Vôo nº: {1}\n", voo.Descricao, voo.NVoo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t  [F4] Lista de Passageiros");
            Console.WriteLine("\t\t\t  [F5] Pesquisar");
            Console.WriteLine("\t\t\t  [F6] Cadastrar Passageiro");
            Console.WriteLine("\t\t\t  [F7] Excluir Passageiro");
            Console.WriteLine("\t\t\t  [F8] Fila de espera");
            Console.WriteLine("\t\t\t [ESC] Sair");
        }

        private static void PrimeiroMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\t\t    Bem vindo!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t Selecione seu vôo");
            Console.WriteLine("\t\t\t  [F1] BH/RECIFE");
            Console.WriteLine("\t\t\t  [F2] BH/RIO");
            Console.WriteLine("\t\t\t  [F3] BH/SP");
            Console.WriteLine("\t\t\t [ESC] SAIR");
        }
    }
}
