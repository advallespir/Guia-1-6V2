using System;
using System.Security.Permissions;

namespace Guia_1___6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            bool igualdad = false;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Apreta Control + Shift + F para salir, sino mientras te quedas acá.");
            do
            {
                cki = Console.ReadKey();
                Console.WriteLine();

                if (((cki.Modifiers & ConsoleModifiers.Control) & (cki.Modifiers & ConsoleModifiers.Alt)) != 0)
                {
                    Console.Write("CTR+SHIFT+");
                    string cosa = cki.KeyChar.ToString();
                    igualdad = string.Equals(cosa, "F");
                }
                Console.WriteLine("{0} (character '{1}')", cki.Key, cki.KeyChar);

           } while (igualdad == false);
        }
    }
}
