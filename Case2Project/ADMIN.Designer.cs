namespace Case2Project
{
    partial class ADMIN
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
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.adminZoekTekstBox = new System.Windows.Forms.TextBox();
            this.labelZoek = new System.Windows.Forms.Label();
            this.buttonAdminZoek = new System.Windows.Forms.Button();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttonBewerken = new System.Windows.Forms.Button();
            this.buttonVerwijderen = new System.Windows.Forms.Button();
            this.buttonUserDatabase = new System.Windows.Forms.Button();
            this.labelUserDatabase = new System.Windows.Forms.Label();
            this.labelGameDatabase = new System.Windows.Forms.Label();
            this.buttonGameDatabase = new System.Windows.Forms.Button();
            this.gamedatabaseLabel = new System.Windows.Forms.Label();
            this.userdatabaseLabel = new System.Windows.Forms.Label();
            this.adminAllButton = new System.Windows.Forms.Button();
            this.adminDataGridViewSpeloptie = new System.Windows.Forms.DataGridView();
            this.adminDataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.adminComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridViewSpeloptie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridViewGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Location = new System.Drawing.Point(12, 72);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(500, 191);
            this.adminDataGridView.TabIndex = 0;
            this.adminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDataGridView_CellClick);
            // 
            // adminZoekTekstBox
            // 
            this.adminZoekTekstBox.Location = new System.Drawing.Point(12, 45);
            this.adminZoekTekstBox.Name = "adminZoekTekstBox";
            this.adminZoekTekstBox.Size = new System.Drawing.Size(100, 20);
            this.adminZoekTekstBox.TabIndex = 1;
            // 
            // labelZoek
            // 
            this.labelZoek.AutoSize = true;
            this.labelZoek.Location = new System.Drawing.Point(12, 29);
            this.labelZoek.Name = "labelZoek";
            this.labelZoek.Size = new System.Drawing.Size(35, 13);
            this.labelZoek.TabIndex = 2;
            this.labelZoek.Text = "Zoek:";
            // 
            // buttonAdminZoek
            // 
            this.buttonAdminZoek.Location = new System.Drawing.Point(140, 43);
            this.buttonAdminZoek.Name = "buttonAdminZoek";
            this.buttonAdminZoek.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminZoek.TabIndex = 3;
            this.buttonAdminZoek.Text = "Ok";
            this.buttonAdminZoek.UseVisualStyleBackColor = true;
            this.buttonAdminZoek.Click += new System.EventHandler(this.buttonAdminZoek_Click);
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(86, 327);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonToevoegen.TabIndex = 4;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // buttonBewerken
            // 
            this.buttonBewerken.Location = new System.Drawing.Point(218, 327);
            this.buttonBewerken.Name = "buttonBewerken";
            this.buttonBewerken.Size = new System.Drawing.Size(75, 23);
            this.buttonBewerken.TabIndex = 5;
            this.buttonBewerken.Text = "Bewerken";
            this.buttonBewerken.UseVisualStyleBackColor = true;
            this.buttonBewerken.Click += new System.EventHandler(this.buttonBewerken_Click);
            // 
            // buttonVerwijderen
            // 
            this.buttonVerwijderen.Location = new System.Drawing.Point(350, 327);
            this.buttonVerwijderen.Name = "buttonVerwijderen";
            this.buttonVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.buttonVerwijderen.TabIndex = 6;
            this.buttonVerwijderen.Text = "Verwijderen";
            this.buttonVerwijderen.UseVisualStyleBackColor = true;
            this.buttonVerwijderen.Click += new System.EventHandler(this.buttonVerwijderen_Click);
            // 
            // buttonUserDatabase
            // 
            this.buttonUserDatabase.Location = new System.Drawing.Point(218, 396);
            this.buttonUserDatabase.Name = "buttonUserDatabase";
            this.buttonUserDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonUserDatabase.TabIndex = 7;
            this.buttonUserDatabase.Text = "Ok";
            this.buttonUserDatabase.UseVisualStyleBackColor = true;
            this.buttonUserDatabase.Click += new System.EventHandler(this.buttonUserDatabase_Click);
            // 
            // labelUserDatabase
            // 
            this.labelUserDatabase.AutoSize = true;
            this.labelUserDatabase.Location = new System.Drawing.Point(100, 401);
            this.labelUserDatabase.Name = "labelUserDatabase";
            this.labelUserDatabase.Size = new System.Drawing.Size(106, 13);
            this.labelUserDatabase.TabIndex = 8;
            this.labelUserDatabase.Text = "Open user database:";
            // 
            // labelGameDatabase
            // 
            this.labelGameDatabase.AutoSize = true;
            this.labelGameDatabase.Location = new System.Drawing.Point(100, 367);
            this.labelGameDatabase.Name = "labelGameDatabase";
            this.labelGameDatabase.Size = new System.Drawing.Size(112, 13);
            this.labelGameDatabase.TabIndex = 9;
            this.labelGameDatabase.Text = "Open game database:";
            // 
            // buttonGameDatabase
            // 
            this.buttonGameDatabase.Location = new System.Drawing.Point(218, 362);
            this.buttonGameDatabase.Name = "buttonGameDatabase";
            this.buttonGameDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonGameDatabase.TabIndex = 10;
            this.buttonGameDatabase.Text = "Ok";
            this.buttonGameDatabase.UseVisualStyleBackColor = true;
            this.buttonGameDatabase.Click += new System.EventHandler(this.buttonGameDatabase_Click);
            // 
            // gamedatabaseLabel
            // 
            this.gamedatabaseLabel.AutoSize = true;
            this.gamedatabaseLabel.Location = new System.Drawing.Point(347, 362);
            this.gamedatabaseLabel.Name = "gamedatabaseLabel";
            this.gamedatabaseLabel.Size = new System.Drawing.Size(0, 13);
            this.gamedatabaseLabel.TabIndex = 11;
            // 
            // userdatabaseLabel
            // 
            this.userdatabaseLabel.AutoSize = true;
            this.userdatabaseLabel.Location = new System.Drawing.Point(347, 406);
            this.userdatabaseLabel.Name = "userdatabaseLabel";
            this.userdatabaseLabel.Size = new System.Drawing.Size(0, 13);
            this.userdatabaseLabel.TabIndex = 12;
            // 
            // adminAllButton
            // 
            this.adminAllButton.Location = new System.Drawing.Point(270, 45);
            this.adminAllButton.Name = "adminAllButton";
            this.adminAllButton.Size = new System.Drawing.Size(75, 23);
            this.adminAllButton.TabIndex = 13;
            this.adminAllButton.Text = "Alle info";
            this.adminAllButton.UseVisualStyleBackColor = true;
            this.adminAllButton.Click += new System.EventHandler(this.adminAllButton_Click_1);
            // 
            // adminDataGridViewSpeloptie
            // 
            this.adminDataGridViewSpeloptie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridViewSpeloptie.Location = new System.Drawing.Point(12, 269);
            this.adminDataGridViewSpeloptie.Name = "adminDataGridViewSpeloptie";
            this.adminDataGridViewSpeloptie.Size = new System.Drawing.Size(237, 52);
            this.adminDataGridViewSpeloptie.TabIndex = 14;
            // 
            // adminDataGridViewGenre
            // 
            this.adminDataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridViewGenre.Location = new System.Drawing.Point(270, 269);
            this.adminDataGridViewGenre.Name = "adminDataGridViewGenre";
            this.adminDataGridViewGenre.Size = new System.Drawing.Size(242, 52);
            this.adminDataGridViewGenre.TabIndex = 15;
            // 
            // adminComboBox
            // 
            this.adminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminComboBox.FormattingEnabled = true;
            this.adminComboBox.Items.AddRange(new object[] {
            "Titel",
            "Maker",
            "Prijs",
            "Leeftijd",
            "Datum"});
            this.adminComboBox.Location = new System.Drawing.Point(12, 5);
            this.adminComboBox.Name = "adminComboBox";
            this.adminComboBox.Size = new System.Drawing.Size(121, 21);
            this.adminComboBox.TabIndex = 16;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 433);
            this.Controls.Add(this.adminComboBox);
            this.Controls.Add(this.adminDataGridViewGenre);
            this.Controls.Add(this.adminDataGridViewSpeloptie);
            this.Controls.Add(this.adminAllButton);
            this.Controls.Add(this.userdatabaseLabel);
            this.Controls.Add(this.gamedatabaseLabel);
            this.Controls.Add(this.buttonGameDatabase);
            this.Controls.Add(this.labelGameDatabase);
            this.Controls.Add(this.labelUserDatabase);
            this.Controls.Add(this.buttonUserDatabase);
            this.Controls.Add(this.buttonVerwijderen);
            this.Controls.Add(this.buttonBewerken);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.buttonAdminZoek);
            this.Controls.Add(this.labelZoek);
            this.Controls.Add(this.adminZoekTekstBox);
            this.Controls.Add(this.adminDataGridView);
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridViewSpeloptie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridViewGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.TextBox adminZoekTekstBox;
        private System.Windows.Forms.Label labelZoek;
        private System.Windows.Forms.Button buttonAdminZoek;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttonBewerken;
        private System.Windows.Forms.Button buttonVerwijderen;
        private System.Windows.Forms.Button buttonUserDatabase;
        private System.Windows.Forms.Label labelUserDatabase;
        private System.Windows.Forms.Label labelGameDatabase;
        private System.Windows.Forms.Button buttonGameDatabase;
        private System.Windows.Forms.Label gamedatabaseLabel;
        private System.Windows.Forms.Label userdatabaseLabel;
        private System.Windows.Forms.Button adminAllButton;
        private System.Windows.Forms.DataGridView adminDataGridViewSpeloptie;
        private System.Windows.Forms.DataGridView adminDataGridViewGenre;
        private System.Windows.Forms.ComboBox adminComboBox;
    }
}