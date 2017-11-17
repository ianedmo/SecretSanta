using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class Interactions
    {
        public void ClearConsole()
        {
            Console.WriteLine("Once you've memorised your selection, please press 'Enter'");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (keyInfo.Key != ConsoleKey.Enter)
            {
                keyInfo = Console.ReadKey();
            }

            Console.Clear();
        }

        public bool ContinueOrExit()
        {
            Console.WriteLine("Press 'Enter' to add anther name or any key to continue.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return true;
            }

            if (keyInfo.Key != ConsoleKey.Enter)
            {
                return false;
            }

            return false;
        }
    }
}
