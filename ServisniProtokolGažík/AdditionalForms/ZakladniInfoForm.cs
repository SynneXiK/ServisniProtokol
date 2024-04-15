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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServisniProtokolGažík.AdditionalForms
{
    public partial class ZakladniInfoForm : Form
    {
        public ServisniProtokol sp;
        public ZakladniInfoForm(ServisniProtokol servisniProtokol)
        {
            InitializeComponent();

            if (servisniProtokol._cisloProtokolu != null)
            {
                this.sp = servisniProtokol;

                textBoxCisloProtokolu.Text = sp._cisloProtokolu;
                dateTimePickerMereni.Value = sp._datumMereni.ToDateTime(new TimeOnly());
            }
            else
                this.sp = servisniProtokol;
        }

        private void textBoxCisloProtokolu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCisloProtokolu.Text))
            {
                this.errorProviderZakladInfo.SetError((Control)sender, "Pole nesmí být prázdné");
                e.Cancel = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.errorProviderZakladInfo.Clear();

            if (this.ValidateChildren())
            {
                sp._cisloProtokolu = textBoxCisloProtokolu.Text;
                sp._datumMereni = DateOnly.Parse(dateTimePickerMereni.Value.ToShortDateString());

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
