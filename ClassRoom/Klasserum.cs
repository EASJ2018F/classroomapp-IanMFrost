using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Klasserum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }
        public Klasserum()
        {

        }



        public string Årstid(int fødselsdagsmåned)
        {
            if(3<= fødselsdagsmåned && fødselsdagsmåned <= 5)
            {

                return "Forår";

            }
            if( 6 <= fødselsdagsmåned && fødselsdagsmåned <= 8)
            {
                return "Sommer";
            }
            if (9 <= fødselsdagsmåned && fødselsdagsmåned <= 11)
            {
                return "Efterår";
            }
            return "Vinter";

        }

        
    }
}
