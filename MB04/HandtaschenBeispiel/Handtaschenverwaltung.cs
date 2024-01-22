using MB04.HandtaschenBeispiel.Loesung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MB04.HandtaschenBeispiel
{
    public partial class Handtaschenverwaltung : Form
    {
        HandTaschenListe handTaschenList = new HandTaschenListe();
        public Handtaschenverwaltung()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            var price = Convert.ToDouble(NuDPrice.Text);
            TxtOutput.Text = "";
            Handtasche newHandtasche = new Handtasche(name, price);

            handTaschenList = handTaschenList.AddHandtasche(handTaschenList, newHandtasche);
            foreach(Handtasche handtasche in handTaschenList.HandTaschen)
            {
                TxtOutput.Text += handtasche.Name + "\t" + handtasche.Price + Environment.NewLine;
            }
            //TxtOutput.Text = handTaschenList.ToString();
        }
    }
}
