using ServisniProtokolGažík.AdditionalForms;
using ServisniProtokolGažík.Models;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ServisniProtokolGažík
{
    public partial class Form1 : Form
    {
        private ServisniProtokol sp = new ServisniProtokol();
        private BindingList<Mereni> mereniList = new BindingList<Mereni>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridMereni.AutoGenerateColumns = false;
            this.dataGridMereni.DataSource = mereniList;
        }

        private void ZakaznikBtn_Click(object sender, EventArgs e)
        {
            ZakaznikForm zFrm = new ZakaznikForm(sp._zakaznik);

            if (zFrm.ShowDialog() == DialogResult.OK)
            {
                Zakaznik zakaznik = zFrm.zk;
                sp._zakaznik = zakaznik;

                labelNazev.Text = zakaznik._nazev;
                labelAdresa.Text = zakaznik._adresa;
                labelPSC.Text = zakaznik._psc;
                labelIc.Text = zakaznik._ic;
            }
        }

        private void ZarizeniBtn_Click(object sender, EventArgs e)
        {
            ZarizeniForm zFrm = new ZarizeniForm(sp._zarizeni);

            if (zFrm.ShowDialog() == DialogResult.OK)
            {
                Zarizeni zarizeni = zFrm.zr;
                sp._zarizeni = zarizeni;

                labelVyrobce.Text = zarizeni._vyrobce;
                labelModel.Text = zarizeni._model;
                labelSeriovecislo.Text = zarizeni._serioveCislo;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.FileName = "ServisniProtokol";
            ofd.Filter = "*.txt|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string ext = Path.GetExtension(filePath);

                if (ext == ".txt")
                {
                    XmlSerializer ser = new XmlSerializer(typeof(ServisniProtokol));
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        this.sp = (ServisniProtokol)ser.Deserialize(sr)!;
                    }

                    LabelcisloProtokolu.Text = sp._cisloProtokolu;
                    labelDatumMereni.Text = sp._datumMereni.ToString();

                    Zakaznik zakaznik = sp._zakaznik;
                    labelNazev.Text = zakaznik._nazev;
                    labelAdresa.Text = zakaznik._adresa;
                    labelPSC.Text = zakaznik._psc;
                    labelIc.Text = zakaznik._ic;

                    Zarizeni zarizeni = sp._zarizeni;
                    labelVyrobce.Text = zarizeni._vyrobce;
                    labelModel.Text = zarizeni._model;
                    labelSeriovecislo.Text = zarizeni._serioveCislo;

                    this.mereniList.Clear();
                    foreach (Mereni item in sp._mereni)
                    {
                        this.mereniList.Add(item);
                    }
                }

            }
        }

        private void NahledBtn_Click(object sender, EventArgs e)
        {
            NahledForm nFrm = new NahledForm(sp);
            nFrm.ShowDialog();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "html";
            sfd.FileName = "ServisniProtokol";
            sfd.Filter = "*.html|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                string ext = Path.GetExtension(filePath);

                if (ext == ".html")
                {
                    string output = sp.PrevedNaHtml();
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.Write(output);
                        sw.Close();
                    }
                }
                else 
                {
                    SaveBtn_Click(sender, e); // aah asi
                }
            }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.FileName = "ServisniProtokol";
            sfd.Filter = "*.txt|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                string ext = Path.GetExtension(filePath);

                if (ext == ".txt")
                {
                    XmlSerializer ser = new XmlSerializer(typeof(ServisniProtokol));
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        XmlIncludeAttribute xmlIncludeAttribute = new XmlIncludeAttribute(typeof(Zarizeni));
                        ser.Serialize(sw, this.sp);
                    }
                }

            }
        }

        private void buttonMereniAdd_Click(object sender, EventArgs e)
        {
            MereniForm mFrm = new MereniForm(null);

            if (mFrm.ShowDialog() == DialogResult.OK)
            {
                sp._mereni.Add(mFrm.mr);
                mereniList.Add(mFrm.mr);
            }
        }
        private void buttonMereniUpd_Click(object sender, EventArgs e)
        {
            if (mereniList.Count > 0)
            {
                int index = dataGridMereni.CurrentRow.Index;
                MereniForm mFrm = new MereniForm(mereniList[index]);

                if (mFrm.ShowDialog() == DialogResult.OK)
                {
                    sp._mereni[index] = mFrm.mr;
                    mereniList[index] = mFrm.mr;
                }
            }

        }
        private void buttonMereniDel_Click(object sender, EventArgs e)
        {
            if (mereniList.Count > 0)
            {
                int index = dataGridMereni.CurrentRow.Index;

                sp._mereni.RemoveAt(index);
                mereniList.RemoveAt(index);
            }
        }

        private void buttonEditZaklad_Click(object sender, EventArgs e)
        {
            ZakladniInfoForm zFrm = new ZakladniInfoForm(sp);

            if (zFrm.ShowDialog() == DialogResult.OK)
            {
                ServisniProtokol servis = zFrm.sp;
                sp._cisloProtokolu = servis._cisloProtokolu;
                sp._datumMereni = servis._datumMereni;

                this.LabelcisloProtokolu.Text = sp._cisloProtokolu;
                this.labelDatumMereni.Text = sp._datumMereni.ToString();
            }
        }
    }
}
