using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        public string navn { get; set; }
        public int fødselsdagsmåned { get; set; }
        public int fødselsdag { get; set; }
        

        public Studerende(int fødselsdag, string navn , int fødselsdagsmåned)
        {
            this.fødselsdag = fødselsdag;
            this.navn = navn;
            this.fødselsdagsmåned = fødselsdagsmåned;
        }

        public override string ToString()
        {
            return $"\n Navn {navn} \n Fødselsmåned {fødselsdagsmåned} \n Fødselsdag {fødselsdag}";
        }

        
    }
}
