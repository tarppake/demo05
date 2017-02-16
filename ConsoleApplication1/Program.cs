using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list for persons
            List<Person> persons = new List<Person>();

            // add persons to list
            persons.Add(new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" });
            persons.Add(new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" });
            persons.Add(new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" });

            // show one person data
            Console.WriteLine(persons.ElementAt(0).ToString()); // Kirsi Mainio 010190-111A

            // loop through all the persons
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            // outputs:
            // Kirsi Mainio 010190 - 111A
            // Matti Husso 020292 - 222A
            // Teppo Vuolle 030393 - 333A
        }
    }
}
