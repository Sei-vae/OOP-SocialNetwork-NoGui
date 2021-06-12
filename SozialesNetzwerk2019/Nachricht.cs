using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    abstract class Nachricht
    {
        protected int likes;
        protected Person absender;
        protected List<Kommentar> kommentare;

        public Nachricht() : this(new Person())
        {

        }

        public Nachricht(Person absender)
        {
            this.absender = absender;
            this.kommentare = new List<Kommentar>();
        }

        public void hinzufuegenLike()
        {
            this.likes++;
        }

        public void addKommentar(Kommentar kommentar)
        {
            this.kommentare.Add(kommentar);
        }

        public abstract string getNachricht();
    }
}
