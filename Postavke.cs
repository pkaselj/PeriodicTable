using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodni_Sustav_Elemenata
{
    public partial class Postavke : Form
    {

        public Form1 parent;
        public Postavke()
        {
            InitializeComponent();
            
            Text = Resursi.Prevedi("Postavke");

            standardColors.Text = Resursi.Prevedi("standardTab");
            temperatureColors.Text = Resursi.Prevedi("temperatureTab");

            standardBackColor.BackColor = CustomColors.standardColor;
            temperatureBackColor.BackColor = CustomColors.temperatureColor;

            alkalijskiBackColor.BackColor = CustomColors.alkalijski;
            zemnoalkalijskiBackColor.BackColor = CustomColors.zemnoalkalijski;
            prijelazniBackColor.BackColor = CustomColors.prijelazni;
            postprijelazniBackColor.BackColor = CustomColors.postprijelazni;
            polumetaliBackColor.BackColor = CustomColors.polumetali;
            nemetaliBackColor.BackColor = CustomColors.nemetali;
            plemenitiBackColor.BackColor = CustomColors.plemeniti;
            fblokBackColor.BackColor = CustomColors.fblok;
            errorBackColor.BackColor = CustomColors.errorColor;

            sBackColor.BackColor = CustomColors.solid;
            lBackColor.BackColor = CustomColors.liquid;
            gBackColor.BackColor = CustomColors.gas;

            toolTip1.SetToolTip(standardBackColor, Resursi.Prevedi("standardTab"));
            toolTip1.SetToolTip(temperatureBackColor, Resursi.Prevedi("temperatureTab"));

            toolTip1.SetToolTip(alkalijskiBackColor, Resursi.Prevedi("Alkalijski"));
            toolTip1.SetToolTip(zemnoalkalijskiBackColor, Resursi.Prevedi("Zemnoalkalijski"));
            toolTip1.SetToolTip(prijelazniBackColor, Resursi.Prevedi("Prijelazni"));
            toolTip1.SetToolTip(postprijelazniBackColor, Resursi.Prevedi("Postprijelazni"));
            toolTip1.SetToolTip(polumetaliBackColor, Resursi.Prevedi("Polumetali"));
            toolTip1.SetToolTip(nemetaliBackColor, Resursi.Prevedi("Nemetali"));
            toolTip1.SetToolTip(plemenitiBackColor, Resursi.Prevedi("Plemeniti"));
            toolTip1.SetToolTip(fblokBackColor, Resursi.Prevedi("f-block"));
            toolTip1.SetToolTip(errorBackColor, Resursi.Prevedi("nepoznato"));


            toolTip1.SetToolTip(sBackColor, Resursi.Prevedi("s"));
            toolTip1.SetToolTip(lBackColor, Resursi.Prevedi("l"));
            toolTip1.SetToolTip(gBackColor, Resursi.Prevedi("g"));

            foreach (Control cnt in standardColors.Controls)
            {
                if (cnt is Button)
                    cnt.Click += new EventHandler(IzaberiBoju);
            }
            foreach (Control cnt in temperatureColors.Controls)
            {
                if (cnt is Button)
                    cnt.Click += new EventHandler(IzaberiBoju);
            }

        }

        private void Potvrdi(object sender, EventArgs e)
        {
            CustomColors.standardColor = standardBackColor.BackColor;
            CustomColors.temperatureColor = temperatureBackColor.BackColor;

            CustomColors.alkalijski = alkalijskiBackColor.BackColor;
            CustomColors.zemnoalkalijski = zemnoalkalijskiBackColor.BackColor;
            CustomColors.prijelazni = prijelazniBackColor.BackColor;
            CustomColors.postprijelazni = postprijelazniBackColor.BackColor;
            CustomColors.polumetali = polumetaliBackColor.BackColor;
            CustomColors.nemetali = nemetaliBackColor.BackColor;
            CustomColors.plemeniti = fblokBackColor.BackColor;
            CustomColors.fblok = fblokBackColor.BackColor;

            CustomColors.errorColor = errorBackColor.BackColor;

            CustomColors.solid = sBackColor.BackColor;
            CustomColors.liquid = lBackColor.BackColor;
            CustomColors.gas = gBackColor.BackColor;

            parent.PostaviBoje();
            parent.PromijeniBoju(Form1.temperature);
            Close();
            
        }

        private void IzaberiBoju(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ColorDialog birac = new ColorDialog();
            birac.Color = button.BackColor;

            if (birac.ShowDialog() == DialogResult.OK)
                button.BackColor = birac.Color;
        }


        
    }
}
