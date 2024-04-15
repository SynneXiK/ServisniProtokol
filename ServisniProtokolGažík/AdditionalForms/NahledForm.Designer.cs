namespace ServisniProtokolGažík.AdditionalForms
{
    partial class NahledForm
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
            pictureBoxNahled = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNahled).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxNahled
            // 
            pictureBoxNahled.Location = new Point(12, 12);
            pictureBoxNahled.Name = "pictureBoxNahled";
            pictureBoxNahled.Size = new Size(800, 905);
            pictureBoxNahled.TabIndex = 0;
            pictureBoxNahled.TabStop = false;
            pictureBoxNahled.Paint += pictureBoxNahled_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(739, 923);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Zavřít";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // NahledForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 958);
            Controls.Add(buttonClose);
            Controls.Add(pictureBoxNahled);
            Name = "NahledForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NahledForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxNahled).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxNahled;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonClose;
    }
}