using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Case2Project
{
    public partial class Form2 : Form
    {
        public static string gamenr;

        public search search = new search();

        public Form2()
        {
            InitializeComponent();
            if (Form1.admin == true)
            {
                adminButton.Visible = true;
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void maakBeoordelingButton_Click(object sender, EventArgs e)
        {
            // een messagebox maken met ok en cancel voor reactie plaatsen, is netter
            if (gamenr == null)
            {
                MessageBox.Show("Selecteer een spel");
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void buttonAllGames_Click(object sender, EventArgs e)
        {
            search.searchall(algemeneDataGridView);
        }

        private void zoekDatabaseButton_Click(object sender, EventArgs e)
        {
            search.searchSpecific(zoekDatabaseGenreTextbox.Text, zoekDatabaseTextbox.Text, algemeneDataGridView);
        }

        private void algemeneDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gamenr = algemeneDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            search.genreSpeloptie(genreDataGridView, speloptieDataGridView);
            search.beoordeling(beoordelingDataGridView);
            beoordelingDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //sluit de gehele applicatie
        }
    }
}
