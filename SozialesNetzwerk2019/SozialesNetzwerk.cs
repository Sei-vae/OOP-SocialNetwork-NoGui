using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class SozialesNetzwerk
    {
        private List<Person> mitgliederliste;
        private List<Nachricht> nachrichtenliste;
        public SozialesNetzwerk()
        {
            mitgliederliste = new List<Person>();
            nachrichtenliste = new List<Nachricht>();
        }

        public void hinzufuegenMitglied(Person person)
        {
            this.mitgliederliste.Add(person);
        }

        public void hinzufuegenNachricht(Nachricht nachricht)
        {
            this.nachrichtenliste.Add(nachricht);
        }

        public string getAlleNachrichten()
        {
            String allNachrichten = "";
            foreach(Nachricht nachricht in nachrichtenliste)
            {
                allNachrichten += nachricht.getNachricht() + "\n";
            }
            return allNachrichten;
        }

    }
}
