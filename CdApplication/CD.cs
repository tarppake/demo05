using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class CD
    {

    public string LevyNimi { get; set; }
    public string LevyArtisti { get; set; }

      
        //method
        public override string ToString()
        {
            return "CD Data:" + System.Environment.NewLine + "- Name: " + LevyNimi + System.Environment.NewLine + "- Artist: " + LevyArtisti;
        }









    }
}
