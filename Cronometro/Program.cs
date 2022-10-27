using System;
using System.Diagnostics;
using System.Threading;

namespace Cronometro
{
    class App
    {
        static void Main()
        {
            Menu();
        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime + " S");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo finalizado");
            Thread.Sleep(2500);
            Console.Clear();

        }

        static void Menu()
        {
            int cod;
            int time;

            do
            {
                Console.WriteLine("|------------------------|------------------------------|");
                Console.WriteLine("|        Funções         |           Código             |");
                Console.WriteLine("|------------------------|------------------------------|");
                Console.WriteLine("|        Segundo         |              1               |");
                Console.WriteLine("|         Minuto         |              2               |");
                Console.WriteLine("|          Sair          |              3               |");
                Console.WriteLine("|------------------------|------------------------------|");

                Console.WriteLine("Digite o Código:");
                cod = Convert.ToInt32(Console.ReadLine());

                switch (cod)
                {
                    case 1:
                        Console.WriteLine("Digite o Tempo em Segundos:");
                        time = Convert.ToInt32(Console.ReadLine());
                        Start(time);
                        break;

                    case 2:
                        Console.WriteLine("Digite o Tempo em Minutos:");
                        time = Convert.ToInt32(Console.ReadLine());
                        Start(time * 60);
                        break;

                    case 3:
                        Console.WriteLine("Você está saindo!");
                        break;

                    default:
                        Console.WriteLine("Código Inválido");
                        break;

                }
            } while (cod != 3);
        }
    }
}