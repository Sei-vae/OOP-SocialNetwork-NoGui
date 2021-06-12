using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Textnachricht : Nachricht
    {
        private string nachricht;

        public Textnachricht() : this("", new Person())
        {

        }

        public Textnachricht(string nachricht, Person absender)
        {
            this.absender = absender;
            this.nachricht = nachricht;
        }

        public override string getNachricht()
        {
            return this.absender.getVorname() + "  " + this.absender.getNachname() + "  >> " + this.nachricht + "  << Likes: " + this.likes;        
        }


    }
}
