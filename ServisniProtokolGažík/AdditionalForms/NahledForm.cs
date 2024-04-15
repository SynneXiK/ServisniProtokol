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
    public partial class NahledForm : Form
    {
        private ServisniProtokol sp;
        public NahledForm(ServisniProtokol sp)
        {
            InitializeComponent();
            this.sp = sp;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNahled_Paint(object sender, PaintEventArgs e)
        {
            sp.Vykresli(e.Graphics);
        }
    }
}
