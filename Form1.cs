using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weiss_Jessica_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVorwärts_Click(object sender, EventArgs e)
        {
            textBoxEintrag.Text = "";
            //1.Variable deklarieren
            int intObergrenze = 10;


            //2.Rechnen
            for(int counter = 1; counter <= intObergrenze; counter++)
            {
                textBoxEintrag.Text += "Zähler: " + counter + "\r\n";
            }
            

        }

        private void btnRückwärts_Click(object sender, EventArgs e)
        {
            textBoxEintrag.Text = "";
            //1.Variable deklarieren
            int intUntergrenze = 1;


            //2.Rechnen
            for (int counter = 10; counter >= intUntergrenze; counter--)
            {
                textBoxEintrag.Text += "Zähler: " + counter + "\r\n";
            }
        }

        private void btnLücken_Click(object sender, EventArgs e)
        {
            textBoxEintrag.Text = "";
            //1.Variable deklarieren
            int intObergrenze = 20;


            //2.Rechnen
            for (int counter = 1; counter <= intObergrenze; counter+=2)
            {
                textBoxEintrag.Text += "Zähler: " + counter + "\r\n";
            }
        }
    }
}
