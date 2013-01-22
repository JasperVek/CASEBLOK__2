namespace Case2Project
{
    partial class Form3
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
            this.beoordelingTextBox = new System.Windows.Forms.TextBox();
            this.labelBeoordelingTekst = new System.Windows.Forms.Label();
            this.labelCijfer = new System.Windows.Forms.Label();
            this.cijferTextBox = new System.Windows.Forms.TextBox();
            this.buttonBeoordelingOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beoordelingTextBox
            // 
            this.beoordelingTextBox.Location = new System.Drawing.Point(30, 38);
            this.beoordelingTextBox.MaxLength = 300;
            this.beoordelingTextBox.Multiline = true;
            this.beoordelingTextBox.Name = "beoordelingTextBox";
            this.beoordelingTextBox.Size = new System.Drawing.Size(250, 175);
            this.beoordelingTextBox.TabIndex = 0;
            // 
            // labelBeoordelingTekst
            // 
            this.labelBeoordelingTekst.AutoSize = true;
            this.labelBeoordelingTekst.Location = new System.Drawing.Point(27, 22);
            this.labelBeoordelingTekst.Name = "labelBeoordelingTekst";
            this.labelBeoordelingTekst.Size = new System.Drawing.Size(175, 13);
            this.labelBeoordelingTekst.TabIndex = 1;
            this.labelBeoordelingTekst.Text = "Geef beoordeling (max 300 tekens):";
            // 
            // labelCijfer
            // 
            this.labelCijfer.AutoSize = true;
            this.labelCijfer.Location = new System.Drawing.Point(27, 242);
            this.labelCijfer.Name = "labelCijfer";
            this.labelCijfer.Size = new System.Drawing.Size(58, 13);
            this.labelCijfer.TabIndex = 2;
            this.labelCijfer.Text = "Geef cijfer:";
            // 
            // cijferTextBox
            // 
            this.cijferTextBox.Location = new System.Drawing.Point(30, 258);
            this.cijferTextBox.MaxLength = 2;
            this.cijferTextBox.Name = "cijferTextBox";
            this.cijferTextBox.Size = new System.Drawing.Size(100, 20);
            this.cijferTextBox.TabIndex = 3;
            // 
            // buttonBeoordelingOk
            // 
            this.buttonBeoordelingOk.Location = new System.Drawing.Point(205, 258);
            this.buttonBeoordelingOk.Name = "buttonBeoordelingOk";
            this.buttonBeoordelingOk.Size = new System.Drawing.Size(75, 23);
            this.buttonBeoordelingOk.TabIndex = 4;
            this.buttonBeoordelingOk.Text = "Ok";
            this.buttonBeoordelingOk.UseVisualStyleBackColor = true;
            this.buttonBeoordelingOk.Click += new System.EventHandler(this.buttonBeoordelingOk_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 317);
            this.Controls.Add(this.buttonBeoordelingOk);
            this.Controls.Add(this.labelBeoordelingTekst);
            this.Controls.Add(this.cijferTextBox);
            this.Controls.Add(this.beoordelingTextBox);
            this.Controls.Add(this.labelCijfer);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beoordelingTextBox;
        private System.Windows.Forms.Label labelBeoordelingTekst;
        private System.Windows.Forms.Label labelCijfer;
        private System.Windows.Forms.TextBox cijferTextBox;
        private System.Windows.Forms.Button buttonBeoordelingOk;
    }
}