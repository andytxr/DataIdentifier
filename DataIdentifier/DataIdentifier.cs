using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIdentifier
{
    class DataIdentifier
    {
     
        public static int ano;
        public static int verifAno;
        public static int mes;
        public static int dia;
        public static string[] mesExt = new[]
        {
            "Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro",
            "Novembro", "Dezembro"
        };

        public static void EntradaAno()
        {
            Console.WriteLine("Identificador de Data");

            Console.WriteLine("------------------------------");
            Console.Write("Digite o Ano: ");
            ano = int.Parse(Console.ReadLine());
            VerifAno();
        }

        public static void EntradaMes()
        {
            Console.WriteLine("------------------------------");
            Console.Write("Digite o mes: ");
            mes = int.Parse(Console.ReadLine());
            if (mes < 0 || mes > 12)
            {
                do
                {
                    Console.WriteLine("------------------------------");
                    Console.Write("Digite o mes novamente: ");
                    mes = int.Parse(Console.ReadLine());
                } while (mes < 0 || mes > 12);
            }

        }


        public static void VerifDia()
        {
            if (verifAno == 0 && mes == 2)
            {
                if (dia > 29)
                {
                    do
                    {
                        Console.WriteLine("------------------------------");
                        Console.Write("Digite o dia novamente: ");
                        dia = int.Parse(Console.ReadLine());
                    } while (dia > 29);

                }
            }
            else if (verifAno != 0 && mes == 2)
            {
                if (dia > 28)
                {
                    do
                    {
                        Console.WriteLine("------------------------------");
                        Console.Write("Digite o dia novamente: ");
                        dia = int.Parse(Console.ReadLine());
                    } while (dia > 28);
                }
            }
            else if (mes == 4 || mes == 6 || mes == 7 || mes == 11 && dia > 30)
            {
                do
                {
                    Console.WriteLine("------------------------------");
                    Console.Write("Digite o dia novamente: ");
                    dia = int.Parse(Console.ReadLine());
                } while (mes == 4 || mes == 6 || mes == 7 || mes == 11 && dia > 30);

            }

        }

        public static void VerifAno()
        {
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0)
                {
                    verifAno = ano % 400;
                }
            }
        }

        public static void EntradaDia()
        {
            Console.WriteLine("------------------------------");
            Console.Write("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            if (dia < 0 || dia > 31)
            {
                do
                {
                    Console.WriteLine("------------------------------");
                    Console.Write("Digite o dia novamente: ");
                    dia = int.Parse(Console.ReadLine());
                } while (dia < 0 || dia > 31);
            }

            VerifDia();
        }

        public static void Saida()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Formato de Data 1: {0}/{1}/{2}", dia, mes, ano);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Formato de Data 2: {0} de {1} de {2}", dia, mesExt[mes - 1], ano);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Formato de Data 3: {0}--{1}--{2}", ano, dia, mes);
        }

        public static void Main(string[] args)
        {
            EntradaAno();
            EntradaMes();
            EntradaDia();

            Saida();

            Console.ReadKey();
        }
    }
}
