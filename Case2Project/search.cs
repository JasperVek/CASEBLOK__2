using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Case2Project
{
    public class search
    {
        public void searchall(DataGridView dataGridView)
        {
            string command;
            DataTable dataTable = new DataTable();

            try
            {
                command = "SELECT * FROM GAME";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, Inloggen.connectionstring);
                dataTable.Clear();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        public void searchSpecific(string genre, string tekst, DataGridView dataGridView)
        {
            string command;
            DataTable dataTable = new DataTable();

            try
            {
                command = "SELECT * FROM GAME WHERE " + genre + " = '" +
                        tekst + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, Inloggen.connectionstring);
                dataTable.Clear();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        public void genreSpeloptie(DataGridView GridviewGenre, DataGridView GridviewSpeloptie)
        {
            string command;
            string command2;
            string command3;
            string command4;
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            DataTable dataTable3 = new DataTable();
            DataTable dataTable4 = new DataTable();

            try
            {
                // genre:
                command = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '"
                    + Bibliotheek.gamenr + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, Inloggen.connectionstring);
                dataTable.Clear();
                adapter.Fill(dataTable);

                command2 = "SELECT genre FROM GENRE WHERE genrenr ='" + dataTable.Rows[0][0] + "'";
                for (int i = 1; i < dataTable.Rows.Count; i++)
                {
                    command2 += "OR genrenr ='" + dataTable.Rows[i][0] + "'";
                }
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter2.Fill(dataTable2);
                GridviewGenre.DataSource = dataTable2;

                // speloptie
                command3 = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '"
                    + Bibliotheek.gamenr + "'";
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(command3, Inloggen.connectionstring);
                dataTable3.Clear();
                adapter3.Fill(dataTable3);

                command4 = "SELECT speloptie FROM SPELOPTIE WHERE speloptienr ='" + dataTable3.Rows[0][0] + "'";
                for (int i = 1; i < dataTable3.Rows.Count; i++)
                {
                    command4 += "OR speloptienr ='" + dataTable3.Rows[i][0] + "'";
                }
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(command4, Inloggen.connectionstring);
                dataTable4.Clear();
                adapter4.Fill(dataTable4);
                GridviewSpeloptie.DataSource = dataTable4; 
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        public void beoordeling(DataGridView GridviewBeoordeling)
        {
            string command;
            DataTable dataTable = new DataTable();

            try
            {
                command = "SELECT gebruikernr, beoordeling, beoordelingscijfer FROM GAME_BEOORDELING WHERE gamenr = '"
                    + Bibliotheek.gamenr + "' AND gebruikernr = '" + Inloggen.gebruikerNaam + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, Inloggen.connectionstring);
                dataTable.Clear();
                adapter.Fill(dataTable);
                GridviewBeoordeling.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
