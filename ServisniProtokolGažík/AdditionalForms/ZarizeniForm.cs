using ServisniProtokolGažík.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokolGažík.AdditionalForms
{
    public partial class ZarizeniForm : Form
    {
        public Zarizeni zr;
        public ZarizeniForm(Zarizeni zarizeni)
        {
            InitializeComponent();

            if (zarizeni != null)
            {
                this.zr = zarizeni;
                textBoxVyrobce.Text = zr._vyrobce;
                textBoxModel.Text = zr._model;
                textBoxSerioveCislo.Text = zr._serioveCislo;
            }
            else
                zr = new Zarizeni();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.errorProviderZarizeni.Clear();

            if (this.ValidateChildren())
            {
                zr._vyrobce = textBoxVyrobce.Text;
                zr._model = textBoxModel.Text;
                zr._serioveCislo = textBoxSerioveCislo.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxVyrobce_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVyrobce.Text))
            {
                this.errorProviderZarizeni.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void textBoxModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                this.errorProviderZarizeni.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void textBoxSerioveCislo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSerioveCislo.Text))
            {
                this.errorProviderZarizeni.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }
    }
}
