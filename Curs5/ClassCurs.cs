using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class ClassCurs
    {
        //modificatori de acces: private, public, protected
        protected int CursId { get; set; }
        protected string Nume { get; set; }
        protected int Durata { get; set; }

        //public ClassCurs(int cursId, string nume, int durata)
        //{
        //    CursId = cursId;
        //    Nume = nume;
        //    Durata = durata;
        //}

        public void SetareCurs(int id, string nume)
        {
            CursId = id;
            Nume = nume;
        }

        ////destructor
        //~ ClassCurs()
        //{
        //    Console.WriteLine("I am a destructor");
        //}

        // metode overload: folosim aceeasi metoda si o incarcam cu mai multi parametri, iar ea va lua decizii in functie de parametrii dati
        // metode overwrite: o metoda va schimba total functionalitatea deja declarata


    }
}
