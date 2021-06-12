using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    public class Person
    {
        private string nachname;
        private string vorname;

        public Person() : this("", "")
        {

        }

        public Person(string nn, string vn)
        {
            this.nachname = nn;
            this.vorname = vn;
        }

        public string getNachname()
        {
            return this.nachname;
        }

        public string getVorname()
        {
            return this.vorname;
        }
    }
}
