using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Program
    {
        static void Main(string[] args)
        {
            SozialesNetzwerk szN = new SozialesNetzwerk();

            Person p1 = new Person("Hans", "Peter");
            Person p2 = new Person("Buda", "Pest");

            szN.hinzufuegenMitglied(p1);
            szN.hinzufuegenMitglied(p2);

            Textnachricht tn = new Textnachricht("Test Nachricht 1", p1);
            Textnachricht tn2 = new Textnachricht("Test Nachricht 2", p2);

            szN.hinzufuegenNachricht(tn);
            szN.hinzufuegenNachricht(tn2);

            tn.hinzufuegenLike();
            tn2.hinzufuegenLike();

            Console.WriteLine(szN.getAlleNachrichten());
            

            Console.WriteLine(getPasswort("Ich generie mir ein neues Passwort"));
            Console.ReadLine();
        }

        public static string getPasswort(string satz)
        {
            string password = "";
            foreach(var wort in satz.Split(' '))
            {
                password += (password.Length % 2 == 0) ? wort.Substring(0, 1).ToUpper() : wort.Substring(0, 1).ToLower();
            }
            return password;
        }

    }
}
