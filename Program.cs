using System;
using System.Security.Permissions;

namespace Guia_1___6
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo tecla;


            do
            {
                tecla = Console.ReadKey();
                if ((tecla.Key == ConsoleKey.F) &&
                    ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) &&
                        ((tecla.Modifiers & ConsoleModifiers.Control) != 0))
                {
                    break;
                }
                    //test
           
        
              
            } while (true);

        }
    }
}