using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //alustaa levyn nimi ja artisti
            CD cd = new CD
            {
                LevyNimi = "Black Sails At Midnight",
                LevyArtisti = "Alestorm",
                LevyHinta = "9.99e"
            };
            
            

            Console.WriteLine(cd.ToString());     
           
            List<Biisi> biisi = new List<Biisi>();

            biisi.Add(new Biisi { BiisiNimi = "The Quest", BiisiKesto = "4:57" });
            biisi.Add(new Biisi { BiisiNimi = "Leviathan", BiisiKesto = "5:56" });
            biisi.Add(new Biisi { BiisiNimi = "That Famous Ol' Spiced", BiisiKesto = "4:46" });
            biisi.Add(new Biisi { BiisiNimi = "Keelhauled", BiisiKesto = "3:42" });
            biisi.Add(new Biisi { BiisiNimi = "To The End Of Our Days", BiisiKesto = "6:23" });
            biisi.Add(new Biisi { BiisiNimi = "Black Sails At Midnight", BiisiKesto = "3:31" });
            biisi.Add(new Biisi { BiisiNimi = "No Quarter", BiisiKesto = "3:03" });
            biisi.Add(new Biisi { BiisiNimi = "Pirate Song", BiisiKesto = "4:03" });
            biisi.Add(new Biisi { BiisiNimi = "Chronicles Of Vengeance", BiisiKesto = "6:25" });
            biisi.Add(new Biisi { BiisiNimi = "Wolves Of The Sea", BiisiKesto = "3:34" });

            Console.WriteLine("- Songs:");
         //Loopilla kaikki kappaleet listasta läpi
            foreach (Biisi Biisi in biisi)
            {
                Console.WriteLine(Biisi.ToString());
            }







        }
    }
}
