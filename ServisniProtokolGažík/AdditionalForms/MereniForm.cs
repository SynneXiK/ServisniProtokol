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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServisniProtokolGažík.AdditionalForms
{
    public partial class MereniForm : Form
    {
        public Mereni mr;
        public MereniForm(Mereni? mereni)
        {
            InitializeComponent();

            if (mereni != null)
            {
                mr = mereni;
                this.textBoxParametr.Text = mr._parametr;
                this.textBoxNamerenaHodnota.Text = mr._namerenaHodnota.ToString();
                this.textBoxJednotka.Text = mr._jednotka;
                this.checkBoxVyhovuje.Checked = mr._vyhovuje;
            }
            else
                mr = new Mereni();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.errorProviderMereni.Clear();

            if (this.ValidateChildren())
            {
                mr._parametr = textBoxParametr.Text;
                mr._namerenaHodnota = Convert.ToDouble(textBoxNamerenaHodnota.Text);
                mr._jednotka = textBoxJednotka.Text;
                mr._vyhovuje = checkBoxVyhovuje.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void textBoxNamerenaHodnota_Validated(object sender, EventArgs e)
        {

        }
        private void textBoxParametr_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParametr.Text))
            {
                this.errorProviderMereni.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void textBoxNamerenaHodnota_Validating(object sender, CancelEventArgs e)
        {
            double result;
            string test = textBoxNamerenaHodnota.Text;
            bool test2 = double.TryParse(textBoxNamerenaHodnota.Text, out result);
            if (!double.TryParse(textBoxNamerenaHodnota.Text, out result))
            {
                this.errorProviderMereni.SetError((Control)sender, "Pole musí být číslo");
                e.Cancel = true;
            }
        }

        private void textBoxJednotka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJednotka.Text))
            {
                this.errorProviderMereni.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }
    }
}
