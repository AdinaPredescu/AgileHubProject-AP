using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            //encapsulation: mod controlat de setare a proprietatilor unui obiect
            //inheritance: 
            //polymorphism: modul in care un obiect ia diferite forme; poate fi alterat, astfel incat sa ia doar anumite proprietati

            //ClassCurs cursulTestAutomation = new ClassCurs(1, "Testare Automatizata", 12);

            //ClassCurs cursulJavaDev = new ClassCurs(2, "Java Development", 14);

            ClassCurs myCurs = new ClassCurs();
            Tutorial myTutorial = new Tutorial();

            Console.ReadKey();
        }
    }
}
