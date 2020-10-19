using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Tutorial : ClassCurs
    {
        public void RenameTutorial(int tutorialId, string tutorialName)
        {
            CursId = tutorialId;
            Nume = tutorialName;
        }
    }
}
