using ServisniProtokolGažík.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokolGažík.AdditionalForms
{
    public partial class ZakaznikForm : Form
    {
        public Zakaznik zk;
        public ZakaznikForm(Zakaznik zakaznik)
        {
            InitializeComponent();

            if (zakaznik != null)
            {
                this.zk = zakaznik;

                textBoxNazev.Text = zk._nazev;
                textBoxAdresa.Text = zk._adresa;
                textBoxPSC.Text = zk._psc;
                textBoxIc.Text = zk._ic;
            }
            else
                zk = new Zakaznik();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.errorProviderZakaznik.Clear();

            if (this.ValidateChildren())
            {
                zk._nazev = textBoxNazev.Text;
                zk._adresa = textBoxAdresa.Text;
                zk._psc = textBoxPSC.Text;
                zk._ic = textBoxIc.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxNazev_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNazev.Text))
            {
                this.errorProviderZakaznik.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAdresa.Text))
            {
                this.errorProviderZakaznik.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void textBoxPSC_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxPSC.Text, @"^\d{3} \d{2}$"))
            {
                e.Cancel = true;
                this.errorProviderZakaznik.SetError((Control)sender, "Pole musí být ve tvaru PSČ (130 00)");

            }
        }

        private void textBoxIc_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxIc.Text, @"^\d{6}$"))
            {
                e.Cancel = true;
                this.errorProviderZakaznik.SetError((Control)sender, "Pole musí být ve tvaru IC (6 čísel)");

            }
        }
    }
}
