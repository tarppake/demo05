using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi", Lastname = "Mainio", SocialsecurityNumber = "1231231-1234"
            };

            Person person2 = new Person
            {
                Firstname = "Matti",
                Lastname = "Mallikas",
                SocialsecurityNumber = "46454646-5466"
            };
            Person person3 = new Person
            {
                Firstname = "Esko",
                Lastname = "Orava",
                SocialsecurityNumber = "123456899-7894"
            };

            //create a persons object
            Persons myFriends = new Persons();

            //add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);


            //get one person from persons collection

            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in that indev!");
            }

            //print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "46454646-5466";
            Console.WriteLine("find sotu : " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            
            } else
            {
                Console.WriteLine("cant find person with that sotu");
            }

        }
    }
}
