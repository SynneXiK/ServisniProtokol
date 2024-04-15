namespace ServisniProtokolGažík.AdditionalForms
{
    partial class MereniForm
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
            textBoxJednotka = new TextBox();
            textBoxNamerenaHodnota = new TextBox();
            textBoxParametr = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            checkBoxVyhovuje = new CheckBox();
            errorProviderMereni = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderMereni).BeginInit();
            SuspendLayout();
            // 
            // textBoxJednotka
            // 
            textBoxJednotka.Location = new Point(197, 109);
            textBoxJednotka.Name = "textBoxJednotka";
            textBoxJednotka.Size = new Size(160, 23);
            textBoxJednotka.TabIndex = 18;
            textBoxJednotka.Validating += textBoxJednotka_Validating;
            // 
            // textBoxNamerenaHodnota
            // 
            textBoxNamerenaHodnota.Location = new Point(197, 72);
            textBoxNamerenaHodnota.Name = "textBoxNamerenaHodnota";
            textBoxNamerenaHodnota.Size = new Size(160, 23);
            textBoxNamerenaHodnota.TabIndex = 17;
            textBoxNamerenaHodnota.Validating += textBoxNamerenaHodnota_Validating;
            textBoxNamerenaHodnota.Validated += textBoxNamerenaHodnota_Validated;
            // 
            // textBoxParametr
            // 
            textBoxParametr.Location = new Point(197, 32);
            textBoxParametr.Name = "textBoxParametr";
            textBoxParametr.Size = new Size(160, 23);
            textBoxParametr.TabIndex = 16;
            textBoxParametr.Validating += textBoxParametr_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 144);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 15;
            label4.Text = "Vyhovuje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Jednotka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 13;
            label2.Text = "Naměřená Hodnota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "Parametr:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(63, 194);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(282, 194);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // checkBoxVyhovuje
            // 
            checkBoxVyhovuje.AutoSize = true;
            checkBoxVyhovuje.Location = new Point(197, 144);
            checkBoxVyhovuje.Name = "checkBoxVyhovuje";
            checkBoxVyhovuje.Size = new Size(15, 14);
            checkBoxVyhovuje.TabIndex = 19;
            checkBoxVyhovuje.UseVisualStyleBackColor = true;
            // 
            // errorProviderMereni
            // 
            errorProviderMereni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderMereni.ContainerControl = this;
            // 
            // MereniForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(407, 249);
            Controls.Add(checkBoxVyhovuje);
            Controls.Add(textBoxJednotka);
            Controls.Add(textBoxNamerenaHodnota);
            Controls.Add(textBoxParametr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "MereniForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mereni";
            ((System.ComponentModel.ISupportInitialize)errorProviderMereni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxJednotka;
        private TextBox textBoxNamerenaHodnota;
        private TextBox textBoxParametr;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonOk;
        private CheckBox checkBoxVyhovuje;
        private ErrorProvider errorProviderMereni;
    }
}