using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class ChooseName
    {

        public int GetName(int totalNames)
        {
            Random random = new Random();
            int randomNumber = random.Next(totalNames);
            return randomNumber;
        }

        public string CheckName(string yourName, string otherName)
        {

            if (yourName == otherName)
            {
                return "Incorrect match. Please Try Again!";
            } 
            if (yourName != otherName)
            {
                return yourName + " - Get a present for: " + otherName;
            }
            if (yourName == otherName)
            {
                return "Please try again";
            }

            return "no name for you";
        }
        // Add new logic to do all name selections without asking for name
        public string AskForName(List<Person>names, List<string> completedNames)
        {
            Console.WriteLine("Please enter your name?");
            string yourName = Console.ReadLine().ToLower();

            if (completedNames.Contains(yourName))
            {
                Console.WriteLine("You've already seleted a secret santa. Go away!");
                return null;
            }

            return yourName;
        }

        public void MakeSelections(List<Person>names, List<string> completedNames, int totalNames)
        {
            foreach (var name in names)
            {
                int randomNumber = GetName(totalNames);

                if (completedNames.Contains(name.Name))
                {
                    continue;
                }

                var message = CheckName(name.Name, names[randomNumber].Name);

                while (message == "Please try again" || message == "Incorrect match. Please Try Again!")
                {
                    randomNumber = GetName(totalNames);
                    message = CheckName(name.Name, names[randomNumber].Name);
                }

                completedNames.Add(name.Name);

                Console.WriteLine(message);
                names.RemoveAt(randomNumber);
            }
        }
    }
}
