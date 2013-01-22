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
    public partial class Form4 : Form
    {
        private string connectionstring = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;" +
            @"Data Source=|DataDirectory|\GAMES.sdf";

        public Form4()
        {
            InitializeComponent();
        }
        public static bool aanpassing = false;

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            if (gamedatabaseLabel.Text == "selected")
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            // naar form5 en die gegevens daar in een query laten toevoegen
        }

        private void buttonBewerken_Click(object sender, EventArgs e)
        {
            if (gamedatabaseLabel.Text == "selected")
            {
                Form5 form5 = new Form5();
                aanpassing = true;
                form5.Show();
            }

           // gamenr meegeven en naar form5 gaan, daar de gegevens die al erin staan ( alles ) ophalen met een select via het gamenr
            // en dan met alter query op form5
         
        }

        private void buttonVerwijderen_Click(object sender, EventArgs e)
        {

            
            if (gamedatabaseLabel.Text == "selected")
            {

                OleDbConnection connection = new OleDbConnection(connectionstring);
                DataTable table = new DataTable();
                OleDbCommand dropCommand = new OleDbCommand();

                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                string command = "DELETE FROM GAME WHERE gamenr = '"
                    + gamenr + "'";

                dropCommand.CommandText = command;
                dropCommand.Connection = connection;
                adapter.DeleteCommand = dropCommand;

                adapter.DeleteCommand.ExecuteNonQuery();
                connection.Close();
            }

            else
            {

                if (gebruikersnr == "1")
                {
                    MessageBox.Show("You will never kill me!");
                }
                else
                {

                    OleDbConnection connection = new OleDbConnection(connectionstring);
                    DataTable table = new DataTable();
                    OleDbCommand dropCommand = new OleDbCommand();

                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    string command = "DELETE FROM LOGIN WHERE gebruikernr = '"
                        + gebruikersnr + "'";

                    dropCommand.CommandText = command;
                    dropCommand.Connection = connection;
                    adapter.DeleteCommand = dropCommand;

                    adapter.DeleteCommand.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        private void buttonGameDatabase_Click(object sender, EventArgs e)
        {
            gamedatabaseLabel.Text = "selected";
            userdatabaseLabel.Text = "";
            // nog dat de datagridview wordt gecleared
        }

        private void buttonUserDatabase_Click(object sender, EventArgs e)
        {
            userdatabaseLabel.Text = "selected";
            gamedatabaseLabel.Text = "";
            DataTable table = new DataTable();
            adminDataGridViewGenre.DataSource = table;
            adminDataGridViewSpeloptie.DataSource = table;
            // zelfde
        }

        private void buttonAdminZoek_Click(object sender, EventArgs e)
        {
            if (userdatabaseLabel.Text == "selected")
            {// userdatabase open

                string command;
                DataTable dataTable = new DataTable();

                try
                {
                    command = "SELECT * FROM GAME WHERE " + adminZoekTekstBox.Text + " = '" +
                            adminZoekTekstBox.Text + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionstring);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    adminDataGridView.DataSource = dataTable;
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
            }

            else
            {//gamedatabase open

                string command;
                DataTable dataTable = new DataTable();

                try
                {
                    command = "SELECT * FROM LOGIN WHERE " + adminZoekTekstBox.Text + " = '" +
                            adminZoekTekstBox.Text + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionstring);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    adminDataGridView.DataSource = dataTable;
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
            }
        }

        private void adminAllButton_Click_1(object sender, EventArgs e)
        {
            if (gamedatabaseLabel.Text == "selected")
            {
                string command;
                DataTable dataTable = new DataTable();

                try
                {
                    command = "SELECT * FROM GAME";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionstring);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    adminDataGridView.DataSource = dataTable;
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
            }

            else
            {

                string command;
                DataTable dataTable = new DataTable();

                try
                {
                    command = "SELECT * FROM LOGIN";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionstring);
                    dataTable.Clear();
                    adapter.Fill(dataTable);
                    adminDataGridView.DataSource = dataTable;
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
            }
        }

        private string gebruikersnr;
        private string gamenr;

        private void adminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gamedatabaseLabel.Text == "selected")
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
                    // genre
                    gamenr = adminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    command = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '"
                        + gamenr + "'";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionstring);
                    dataTable.Clear();
                    adapter.Fill(dataTable);

                    command2 = "SELECT genre FROM GENRE WHERE genrenr ='" + dataTable.Rows[0][0] + "'";
                    for (int i = 1; i < dataTable.Rows.Count; i++)
                    {
                        command2 += "OR genrenr ='" + dataTable.Rows[i][0] + "'";
                    }
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2, connectionstring);
                    dataTable2.Clear();
                    adapter2.Fill(dataTable2);
                    adminDataGridViewGenre.DataSource = dataTable2;

                    //2de gedeelte voor spelopties
                    command3 = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '"
                        + gamenr + "'";
                    OleDbDataAdapter adapter3 = new OleDbDataAdapter(command3, connectionstring);
                    dataTable3.Clear();
                    adapter3.Fill(dataTable3);

                    command4 = "SELECT speloptie FROM SPELOPTIE WHERE speloptienr ='" + dataTable3.Rows[0][0] + "'";
                    for (int i = 1; i < dataTable3.Rows.Count; i++)
                    {
                        command4 += "OR speloptienr ='" + dataTable3.Rows[i][0] + "'";
                    }
                    OleDbDataAdapter adapter4 = new OleDbDataAdapter(command4, connectionstring);
                    dataTable4.Clear();
                    adapter4.Fill(dataTable4);
                    adminDataGridViewSpeloptie.DataSource = dataTable4; 
                }

                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
            }
            else
            {
                 gebruikersnr = adminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
    

