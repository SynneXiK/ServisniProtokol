namespace ServisniProtokolGažík.AdditionalForms
{
    partial class ZakaznikForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProviderZakaznik = new ErrorProvider(components);
            buttonOk = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNazev = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxPSC = new TextBox();
            textBoxIc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderZakaznik).BeginInit();
            SuspendLayout();
            // 
            // errorProviderZakaznik
            // 
            errorProviderZakaznik.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderZakaznik.ContainerControl = this;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(243, 193);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(24, 193);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Název:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 110);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "PSC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 145);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 5;
            label4.Text = "IC:";
            // 
            // textBoxNazev
            // 
            textBoxNazev.Location = new Point(128, 30);
            textBoxNazev.Name = "textBoxNazev";
            textBoxNazev.Size = new Size(160, 23);
            textBoxNazev.TabIndex = 6;
            textBoxNazev.Validating += textBoxNazev_Validating;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(128, 70);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(160, 23);
            textBoxAdresa.TabIndex = 7;
            textBoxAdresa.Validating += textBoxAdresa_Validating;
            // 
            // textBoxPSC
            // 
            textBoxPSC.Location = new Point(128, 107);
            textBoxPSC.Name = "textBoxPSC";
            textBoxPSC.Size = new Size(160, 23);
            textBoxPSC.TabIndex = 8;
            textBoxPSC.Validating += textBoxPSC_Validating;
            // 
            // textBoxIc
            // 
            textBoxIc.Location = new Point(128, 142);
            textBoxIc.Name = "textBoxIc";
            textBoxIc.Size = new Size(160, 23);
            textBoxIc.TabIndex = 9;
            textBoxIc.Validating += textBoxIc_Validating;
            // 
            // ZakaznikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(353, 245);
            Controls.Add(textBoxIc);
            Controls.Add(textBoxPSC);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxNazev);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "ZakaznikForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zakaznik";
            ((System.ComponentModel.ISupportInitialize)errorProviderZakaznik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProviderZakaznik;
        private TextBox textBoxIc;
        private TextBox textBoxPSC;
        private TextBox textBoxAdresa;
        private TextBox textBoxNazev;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonOk;
    }
}