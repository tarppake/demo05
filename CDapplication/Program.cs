using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDapplication
{
    class Program
    {
        static void Main(string[] args)
        
        {




            List<Biisit> biisi = new List<Biisit>();

            biisi.Add(new Biisit {BiisiNimi = "-.The Quest", BiisiKesto = "4:57"});
            biisi.Add(new Biisit { BiisiNimi = "- Leviathan", BiisiKesto = "5:56" });
            biisi.Add(new Biisit { BiisiNimi = "- That Famous Ol' Spiced", BiisiKesto = "4:46" });
            biisi.Add(new Biisit { BiisiNimi = "- Keelhauled", BiisiKesto = "3:42" });
            biisi.Add(new Biisit { BiisiNimi = "- To The End Of Our Days", BiisiKesto = "6:23" });
            biisi.Add(new Biisit { BiisiNimi = "- Black Sails At Midnight", BiisiKesto = "3:31" });
            biisi.Add(new Biisit { BiisiNimi = "- No Quarter", BiisiKesto = "3:03" });
            biisi.Add(new Biisit { BiisiNimi = "- Pirate Song", BiisiKesto = "4:03" });
            biisi.Add(new Biisit { BiisiNimi = "- Chronicles Of Vengeance", BiisiKesto = "6:25" });
            biisi.Add(new Biisit { BiisiNimi = "- Wolves Of The Sea", BiisiKesto = "3:34" });

            Console.WriteLine(biisi.ElementAt(0).ToString());

            foreach(Biisit biisit in biisi)
            {
                Console.WriteLine(biisi.ToString());
            }


        }
    }
}
