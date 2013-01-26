namespace Case2Project
{
    partial class Form5
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
            this.aanpassingenGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.comboBoxSpeloptie = new System.Windows.Forms.ComboBox();
            this.labelLeeftijd = new System.Windows.Forms.Label();
            this.labelSpeloptie = new System.Windows.Forms.Label();
            this.labelPrijs = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.aanpassingenOkButton = new System.Windows.Forms.Button();
            this.textBoxLeeftijd = new System.Windows.Forms.TextBox();
            this.textBoxPrijs = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.labelGenres = new System.Windows.Forms.Label();
            this.aanpassingenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aanpassingenGroupBox
            // 
            this.aanpassingenGroupBox.Controls.Add(this.labelGenres);
            this.aanpassingenGroupBox.Controls.Add(this.buttonGenre);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxGenre);
            this.aanpassingenGroupBox.Controls.Add(this.comboBoxSpeloptie);
            this.aanpassingenGroupBox.Controls.Add(this.labelLeeftijd);
            this.aanpassingenGroupBox.Controls.Add(this.labelSpeloptie);
            this.aanpassingenGroupBox.Controls.Add(this.labelPrijs);
            this.aanpassingenGroupBox.Controls.Add(this.labelDatum);
            this.aanpassingenGroupBox.Controls.Add(this.labelGenre);
            this.aanpassingenGroupBox.Controls.Add(this.labelMaker);
            this.aanpassingenGroupBox.Controls.Add(this.labelTitel);
            this.aanpassingenGroupBox.Controls.Add(this.aanpassingenOkButton);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxLeeftijd);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxPrijs);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxDatum);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxMaker);
            this.aanpassingenGroupBox.Controls.Add(this.textBoxTitel);
            this.aanpassingenGroupBox.Location = new System.Drawing.Point(0, 1);
            this.aanpassingenGroupBox.Name = "aanpassingenGroupBox";
            this.aanpassingenGroupBox.Size = new System.Drawing.Size(509, 199);
            this.aanpassingenGroupBox.TabIndex = 0;
            this.aanpassingenGroupBox.TabStop = false;
            this.aanpassingenGroupBox.Text = "Aanpassingen:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(257, 37);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 17;
            // 
            // comboBoxSpeloptie
            // 
            this.comboBoxSpeloptie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeloptie.FormattingEnabled = true;
            this.comboBoxSpeloptie.Items.AddRange(new object[] {
            "Singleplayer",
            "Multiplayer",
            "Single en multiplayer"});
            this.comboBoxSpeloptie.Location = new System.Drawing.Point(139, 140);
            this.comboBoxSpeloptie.Name = "comboBoxSpeloptie";
            this.comboBoxSpeloptie.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSpeloptie.TabIndex = 16;
            // 
            // labelLeeftijd
            // 
            this.labelLeeftijd.AutoSize = true;
            this.labelLeeftijd.Location = new System.Drawing.Point(254, 124);
            this.labelLeeftijd.Name = "labelLeeftijd";
            this.labelLeeftijd.Size = new System.Drawing.Size(44, 13);
            this.labelLeeftijd.TabIndex = 14;
            this.labelLeeftijd.Text = "Leeftijd:";
            // 
            // labelSpeloptie
            // 
            this.labelSpeloptie.AutoSize = true;
            this.labelSpeloptie.Location = new System.Drawing.Point(136, 124);
            this.labelSpeloptie.Name = "labelSpeloptie";
            this.labelSpeloptie.Size = new System.Drawing.Size(54, 13);
            this.labelSpeloptie.TabIndex = 13;
            this.labelSpeloptie.Text = "Speloptie:";
            // 
            // labelPrijs
            // 
            this.labelPrijs.AutoSize = true;
            this.labelPrijs.Location = new System.Drawing.Point(18, 124);
            this.labelPrijs.Name = "labelPrijs";
            this.labelPrijs.Size = new System.Drawing.Size(29, 13);
            this.labelPrijs.TabIndex = 12;
            this.labelPrijs.Text = "Prijs:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(372, 21);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(41, 13);
            this.labelDatum.TabIndex = 11;
            this.labelDatum.Text = "Datum:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(254, 21);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 10;
            this.labelGenre.Text = "Genre:";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Location = new System.Drawing.Point(136, 21);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(40, 13);
            this.labelMaker.TabIndex = 9;
            this.labelMaker.Text = "Maker:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(18, 21);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(30, 13);
            this.labelTitel.TabIndex = 8;
            this.labelTitel.Text = "Titel:";
            // 
            // aanpassingenOkButton
            // 
            this.aanpassingenOkButton.Location = new System.Drawing.Point(388, 137);
            this.aanpassingenOkButton.Name = "aanpassingenOkButton";
            this.aanpassingenOkButton.Size = new System.Drawing.Size(75, 23);
            this.aanpassingenOkButton.TabIndex = 7;
            this.aanpassingenOkButton.Text = "Ok";
            this.aanpassingenOkButton.UseVisualStyleBackColor = true;
            this.aanpassingenOkButton.Click += new System.EventHandler(this.aanpassingenOkButton_Click);
            // 
            // textBoxLeeftijd
            // 
            this.textBoxLeeftijd.Location = new System.Drawing.Point(257, 140);
            this.textBoxLeeftijd.Name = "textBoxLeeftijd";
            this.textBoxLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeeftijd.TabIndex = 6;
            // 
            // textBoxPrijs
            // 
            this.textBoxPrijs.Location = new System.Drawing.Point(21, 140);
            this.textBoxPrijs.Name = "textBoxPrijs";
            this.textBoxPrijs.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrijs.TabIndex = 4;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(375, 37);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatum.TabIndex = 3;
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Location = new System.Drawing.Point(139, 37);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaker.TabIndex = 1;
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(21, 37);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitel.TabIndex = 0;
            // 
            // buttonGenre
            // 
            this.buttonGenre.Location = new System.Drawing.Point(285, 63);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(40, 23);
            this.buttonGenre.TabIndex = 18;
            this.buttonGenre.Text = "Ok";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Location = new System.Drawing.Point(344, 21);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(13, 13);
            this.labelGenres.TabIndex = 19;
            this.labelGenres.Text = "0";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 201);
            this.Controls.Add(this.aanpassingenGroupBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.aanpassingenGroupBox.ResumeLayout(false);
            this.aanpassingenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aanpassingenGroupBox;
        private System.Windows.Forms.ComboBox comboBoxSpeloptie;
        private System.Windows.Forms.Label labelLeeftijd;
        private System.Windows.Forms.Label labelSpeloptie;
        private System.Windows.Forms.Label labelPrijs;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button aanpassingenOkButton;
        private System.Windows.Forms.TextBox textBoxLeeftijd;
        private System.Windows.Forms.TextBox textBoxPrijs;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Button buttonGenre;
    }
}