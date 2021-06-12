using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Bildnachricht : Nachricht
    {
        private string dateiname;

        public Bildnachricht() : this("", new Person())
        {

        }

        public Bildnachricht(string dateiname, Person absender)
        {
            this.absender = absender;
            this.dateiname = dateiname;
        }

        public override string getNachricht()
        {
            return this.absender.getVorname() + "  " + this.absender.getNachname() + "  >> Dateiname: " + this.dateiname + "  << Likes: " + this.likes;
        }

    }
}
