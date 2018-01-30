using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasserum klasse1 = new Klasserum();
            klasse1.KlasseNavn = "3A";
            klasse1.SemesterStart = DateTime.Parse("28-12-2017");

            Studerende ian = new Studerende(23, "Ian", 06);
            Studerende bent = new Studerende(12, "Jørgen", 01);

            List<Studerende> students = new List<Studerende>();

            students.Add(ian);
            students.Add(bent);

            foreach (var studerende in students)
            {
                Console.WriteLine(studerende);
                
                Console.WriteLine(" Er født under " + klasse1.Årstid(studerende.fødselsdagsmåned));
            }

            var SummerStudent =
                (from student in students
                 where klasse1.Årstid(student.fødselsdagsmåned) == "Sommer"
                 select student.navn).Count();

            var ForårStudent =
               (from student in students
                where klasse1.Årstid(student.fødselsdagsmåned) == "Forår"
                select student.navn).Count();

            var EfterårStudent =
               (from student in students
                where klasse1.Årstid(student.fødselsdagsmåned) == "Efterår"
                select student.navn).Count();

            var VinterStudent =
               (from student in students
                where klasse1.Årstid(student.fødselsdagsmåned) == "Vinter"
                select student.navn).Count();


            Console.WriteLine(SummerStudent);
            Console.WriteLine(EfterårStudent);
            Console.WriteLine(ForårStudent);
            Console.WriteLine(VinterStudent);
                               
           
            Console.ReadKey();

            

            
           
            

        }
    }
}
