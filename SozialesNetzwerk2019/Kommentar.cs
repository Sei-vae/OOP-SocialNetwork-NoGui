using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    public class Kommentar
    {
        private Person _absender;
        private string _kommentartext;

        public Kommentar(Person absender, string kommentartext)
        {
            this._absender = absender;
            this._kommentartext = kommentartext;
        }

        public Person getAbsender()
        {
            return _absender;
        }

        public string getKommentarText()
        {
            return _kommentartext;
        }

    }
}
