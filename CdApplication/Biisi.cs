using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Biisi
    {

        public string BiisiNimi { get; set; }
        public string BiisiKesto { get; set; }


        //method

        public override string ToString()
        {
            return "      - " + BiisiNimi + ", " + BiisiKesto;
        }
    }
}
