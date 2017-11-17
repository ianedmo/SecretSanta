using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class Person
    {
        public string Name { get; set; }
        public string Partner { get; set; }

        public Person() { }
        public Person(string name, string partner)
        {
            this.Name = name;
            this.Partner = partner;
        }
        //Other properties, methods, events...

        public void CreatePerson(List<Person> names)
        {
            Console.WriteLine("Enter the names");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the name of anyone they should not draw");
            Partner = Console.ReadLine();

            names.Add(new Person(Name, Partner));

        }
    }
}
