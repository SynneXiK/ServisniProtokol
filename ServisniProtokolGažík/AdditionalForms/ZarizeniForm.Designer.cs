namespace ServisniProtokolGažík.AdditionalForms
{
    partial class ZarizeniForm
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
            textBoxVyrobce = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            textBoxModel = new TextBox();
            textBoxSerioveCislo = new TextBox();
            errorProviderZarizeni = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderZarizeni).BeginInit();
            SuspendLayout();
            // 
            // textBoxVyrobce
            // 
            textBoxVyrobce.Location = new Point(125, 15);
            textBoxVyrobce.Name = "textBoxVyrobce";
            textBoxVyrobce.Size = new Size(160, 23);
            textBoxVyrobce.TabIndex = 16;
            textBoxVyrobce.Validating += textBoxVyrobce_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 95);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 14;
            label3.Text = "Seriové číslo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 58);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 12;
            label1.Text = "Výrobce:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(23, 137);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(241, 137);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(125, 55);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(160, 23);
            textBoxModel.TabIndex = 17;
            textBoxModel.Validating += textBoxModel_Validating;
            // 
            // textBoxSerioveCislo
            // 
            textBoxSerioveCislo.Location = new Point(125, 92);
            textBoxSerioveCislo.Name = "textBoxSerioveCislo";
            textBoxSerioveCislo.Size = new Size(160, 23);
            textBoxSerioveCislo.TabIndex = 18;
            textBoxSerioveCislo.Validating += textBoxSerioveCislo_Validating;
            // 
            // errorProviderZarizeni
            // 
            errorProviderZarizeni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderZarizeni.ContainerControl = this;
            // 
            // ZarizeniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(353, 187);
            Controls.Add(textBoxSerioveCislo);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxVyrobce);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "ZarizeniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zarizeni";
            ((System.ComponentModel.ISupportInitialize)errorProviderZarizeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIc;
        private TextBox textBoxPSC;
        private TextBox textBoxAdresa;
        private TextBox textBoxVyrobce;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonOk;
        private TextBox textBoxModel;
        private TextBox textBoxSerioveCislo;
        private ErrorProvider errorProviderZarizeni;
    }
}