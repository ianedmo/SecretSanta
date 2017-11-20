using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> names = new List<Person>();
            List<string> completedNames = new List<string>();

            var anotherName = true;

            Console.WriteLine("Welcome to the Secret Santa Generator.");

            while (anotherName == true)
            {
                dynamic p = new Person();
                p.CreatePerson(names);

                Interactions consoleInteract = new Interactions();
                anotherName = consoleInteract.ContinueOrExit();
            }

            int numberOfNames = names.Count();
            
            ChooseName name = new ChooseName();

            name.MakeSelections(names, completedNames, numberOfNames);

            Interactions interact = new Interactions();
            interact.ClearConsole();
        }
    }
}
