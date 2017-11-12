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

        public bool CheckPartners(string yourName, string partner1, string partner2, string otherName)
        {
            if (yourName.Equals(partner1, StringComparison.OrdinalIgnoreCase) && otherName.Equals(partner2, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        public string CheckName(string yourName, string otherName)

        {
            //CheckPartners(yourName, "Ian", "Lizzy", otherName);

            if (yourName == "ian" && otherName == "lizzy")
            {
                return "Incorrect match. Please Try Again!";
            }
            if (yourName == "lizzy" && otherName == "ian")
            {
                return "Incorrect match. Please Try Again!";
            }
            if (yourName == "phil" && otherName == "philippa")
            {
                return "Incorrect match. Please Try Again!";
            }
            if (yourName == "philippa" && otherName == "phil")
            {
               return "Incorrect match. Please Try Again!";
            }
            if (yourName == "lee" && otherName == "julie")
            {
                return "Incorrect match. Please Try Again!";
            }
            if (yourName == "julie" && otherName == "lee")
            {
                return "Incorrect match. Please Try Again!";
            }
            if (yourName != otherName)
            {
                return "Get a present for: " + otherName;
            }
            if (yourName == otherName)
            {
                return "Please try again";
            }

            return "no name for you";
        }

        public string AskForName(List<string> completedNames)
        {
            Console.WriteLine("Please enter your name?");
            string yourName = Console.ReadLine();

            if (completedNames.Contains(yourName))
            {
                Console.WriteLine("You've already seleted a secret santa. Go away!");
                return null;
            }

            return yourName;
        }
    }
}
