using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDapplication
{
    class CD
    {
        public string CdNimi { get; set; }
        public string Artisti { get; set; }
        public int Hinta { get; set; }

        public override string ToString()
        {
            return "- Name: " + CdNimi + System.Environment.NewLine + "- Artist: " + Artisti;
         }






    }
}
