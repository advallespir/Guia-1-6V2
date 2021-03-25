using System;
using System.Security.Permissions;

namespace Guia_1___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solo salis de aca si apretas control + shift + F");
            ConsoleKeyInfo tecla;
            Console.TreatControlCAsInput = true;

            Console.TreatControlCAsInput = true;

            Console.WriteLine("Apreta Control + Shift + F para salir, sino mientras te quedas acá.");
            do
                if ((tecla.Key == ConsoleKey.F) &&
                    ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) &&
                        ((tecla.Modifiers & ConsoleModifiers.Control) != 0))
                {
                    break;
                    //test
            {
                tecla = Console.ReadKey();
                
            } while (true);
                }
                Console.WriteLine("{0} (character '{1}')", cki.Key, cki.KeyChar);

           } while (igualdad == false);
        }
    }
}