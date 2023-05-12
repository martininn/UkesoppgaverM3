using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace UkesOppgaveUke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heibert = new Student("Heibert", 42, "Radiobilkjøring");
            var thomas = new Student("Thomas", 28, "Radiobilkjøring");
            var kåre = new Student("Kåre", 38, "Frimerkesamling");
            var kurt = new Student("Kurt", 60, "Radiobilkjøring");
            var roger = new Student("Roger", 55, "Frimerkesamling");
            var peder = new Student("Peder", 33, "Soppsmaking");
            var nils = new Student("Nils", 24, "Trampolinehopping");

            List<Student> list = new List<Student>() { heibert, thomas, kåre, kurt, roger, peder, nils };

            Tutorial();

            while (true)  //bare for brukervennlighet akkurat nå
            {
                WriteOutStudent(list);
                UserContinue();
            }

            
            //Tutorial();

            //var studentObjs = list.Where(x => x.Course == "Radiobilkjøring").ToList();
            //Console.WriteLine(studentObjs.Name + ", " + studentObjs.Age);

            //Console.WriteLine(student.Name + student.Age + student.Course);
        }

        private static void WriteOutStudent(List<Student> list)
        {
            string userResponse = Console.ReadLine();

            foreach (var student in list)
            {
                if (userResponse == student.Course)
                {
                    Console.WriteLine("Navn: " + student.Name + " - " + "Alder: " + student.Age);
                }
                //else if (userResponse != student.Course)
                //{
                //    Tutorial();
                //}
            }
        }


        private static void Tutorial()
        {
            Console.WriteLine("Studentvalg");
            Console.WriteLine("Skriv inn et kurs for å få ut deltaker.");
            Console.WriteLine(" - Radiobilkjøring" +
                              " - Frimerkesamling" +
                              " - Soppsmaking" +
                              " - Trampolinehopping");
        }
        private static void UserContinue()
        {
            Console.WriteLine("");
            Console.WriteLine("Skriv inn et kurs for å få ut deltaker.");
            Console.WriteLine(" - Radiobilkjøring" +
                              " - Frimerkesamling" +
                              " - Soppsmaking" +
                              " - Trampolinehopping");
        }
    }
}