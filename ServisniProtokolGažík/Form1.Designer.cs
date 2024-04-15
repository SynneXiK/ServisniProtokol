namespace ServisniProtokolGažík
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            ZakaznikBox = new GroupBox();
            labelIc = new Label();
            labelPSC = new Label();
            labelAdresa = new Label();
            labelNazev = new Label();
            ZakaznikBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            ZarizeniBox = new GroupBox();
            labelSeriovecislo = new Label();
            labelModel = new Label();
            labelVyrobce = new Label();
            ZarizeniBtn = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            MereniBox = new GroupBox();
            buttonMereniDel = new Button();
            buttonMereniAdd = new Button();
            dataGridMereni = new DataGridView();
            ColParametr = new DataGridViewTextBoxColumn();
            ColNamerenaHodnota = new DataGridViewTextBoxColumn();
            ColJednotka = new DataGridViewTextBoxColumn();
            ColVyhovuje = new DataGridViewCheckBoxColumn();
            buttonMereniUpd = new Button();
            NahledBtn = new Button();
            ExportBtn = new Button();
            SaveBtn = new Button();
            LoadBtn = new Button();
            groupBoxServisProtokol = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            LabelcisloProtokolu = new Label();
            labelDatumMereni = new Label();
            buttonEditZaklad = new Button();
            ZakaznikBox.SuspendLayout();
            ZarizeniBox.SuspendLayout();
            MereniBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMereni).BeginInit();
            groupBoxServisProtokol.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Název:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Adresa:";
            // 
            // ZakaznikBox
            // 
            ZakaznikBox.Controls.Add(labelIc);
            ZakaznikBox.Controls.Add(labelPSC);
            ZakaznikBox.Controls.Add(labelAdresa);
            ZakaznikBox.Controls.Add(labelNazev);
            ZakaznikBox.Controls.Add(ZakaznikBtn);
            ZakaznikBox.Controls.Add(label4);
            ZakaznikBox.Controls.Add(label3);
            ZakaznikBox.Controls.Add(label1);
            ZakaznikBox.Controls.Add(label2);
            ZakaznikBox.Location = new Point(12, 170);
            ZakaznikBox.Name = "ZakaznikBox";
            ZakaznikBox.Size = new Size(287, 202);
            ZakaznikBox.TabIndex = 5;
            ZakaznikBox.TabStop = false;
            ZakaznikBox.Text = "Zakaznik";
            // 
            // labelIc
            // 
            labelIc.AutoSize = true;
            labelIc.Location = new Point(108, 112);
            labelIc.Name = "labelIc";
            labelIc.Size = new Size(12, 15);
            labelIc.TabIndex = 13;
            labelIc.Text = "?";
            // 
            // labelPSC
            // 
            labelPSC.AutoSize = true;
            labelPSC.Location = new Point(108, 83);
            labelPSC.Name = "labelPSC";
            labelPSC.Size = new Size(12, 15);
            labelPSC.TabIndex = 12;
            labelPSC.Text = "?";
            // 
            // labelAdresa
            // 
            labelAdresa.AutoSize = true;
            labelAdresa.Location = new Point(108, 54);
            labelAdresa.Name = "labelAdresa";
            labelAdresa.Size = new Size(12, 15);
            labelAdresa.TabIndex = 11;
            labelAdresa.Text = "?";
            // 
            // labelNazev
            // 
            labelNazev.AutoSize = true;
            labelNazev.Location = new Point(108, 25);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(12, 15);
            labelNazev.TabIndex = 10;
            labelNazev.Text = "?";
            // 
            // ZakaznikBtn
            // 
            ZakaznikBtn.Location = new Point(71, 153);
            ZakaznikBtn.Name = "ZakaznikBtn";
            ZakaznikBtn.Size = new Size(75, 23);
            ZakaznikBtn.TabIndex = 9;
            ZakaznikBtn.Text = "Upravit";
            ZakaznikBtn.UseVisualStyleBackColor = true;
            ZakaznikBtn.Click += ZakaznikBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 112);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 7;
            label4.Text = "IC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 83);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "PSC:";
            // 
            // ZarizeniBox
            // 
            ZarizeniBox.Controls.Add(labelSeriovecislo);
            ZarizeniBox.Controls.Add(labelModel);
            ZarizeniBox.Controls.Add(labelVyrobce);
            ZarizeniBox.Controls.Add(ZarizeniBtn);
            ZarizeniBox.Controls.Add(label10);
            ZarizeniBox.Controls.Add(label11);
            ZarizeniBox.Controls.Add(label12);
            ZarizeniBox.Location = new Point(471, 170);
            ZarizeniBox.Name = "ZarizeniBox";
            ZarizeniBox.Size = new Size(287, 202);
            ZarizeniBox.TabIndex = 14;
            ZarizeniBox.TabStop = false;
            ZarizeniBox.Text = "Zarizeni";
            // 
            // labelSeriovecislo
            // 
            labelSeriovecislo.AutoSize = true;
            labelSeriovecislo.Location = new Point(108, 83);
            labelSeriovecislo.Name = "labelSeriovecislo";
            labelSeriovecislo.Size = new Size(12, 15);
            labelSeriovecislo.TabIndex = 12;
            labelSeriovecislo.Text = "?";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(108, 54);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(12, 15);
            labelModel.TabIndex = 11;
            labelModel.Text = "?";
            // 
            // labelVyrobce
            // 
            labelVyrobce.AutoSize = true;
            labelVyrobce.Location = new Point(108, 25);
            labelVyrobce.Name = "labelVyrobce";
            labelVyrobce.Size = new Size(12, 15);
            labelVyrobce.TabIndex = 10;
            labelVyrobce.Text = "?";
            // 
            // ZarizeniBtn
            // 
            ZarizeniBtn.Location = new Point(71, 153);
            ZarizeniBtn.Name = "ZarizeniBtn";
            ZarizeniBtn.Size = new Size(75, 23);
            ZarizeniBtn.TabIndex = 9;
            ZarizeniBtn.Text = "Upravit";
            ZarizeniBtn.UseVisualStyleBackColor = true;
            ZarizeniBtn.Click += ZarizeniBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 83);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 5;
            label10.Text = "Seriové číslo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 25);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 1;
            label11.Text = "Výrobce:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 54);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 3;
            label12.Text = "Model:";
            // 
            // MereniBox
            // 
            MereniBox.Controls.Add(buttonMereniDel);
            MereniBox.Controls.Add(buttonMereniAdd);
            MereniBox.Controls.Add(dataGridMereni);
            MereniBox.Controls.Add(buttonMereniUpd);
            MereniBox.Location = new Point(26, 394);
            MereniBox.Name = "MereniBox";
            MereniBox.Size = new Size(591, 286);
            MereniBox.TabIndex = 14;
            MereniBox.TabStop = false;
            MereniBox.Text = "Mereni";
            // 
            // buttonMereniDel
            // 
            buttonMereniDel.Location = new Point(490, 221);
            buttonMereniDel.Name = "buttonMereniDel";
            buttonMereniDel.Size = new Size(75, 23);
            buttonMereniDel.TabIndex = 16;
            buttonMereniDel.Text = "Smazat";
            buttonMereniDel.UseVisualStyleBackColor = true;
            buttonMereniDel.Click += buttonMereniDel_Click;
            // 
            // buttonMereniAdd
            // 
            buttonMereniAdd.Location = new Point(490, 192);
            buttonMereniAdd.Name = "buttonMereniAdd";
            buttonMereniAdd.Size = new Size(75, 23);
            buttonMereniAdd.TabIndex = 15;
            buttonMereniAdd.Text = "Přidat";
            buttonMereniAdd.UseVisualStyleBackColor = true;
            buttonMereniAdd.Click += buttonMereniAdd_Click;
            // 
            // dataGridMereni
            // 
            dataGridMereni.AllowUserToAddRows = false;
            dataGridMereni.AllowUserToDeleteRows = false;
            dataGridMereni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMereni.Columns.AddRange(new DataGridViewColumn[] { ColParametr, ColNamerenaHodnota, ColJednotka, ColVyhovuje });
            dataGridMereni.Location = new Point(6, 22);
            dataGridMereni.Name = "dataGridMereni";
            dataGridMereni.ReadOnly = true;
            dataGridMereni.Size = new Size(443, 258);
            dataGridMereni.TabIndex = 14;
            // 
            // ColParametr
            // 
            ColParametr.DataPropertyName = "_parametr";
            ColParametr.HeaderText = "Parametr";
            ColParametr.Name = "ColParametr";
            ColParametr.ReadOnly = true;
            // 
            // ColNamerenaHodnota
            // 
            ColNamerenaHodnota.DataPropertyName = "_namerenaHodnota";
            ColNamerenaHodnota.HeaderText = "Naměřená Hodnota";
            ColNamerenaHodnota.Name = "ColNamerenaHodnota";
            ColNamerenaHodnota.ReadOnly = true;
            // 
            // ColJednotka
            // 
            ColJednotka.DataPropertyName = "_jednotka";
            ColJednotka.HeaderText = "Jednotka";
            ColJednotka.Name = "ColJednotka";
            ColJednotka.ReadOnly = true;
            // 
            // ColVyhovuje
            // 
            ColVyhovuje.DataPropertyName = "_vyhovuje";
            ColVyhovuje.HeaderText = "Vyhovuje";
            ColVyhovuje.Name = "ColVyhovuje";
            ColVyhovuje.ReadOnly = true;
            // 
            // buttonMereniUpd
            // 
            buttonMereniUpd.Location = new Point(490, 250);
            buttonMereniUpd.Name = "buttonMereniUpd";
            buttonMereniUpd.Size = new Size(75, 23);
            buttonMereniUpd.TabIndex = 9;
            buttonMereniUpd.Text = "Upravit";
            buttonMereniUpd.UseVisualStyleBackColor = true;
            buttonMereniUpd.Click += buttonMereniUpd_Click;
            // 
            // NahledBtn
            // 
            NahledBtn.Location = new Point(658, 503);
            NahledBtn.Name = "NahledBtn";
            NahledBtn.Size = new Size(101, 38);
            NahledBtn.TabIndex = 15;
            NahledBtn.Text = "Náhled";
            NahledBtn.UseVisualStyleBackColor = true;
            NahledBtn.Click += NahledBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(657, 547);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(102, 38);
            ExportBtn.TabIndex = 16;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(656, 591);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(102, 38);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(657, 636);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(101, 38);
            LoadBtn.TabIndex = 18;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // groupBoxServisProtokol
            // 
            groupBoxServisProtokol.Controls.Add(buttonEditZaklad);
            groupBoxServisProtokol.Controls.Add(labelDatumMereni);
            groupBoxServisProtokol.Controls.Add(LabelcisloProtokolu);
            groupBoxServisProtokol.Controls.Add(label6);
            groupBoxServisProtokol.Controls.Add(label5);
            groupBoxServisProtokol.Location = new Point(12, 12);
            groupBoxServisProtokol.Name = "groupBoxServisProtokol";
            groupBoxServisProtokol.Size = new Size(746, 152);
            groupBoxServisProtokol.TabIndex = 19;
            groupBoxServisProtokol.TabStop = false;
            groupBoxServisProtokol.Text = "Základní Informace";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 44);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 0;
            label5.Text = "Číslo protokolu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 90);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 1;
            label6.Text = "Datum měření:";
            // 
            // LabelcisloProtokolu
            // 
            LabelcisloProtokolu.AutoSize = true;
            LabelcisloProtokolu.Location = new Point(115, 44);
            LabelcisloProtokolu.Name = "LabelcisloProtokolu";
            LabelcisloProtokolu.Size = new Size(12, 15);
            LabelcisloProtokolu.TabIndex = 2;
            LabelcisloProtokolu.Text = "?";
            // 
            // labelDatumMereni
            // 
            labelDatumMereni.AutoSize = true;
            labelDatumMereni.Location = new Point(115, 90);
            labelDatumMereni.Name = "labelDatumMereni";
            labelDatumMereni.Size = new Size(12, 15);
            labelDatumMereni.TabIndex = 3;
            labelDatumMereni.Text = "?";
            // 
            // buttonEditZaklad
            // 
            buttonEditZaklad.Location = new Point(604, 44);
            buttonEditZaklad.Name = "buttonEditZaklad";
            buttonEditZaklad.Size = new Size(111, 65);
            buttonEditZaklad.TabIndex = 4;
            buttonEditZaklad.Text = "Upravit";
            buttonEditZaklad.UseVisualStyleBackColor = true;
            buttonEditZaklad.Click += buttonEditZaklad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 693);
            Controls.Add(groupBoxServisProtokol);
            Controls.Add(LoadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(ExportBtn);
            Controls.Add(NahledBtn);
            Controls.Add(MereniBox);
            Controls.Add(ZarizeniBox);
            Controls.Add(ZakaznikBox);
            Name = "Form1";
            Text = "Form1";
            ZakaznikBox.ResumeLayout(false);
            ZakaznikBox.PerformLayout();
            ZarizeniBox.ResumeLayout(false);
            ZarizeniBox.PerformLayout();
            MereniBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMereni).EndInit();
            groupBoxServisProtokol.ResumeLayout(false);
            groupBoxServisProtokol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private GroupBox ZakaznikBox;
        private Button ZakaznikBtn;
        private Label label4;
        private Label label3;
        private Label labelIc;
        private Label labelPSC;
        private Label labelAdresa;
        private Label labelNazev;
        private GroupBox ZarizeniBox;
        private Label labelSeriovecislo;
        private Label labelModel;
        private Label labelVyrobce;
        private Button ZarizeniBtn;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox MereniBox;
        private DataGridView dataGridMereni;
        private Button buttonMereniUpd;
        private Button NahledBtn;
        private Button ExportBtn;
        private Button SaveBtn;
        private Button LoadBtn;
        private Button buttonMereniDel;
        private Button buttonMereniAdd;
        private DataGridViewTextBoxColumn ColParametr;
        private DataGridViewTextBoxColumn ColNamerenaHodnota;
        private DataGridViewTextBoxColumn ColJednotka;
        private DataGridViewCheckBoxColumn ColVyhovuje;
        private GroupBox groupBoxServisProtokol;
        private Button buttonEditZaklad;
        private Label labelDatumMereni;
        private Label LabelcisloProtokolu;
        private Label label6;
        private Label label5;
    }
}
