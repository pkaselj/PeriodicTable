using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodni_Sustav_Elemenata
{
    public static class Resursi
    {
        public static Dictionary<String, Rijec> Rijecnik = new Dictionary<String, Rijec>();

        public static String Prevedi(String Key)
        {
            Rijec rijec;
            bool tf = Rijecnik.TryGetValue(Key, out rijec);
            if (tf)
            {
                if (Form1.trenutniJezik == Form1.s_UKPictureBox)
                    return rijec.EN;
                else if (Form1.trenutniJezik == Form1.s_DEPictureBox)
                    return rijec.DE;
                return rijec.HR;
            }
            return "ERROR";
                
        }

        public static void Postavi()
        {
            Rijecnik.Add("standardTab", new Rijec("Standard","Standard","Standardno"));
            Rijecnik.Add("temperatureTab", new Rijec("Temperatures", "Temperaturen", "Temperature"));
            Rijecnik.Add("useTab", new Rijec("Use", "Verwendung", "Upotreba"));
            Rijecnik.Add("Title", new Rijec("Periodic Table of Elements", "Periodensystem der Elemente", "Periodni Sustav Elemenata"));

            Rijecnik.Add("Engleski", new Rijec("English", "Englisch", "Engleski"));
            Rijecnik.Add("Njemacki", new Rijec("German", "Deutsch", "Njemački"));
            Rijecnik.Add("Hrvatski", new Rijec("Croatian", "Kroatisch", "Hrvatski"));

            Rijecnik.Add("Postavke", new Rijec("Settings", "Einstellung", "Postavke"));

            Rijecnik.Add("PozadinaStandard", new Rijec("\"Standard\" Background", "\"Standard\" Hintergrund", "\"Standardno\" pozadina"));
            Rijecnik.Add("PozadinaTemperature", new Rijec("\"Temperature\" Background", "\"Temperaturen\" Hintergrund", "\"Temperature\" pozadina"));

            Rijecnik.Add("Alkalijski", new Rijec("Alkaline", "Alkalisch", "Alkalijski"));
            Rijecnik.Add("Zemnoalkalijski", new Rijec("Alkaline Earth", "Erdalkalisch", "Zemnoalkalijski"));
            Rijecnik.Add("Prijelazni", new Rijec("Transitional", "Übergangen", "Prijelazni"));
            Rijecnik.Add("Postprijelazni", new Rijec("Post-Transitional", "Nach-Übergangen", "Postprijelazni"));
            Rijecnik.Add("Polumetali", new Rijec("Semimetals", "Halbmetalle", "Polumetali"));
            Rijecnik.Add("Nemetali", new Rijec("Nonmetals", "Nichtmetalle", "Nemetali"));
            Rijecnik.Add("Plemeniti", new Rijec("Noble gasses", "Edelgase", "Plemeniti plinovi"));
            Rijecnik.Add("f-block", new Rijec("f-block", "f-blok", "f-blok"));

            Rijecnik.Add("nepoznato", new Rijec("Unknown", "Unbekannte", "Nepoznato"));

            Rijecnik.Add("s", new Rijec("Solid", "Flest", "Krutina"));
            Rijecnik.Add("l", new Rijec("Liquid", "Flüssig", "Tekućina"));
            Rijecnik.Add("g", new Rijec("Gas", "Gasförmig", "Plin"));
        }
    }

    public class Rijec
    {
        public String EN, DE, HR;

        public Rijec(String en, String de, String hr)
        {
            EN = en;
            DE = de;
            HR = hr;
        }
    }
}
