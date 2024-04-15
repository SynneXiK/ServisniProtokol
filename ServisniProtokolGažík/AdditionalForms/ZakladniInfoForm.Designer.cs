namespace ServisniProtokolGažík.AdditionalForms
{
    partial class ZakladniInfoForm
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
            errorProviderZakladInfo = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            textBoxCisloProtokolu = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            dateTimePickerMereni = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProviderZakladInfo).BeginInit();
            SuspendLayout();
            // 
            // errorProviderZakladInfo
            // 
            errorProviderZakladInfo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderZakladInfo.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Číslo protokolu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Datum měření:";
            // 
            // textBoxCisloProtokolu
            // 
            textBoxCisloProtokolu.Location = new Point(125, 30);
            textBoxCisloProtokolu.Name = "textBoxCisloProtokolu";
            textBoxCisloProtokolu.Size = new Size(215, 23);
            textBoxCisloProtokolu.TabIndex = 2;
            textBoxCisloProtokolu.Validating += textBoxCisloProtokolu_Validating;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(22, 131);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(265, 131);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // dateTimePickerMereni
            // 
            dateTimePickerMereni.Location = new Point(125, 79);
            dateTimePickerMereni.Name = "dateTimePickerMereni";
            dateTimePickerMereni.Size = new Size(215, 23);
            dateTimePickerMereni.TabIndex = 6;
            // 
            // ZakladniInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(375, 175);
            Controls.Add(dateTimePickerMereni);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxCisloProtokolu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ZakladniInfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZakladniInfoForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderZakladInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProviderZakladInfo;
        private DateTimePicker dateTimePickerMereni;
        private Button buttonOk;
        private Button buttonCancel;
        private TextBox textBoxCisloProtokolu;
        private Label label2;
        private Label label1;
    }
}