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
            
            //Console.WriteLine("Please enter the name");
            //var numberOfUsers = Console.ReadLine();

            //List<string> names = new List<string>(new string[] { "ian", "lizzy", "philippa", "phil", "julie", "lee" });
            List<Person> names = new List<Person>();
            List<string> completedNames = new List<string>();

            var anotherName = true;

            Console.WriteLine("Welcome to the Secret Santa Generator.");

            while (anotherName == true)
            {
                Person p = new Person();
                p.CreatePerson(names);

                Interactions interact = new Interactions();
                anotherName = interact.ContinueOrExit();
            }

            int numberOfNames = names.Count();

            while (numberOfNames != 0)
            {
                ChooseName name = new ChooseName();

                int randomNumber = name.GetName(numberOfNames);
                string yourName = name.AskForName(completedNames);
                if (yourName == null)
                {
                    continue;
                }

                completedNames.Add(yourName);
                string message = name.CheckName(yourName, names[randomNumber]);

                while (message == "Please try again" || message == "Incorrect match. Please Try Again!")
                {
                    randomNumber = name.GetName(numberOfNames);
                    message = name.CheckName(yourName, names[randomNumber]);
                }

                Console.WriteLine(message);
                names.RemoveAt(randomNumber);

                numberOfNames = names.Count();

                Interactions interact = new Interactions();
                interact.ClearConsole();
            }
        }
    }
}
