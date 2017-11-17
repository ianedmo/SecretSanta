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

        public string CheckName(string yourName, Person otherName)
        {

            if (yourName == otherName.Partner)
            {
                return "Incorrect match. Please Try Again!";
            } 



            //if (yourName == "ian" && otherName == "lizzy" || yourName == "lizzy" && otherName == "ian")
            //{
            //    return "Incorrect match. Please Try Again!";
            //}
            //if (yourName == "phil" && otherName == "philippa" || yourName == "philippa" && otherName == "phil")
            //{
            //    return "Incorrect match. Please Try Again!";
            //}
            //if (yourName == "lee" && otherName == "julie" || yourName == "julie" && otherName == "lee")
            //{
            //    return "Incorrect match. Please Try Again!";
            //}

            if (yourName != otherName.Name)
            {
                return "Get a present for: " + otherName.Name;
            }
            if (yourName == otherName.Name)
            {
                return "Please try again";
            }

            return "no name for you";
        }
        // Add new logic to do all name selections without asking for name
        public string AskForName(List<string> completedNames)
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
    }
}
