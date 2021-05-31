using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Periodni_Sustav_Elemenata
{
    public static class TextReader
    {
        public static List<String> Tekstovi = new List<String>();

        public static List<String> protonskiBrojevi = new List<String>();
        public static List<String> simboli = new List<String>();
        public static List<String> imena = new List<String>();
        public static List<String> temperatureTaljenja = new List<String>();
        public static List<String> temperatureIsparavanja = new List<String>();
        public static List<String> maseniBrojevi = new List<String>();
        public static List<String> koristenja = new List<String>();
        public static List<String> opisi = new List<String>();

        public static void Ucitaj(string jezik)
        {
            Tekstovi.Clear();

                if (jezik == "en")
                    Tekstovi = Properties.Resources.pse_en.Split('\n').ToList();
                else if (jezik == "de")
                    Tekstovi = Properties.Resources.pse_de.Split('\n').ToList();
                else
                    Tekstovi = Properties.Resources.pse_hr.Split('\n').ToList();
                Rastavi();


        }

        public static void Rastavi()
        {
            protonskiBrojevi.Clear();
            simboli.Clear();
            imena.Clear();
            temperatureTaljenja.Clear();
            temperatureIsparavanja.Clear();
            maseniBrojevi.Clear();
            koristenja.Clear();
            opisi.Clear();

            for (int i = 0; i <= (Tekstovi.Count - 1)/8 ;i++)
            {
                protonskiBrojevi.Add(Tekstovi.ElementAt(8*i));
                simboli.Add(Tekstovi.ElementAt(1 + 8 * i));
                imena.Add(Tekstovi.ElementAt(2 + 8 * i));
                temperatureTaljenja.Add(Tekstovi.ElementAt(3 + 8 * i));
                temperatureIsparavanja.Add(Tekstovi.ElementAt(4 + 8 * i));
                maseniBrojevi.Add(Tekstovi.ElementAt(5 + 8 * i));
                koristenja.Add(Tekstovi.ElementAt(6 + 8 * i));
                opisi.Add(Tekstovi.ElementAt(7 + 8 * i));

            }

            for(int i = 0; i < protonskiBrojevi.Count; i++)
            {
                simboli[i] = simboli[i][0].ToString().ToUpper() + simboli[i].Substring(1);
                imena[i] = imena[i][0].ToString().ToUpper() + imena[i].Substring(1);
            }
        }

    }
}
