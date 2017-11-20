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

        public string CheckName(string buyerName, string buyerPartner, string receiverName)
        {
            if (buyerPartner == receiverName)
            {
                return "Incorrect match. Please Try Again!";
            }
            if (buyerName != receiverName)
            {
                return buyerName + " - Get a present for: " + receiverName;
            }
            if (buyerName == receiverName)
            {
                return "Please try again";
            }

            return "no name for you";
        }

        public void MakeSelections(List<Person>names, List<string> completedNames, int totalNames)
        {
            for (int i = 0; i < names.Count; i++)
            {
                bool validSelection = false;
                int randomNumber = GetName(totalNames); ;
                string message = "";

                while (validSelection == false)
                {
                    randomNumber = GetName(totalNames);
                    if (names[randomNumber].HasBeenSelected == false)
                    {
                        validSelection = true;
                        message = CheckName(names[i].Name, names[i].Partner, names[randomNumber].Name);
                    }                    
                }
                
                while (message == "Please try again" || message == "Incorrect match. Please Try Again!")
                {
                    randomNumber = GetName(totalNames);
                    if (names[randomNumber].HasBeenSelected == false)
                    {
                        validSelection = true;
                        message = CheckName(names[i].Name, names[i].Partner, names[randomNumber].Name);
                    }
                }
                
                names[i].SecretSanta = names[randomNumber].Name;
                names[i].HasSelected = true;
                names[randomNumber].HasBeenSelected = true;

                Console.WriteLine(message);
                totalNames = names.Count();
            }
        }
    }
}
