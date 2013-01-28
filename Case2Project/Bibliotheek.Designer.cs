namespace Case2Project
{
    partial class Bibliotheek
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
            this.zoekDatabaseTextbox = new System.Windows.Forms.TextBox();
            this.zoekDatabaseButton = new System.Windows.Forms.Button();
            this.zoekDatabaseGenreTextbox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.speloptieDataGridView = new System.Windows.Forms.DataGridView();
            this.algemeneDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.beoordelingDataGridView = new System.Windows.Forms.DataGridView();
            this.maakBeoordelingButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.buttonAllGames = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speloptieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algemeneDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beoordelingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zoekDatabaseTextbox
            // 
            this.zoekDatabaseTextbox.Location = new System.Drawing.Point(12, 33);
            this.zoekDatabaseTextbox.Name = "zoekDatabaseTextbox";
            this.zoekDatabaseTextbox.Size = new System.Drawing.Size(170, 20);
            this.zoekDatabaseTextbox.TabIndex = 0;
            // 
            // zoekDatabaseButton
            // 
            this.zoekDatabaseButton.Location = new System.Drawing.Point(203, 31);
            this.zoekDatabaseButton.Name = "zoekDatabaseButton";
            this.zoekDatabaseButton.Size = new System.Drawing.Size(54, 23);
            this.zoekDatabaseButton.TabIndex = 1;
            this.zoekDatabaseButton.Text = "Zoek";
            this.zoekDatabaseButton.UseVisualStyleBackColor = true;
            this.zoekDatabaseButton.Click += new System.EventHandler(this.zoekDatabaseButton_Click);
            // 
            // zoekDatabaseGenreTextbox
            // 
            this.zoekDatabaseGenreTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoekDatabaseGenreTextbox.FormattingEnabled = true;
            this.zoekDatabaseGenreTextbox.Items.AddRange(new object[] {
            "Titel",
            "Maker",
            "Prijs",
            "Leeftijd",
            "Datum"});
            this.zoekDatabaseGenreTextbox.Location = new System.Drawing.Point(12, 3);
            this.zoekDatabaseGenreTextbox.Name = "zoekDatabaseGenreTextbox";
            this.zoekDatabaseGenreTextbox.Size = new System.Drawing.Size(151, 21);
            this.zoekDatabaseGenreTextbox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genreDataGridView);
            this.groupBox1.Controls.Add(this.speloptieDataGridView);
            this.groupBox1.Controls.Add(this.algemeneDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AllowUserToAddRows = false;
            this.genreDataGridView.AllowUserToDeleteRows = false;
            this.genreDataGridView.AllowUserToResizeColumns = false;
            this.genreDataGridView.AllowUserToResizeRows = false;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Location = new System.Drawing.Point(205, 239);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.ReadOnly = true;
            this.genreDataGridView.Size = new System.Drawing.Size(188, 52);
            this.genreDataGridView.TabIndex = 6;
            // 
            // speloptieDataGridView
            // 
            this.speloptieDataGridView.AllowUserToAddRows = false;
            this.speloptieDataGridView.AllowUserToDeleteRows = false;
            this.speloptieDataGridView.AllowUserToResizeColumns = false;
            this.speloptieDataGridView.AllowUserToResizeRows = false;
            this.speloptieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.speloptieDataGridView.Location = new System.Drawing.Point(6, 239);
            this.speloptieDataGridView.Name = "speloptieDataGridView";
            this.speloptieDataGridView.ReadOnly = true;
            this.speloptieDataGridView.Size = new System.Drawing.Size(193, 52);
            this.speloptieDataGridView.TabIndex = 5;
            // 
            // algemeneDataGridView
            // 
            this.algemeneDataGridView.AllowUserToAddRows = false;
            this.algemeneDataGridView.AllowUserToDeleteRows = false;
            this.algemeneDataGridView.AllowUserToResizeColumns = false;
            this.algemeneDataGridView.AllowUserToResizeRows = false;
            this.algemeneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.algemeneDataGridView.Location = new System.Drawing.Point(6, 10);
            this.algemeneDataGridView.Name = "algemeneDataGridView";
            this.algemeneDataGridView.ReadOnly = true;
            this.algemeneDataGridView.Size = new System.Drawing.Size(387, 223);
            this.algemeneDataGridView.TabIndex = 4;
            this.algemeneDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.algemeneDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.beoordelingDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(417, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 252);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // beoordelingDataGridView
            // 
            this.beoordelingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beoordelingDataGridView.Location = new System.Drawing.Point(6, 10);
            this.beoordelingDataGridView.Name = "beoordelingDataGridView";
            this.beoordelingDataGridView.Size = new System.Drawing.Size(271, 233);
            this.beoordelingDataGridView.TabIndex = 5;
            // 
            // maakBeoordelingButton
            // 
            this.maakBeoordelingButton.Location = new System.Drawing.Point(417, 71);
            this.maakBeoordelingButton.Name = "maakBeoordelingButton";
            this.maakBeoordelingButton.Size = new System.Drawing.Size(120, 23);
            this.maakBeoordelingButton.TabIndex = 0;
            this.maakBeoordelingButton.Text = "Maak Beoordeling";
            this.maakBeoordelingButton.UseVisualStyleBackColor = true;
            this.maakBeoordelingButton.Click += new System.EventHandler(this.maakBeoordelingButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(635, 12);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "ADMIN";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // buttonAllGames
            // 
            this.buttonAllGames.Location = new System.Drawing.Point(290, 31);
            this.buttonAllGames.Name = "buttonAllGames";
            this.buttonAllGames.Size = new System.Drawing.Size(96, 23);
            this.buttonAllGames.TabIndex = 4;
            this.buttonAllGames.Text = "Geef alle spellen";
            this.buttonAllGames.UseVisualStyleBackColor = true;
            this.buttonAllGames.Click += new System.EventHandler(this.buttonAllGames_Click);
            // 
            // Bibliotheek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 383);
            this.Controls.Add(this.buttonAllGames);
            this.Controls.Add(this.maakBeoordelingButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zoekDatabaseGenreTextbox);
            this.Controls.Add(this.zoekDatabaseButton);
            this.Controls.Add(this.zoekDatabaseTextbox);
            this.Name = "Bibliotheek";
            this.Text = "Bibliotheek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speloptieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algemeneDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beoordelingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zoekDatabaseTextbox;
        private System.Windows.Forms.Button zoekDatabaseButton;
        private System.Windows.Forms.ComboBox zoekDatabaseGenreTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button maakBeoordelingButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.DataGridView algemeneDataGridView;
        private System.Windows.Forms.DataGridView beoordelingDataGridView;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.DataGridView speloptieDataGridView;
        private System.Windows.Forms.Button buttonAllGames;
    }
}