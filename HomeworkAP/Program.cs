using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("1. Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!");
            Console.WriteLine("Introduceti un numar:");
            Exercise1();

            Console.WriteLine("===================================:\n");

            //Exercise 2
            Console.WriteLine("2. Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise2();

            Console.WriteLine("===================================:\n");

            //Exercise 3

            //Exercise 4
            Console.WriteLine("4.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.");
            Console.WriteLine("Introduceti un numar:");
            Exercise4();

            Console.WriteLine("===================================:\n");

            //Exercise 5
            Console.WriteLine("5. Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”.");
            Console.WriteLine("Introduceti un numar:");
            Exercise5();

            Console.WriteLine("===================================:\n");

            //Exercise 6
            Console.WriteLine("6. Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.");
            Console.WriteLine("Introduceti un numar:");
            Exercise6();

            Console.WriteLine("===================================:\n");

            //Exercise 7
            Console.WriteLine("7. Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic");
            Console.WriteLine("Introduceti un numar:");
            Exercise7();

            Console.WriteLine("===================================:\n");

            //Exercise 8
            Console.WriteLine("8. Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.");
            Console.WriteLine("Introduceti un numar:");
            Exercise8();

            Console.WriteLine("===================================:\n");

            //Exercise 9
            Console.WriteLine("9. Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise9();

            Console.WriteLine("===================================:\n");

            ////Exercise 10
            //Console.WriteLine("10. Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.");
            //Console.WriteLine("Introduceti un cuvant:");
            //Exercise10();

            Console.WriteLine("===================================:\n");

            //Exercise 11
            Console.WriteLine("11. Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise11();

            Console.WriteLine("===================================:\n");

            //Exercise 12
            Console.WriteLine("12. Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”. In caz contrar afisati “Numarul *numar* este negativ!.");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise12();

            Console.WriteLine("===================================:\n");

            //Exercise 13
            Console.WriteLine("13. Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise13();

            Console.WriteLine("===================================:\n");

            //Exercise 14
            Console.WriteLine("14. Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”.");
            Console.WriteLine("Introduceti un cuvant:");
            Exercise14();

            Console.WriteLine("===================================:\n");

            ////Exercise 15
            //Console.WriteLine("15. Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera");
            //Console.WriteLine("Introduceti un cuvant:");
            //Exercise15();

            Console.WriteLine("===================================:\n");

            //Exercise 16
            Console.WriteLine("16. Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”");
            Console.WriteLine("Introduceti o ora din zi (format 1-24):");
            Exercise16();

            Console.WriteLine("===================================:\n");

            //Exercise 17
            Console.WriteLine("17. Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.");
            Console.WriteLine("Introduceti inaltimea dvs (in cm):");
            Exercise17();

            Console.WriteLine("===================================:\n");

            //Exercise 18
            Console.WriteLine("18. Cititi 3 numere de la tastatura si afisati cel mai mare numar.");
            Console.WriteLine("Introduceti 3 numere");
            Exercise18();

            Console.WriteLine("===================================:\n");

            //Exercise 19
            Console.WriteLine("19. Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: ");
            Exercise19();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("15.Scrieti un program care sa afiseze primele 10 numere naturale. (for)");
            Exercise20();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("16. Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)");
            Exercise21();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("17. Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. (for)");
            Exercise22();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("18. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (for)");
            Exercise23();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("19. Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. (for)");
            Exercise24();

            //Console.WriteLine("===================================:\n");

            //Console.WriteLine("20. Afisati cubul primelor 5 numere naturale. (for)");
            //Exercise25();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("21. Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)");
            Exercise26();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("8.	Scrieti un program care sa afiseze primele 10 numere naturale.( do while)");
            Exercise27();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("9.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)");
            Exercise28();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("10. Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. .( do while)");
            Exercise29();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("11. Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. .( do while)");
            Exercise30();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("12. Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)");
            Exercise31();

            //Console.WriteLine("===================================:\n");

            //Console.WriteLine("13. Afisati cubul primelor 5 numere naturale. .( do while)");
            //Exercise32();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("14. Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. .( do while)");
            Exercise33();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("22. Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.");
            Exercise41();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("23. Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”");
            Exercise42();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("24. Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.");
            Exercise43();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("25. Afisati array-ul sortat: “mom”, “dad”, “child”.");
            Exercise44();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("26. Cititi de la tastatura elementele unui array de marime 5. (string)");
            Exercise45();

            Console.WriteLine("===================================:\n");

            Console.WriteLine("27. Cititi de la tastatura elementele unui array de marime 5.(int)");
            Exercise46();

            Console.ReadKey();
        }

        public static void Exercise1()
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20");
            }
        }

        public static void Exercise2()
        {
            string a = Console.ReadLine();

            if (a == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”.");
            }
        }

        //public static void Exercise3()
        //{
        //    var a = int.Parse(Console.ReadLine());

        //    if (a)
        //    {
        //        Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”.");
        //    }
        //}
        public static void Exercise4()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 20)
            {
                Console.WriteLine(a + 5);
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        public static void Exercise5()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"Numarul {a} este pozitiv");
            }
        }

        public static void Exercise6()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 20 || a > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
        }

        public static void Exercise7()
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Numarul {a} pe care l-ati introdus este par!");
            }
        }

        public static void Exercise8()
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20!");
            }
        }

        public static void Exercise9()
        {
            string a = Console.ReadLine();

            if (a == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”.");
            }
            else
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit NU este “automation”.");
            }
        }

        //public static void Exercise10()
        //{
        //    string a = Console.ReadLine();

        //    if (a == "automation")
        //    {
        //        Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Cuvantul pe care tu l-ai citit NU este “automation”.");
        //    }
        //}

        public static void Exercise11()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 20)
            {
                Console.WriteLine(a + 5);
            }
            else
            {
                Console.WriteLine(a - 5);
            }
        }

        public static void Exercise12()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"Numarul {a} este pozitiv");
            }
            else
            {
                Console.WriteLine($"Numarul {a} este negativ");
            }
        }

        public static void Exercise13()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 20 || a > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine("Numarul este intre 20 si 40!");
            }
        }

        public static void Exercise14()
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Numarul {a} pe care l-ati introdus este par!");
            }
            else
            {
                Console.WriteLine($"Numarul {a} pe care l-ati introdus este impar!");
            }
        }

        //public static void Exercise15()
        //{
        //    int a = int.Parse(Console.ReadLine());

        //    if (a % 2 == 0)
        //    {
        //        Console.WriteLine($"Numarul {a} pe care l-ati introdus este par!");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Numarul {a} pe care l-ati introdus este impar!");
        //    }
        //}

        public static void Exercise16()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 12)
            {
                Console.WriteLine("Buna dimineata");
            }
            else if (a < 17)
            {
                Console.WriteLine("Buna ziua!");
            }
            else
            {
                Console.WriteLine("Buna seara!");
            }
        }

        public static void Exercise17()
        {
            int a = int.Parse(Console.ReadLine());

            if (a < 150)
            {
                Console.WriteLine("Aceasta persoana este miniona");
            }
            else if (a >= 150 && a < 165)
            {
                Console.WriteLine("Aceasta persoana este mica de statura.");
            }
            else if (a >= 165 && a < 195)
            {
                Console.WriteLine("Aceasta persoana este inalta");
            }
            else
            {
                Console.WriteLine("Aceasta persoana este foarte inalta");
            }
        }

        public static void Exercise18()
        {
            //nu acopera cazul de egalitate; de lucrat mai mult
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} este cel mai mare numar");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} este cel mai mare numar");
            }
            else
            {
                Console.WriteLine($"{c} este cel mai mare numar");
            }
        }

        public static void Exercise19()
        {
            Console.Write("Introduceti primul numar: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti operatorul: ");
            var myOperator = Console.ReadLine();

            if (myOperator == "+")
            {
                Console.WriteLine($"{a} + {b}" + " = " + (a + b));
            }
            else if (myOperator == "-")
            {
                Console.WriteLine($"{a} - {b}" + " = " + (a - b));
            }
            else if (myOperator == "*")
            {
                Console.WriteLine($"{a} * {b}" + " = " + (a * b));
            }
            else if (myOperator == "/")
            {
                Console.WriteLine($"{a} / {b}" + " = " + (a / b));
            }
        }

        public static void Exercise20()
        {
            int i;

            for (i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise21()
        {
            int i;
            int sum = 0;

            for (i = 0; i < 11; i++)
            {
                sum = i + sum;
            }

            Console.WriteLine(sum);
        }

        public static void Exercise22()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            for (i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise23()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            for (i = 3; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise24()
        {
            int a = int.Parse(Console.ReadLine());
            int i;
            int sum = 0;

            for (i = 0; i < a; i++)
            {
                sum = i + sum;
            }

            Console.WriteLine(sum);
        }

        //public static void Exercise25()
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int i;
        //    int sum = 0;

        //    for (i = 0; i < a; i++)
        //    {
        //        sum = i + sum;
        //    }

        //    Console.WriteLine(sum);
        //}

        public static void Exercise26()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            for (i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Exercise27()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } 
            while (i < 11);

        }

        public static void Exercise28()
        {
            int i;
            int sum = 0;

            do
            {
                for (i = 0; i < 11; i++)
                {
                    sum = i + sum;
                }
            }
            while (i < 11);

            Console.WriteLine(sum);
        }

        public static void Exercise29()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            do
            {
                for (i = 0; i < a; i++)
                {
                    Console.WriteLine(i);
                }
            }
            while (i < a);
        }

        public static void Exercise30()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            do
            {
                for (i = 3; i < a; i++)
                {
                    Console.WriteLine(i);
                }
            }
            while (i < a);
        }

        public static void Exercise31()
        {
            int a = int.Parse(Console.ReadLine());
            int i;
            int sum = 0;

            do
            {
                for (i = 0; i < a; i++)
                {
                    sum = i + sum;
                }
            }
            while (i < a);

            Console.WriteLine(sum);
        }

        //public static void Exercise32()
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int i;
        //    int sum = 0;

        //    do
        //    {
        //        for (i = 0; i < a; i++)
        //        {
        //            sum = i + sum;
        //        }
        //    }
        //    while (i < a);

        //    Console.WriteLine(sum);
        //}

        public static void Exercise33()
        {
            int a = int.Parse(Console.ReadLine());
            int i;

            do
            {
                for (i = 0; i < a; i++)
                    {
                        if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                    }
            }
            while (i < a);
        }

        public static void Exercise41()
        {
            string[] myArray = { "sun", "moon", "clouds" };

            Console.WriteLine(myArray[1]);
        }

        public static void Exercise42()
        {
            string[] myArray = { "lemons", "watermelon", "cherry" };

            Console.WriteLine(myArray[2]);
        }

        public static void Exercise43()
        {
            string[] myArray = { "mom", "dad", "child" };
            
            Array.Reverse(myArray);

            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }
        }

        public static void Exercise44()
        {
            string[] myArray = { "mom", "dad", "child" };

            Array.Sort(myArray);

            foreach (string value in myArray)
            {
                Console.WriteLine(value);
            }
        }

        public static void Exercise45()
        {
            string[] myArray = new string[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                myArray[i] = Console.ReadLine();
            }
        }

        public static void Exercise46()
        {
            int[] myArray = new int[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            //+ add the elements
        }
    }
}
