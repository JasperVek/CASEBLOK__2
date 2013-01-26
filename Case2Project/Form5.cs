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
    public partial class Form5 : Form
    {
        private string connectionstring = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;" +
            @"Data Source=|DataDirectory|\GAMES.sdf";

        public Form5()
        {
            InitializeComponent();

            if (Form4.aanpassing == true)
            {
                // titel
                string commandTitel = "SELECT titel FROM GAME WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableTitel = new DataTable();
                OleDbDataAdapter adapterTitel = new OleDbDataAdapter(commandTitel, Form1.connectionstring);
                dataTableTitel.Clear();
                adapterTitel.Fill(dataTableTitel);
                textBoxTitel.Text = dataTableTitel.Rows[0][0].ToString();

                //maker
                string commandMaker = "SELECT maker FROM GAME WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableMaker = new DataTable();
                OleDbDataAdapter adapterMaker = new OleDbDataAdapter(commandMaker, Form1.connectionstring);
                dataTableMaker.Clear();
                adapterMaker.Fill(dataTableMaker);
                textBoxMaker.Text = dataTableMaker.Rows[0][0].ToString();

                //prijs
                string commandPrijs = "SELECT prijs FROM GAME WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTablePrijs = new DataTable();
                OleDbDataAdapter adapterPrijs = new OleDbDataAdapter(commandPrijs, Form1.connectionstring);
                dataTablePrijs.Clear();
                adapterPrijs.Fill(dataTablePrijs);
                textBoxPrijs.Text = dataTablePrijs.Rows[0][0].ToString();

                //leeftijd
                string commandLeeftijd = "SELECT leeftijd FROM GAME WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableLeeftijd = new DataTable();
                OleDbDataAdapter adapterLeeftijd = new OleDbDataAdapter(commandLeeftijd, Form1.connectionstring);
                dataTableLeeftijd.Clear();
                adapterLeeftijd.Fill(dataTableLeeftijd);
                textBoxLeeftijd.Text = dataTableLeeftijd.Rows[0][0].ToString();

                //datum
                string commandDatum = "SELECT datum FROM GAME WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableDatum = new DataTable();
                OleDbDataAdapter adapterDatum = new OleDbDataAdapter(commandDatum, Form1.connectionstring);
                dataTableDatum.Clear();
                adapterDatum.Fill(dataTableDatum);
                textBoxDatum.Text = dataTableDatum.Rows[0][0].ToString();

                //genre
                string commandGenrenr = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableGenrenr = new DataTable();
                OleDbDataAdapter adapterGenrenr = new OleDbDataAdapter(commandGenrenr, Form1.connectionstring);
                dataTableGenrenr.Clear();
                adapterGenrenr.Fill(dataTableGenrenr);

                string commandGenre = "SELECT genre FROM GENRE WHERE genrenr = '"
                    + dataTableGenrenr.Rows[0][0].ToString() + "'";
                DataTable dataTableGenre = new DataTable();
                OleDbDataAdapter adapterGenre = new OleDbDataAdapter(commandGenre, Form1.connectionstring);
                dataTableGenre.Clear();
                adapterGenre.Fill(dataTableGenre);
                textBoxGenre.Text = dataTableGenre.Rows[0][0].ToString();

                //speloptie
                string commandSpeloptienr = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '" + Form4.adminGamenr + "'";
                DataTable dataTableSpeloptienr = new DataTable();
                OleDbDataAdapter adapterSpeloptienr = new OleDbDataAdapter(commandSpeloptienr, Form1.connectionstring);
                dataTableSpeloptienr.Clear();
                adapterSpeloptienr.Fill(dataTableSpeloptienr);

                string commandSpeloptie = "SELECT speloptie FROM SPELOPTIE WHERE speloptienr = '"
                    + dataTableSpeloptienr.Rows[0][0].ToString() + "'";
                DataTable dataTableSpeloptie = new DataTable();
                OleDbDataAdapter adapterSpeloptie = new OleDbDataAdapter(commandSpeloptie, Form1.connectionstring);
                dataTableSpeloptie.Clear();
                adapterSpeloptie.Fill(dataTableSpeloptie);
                comboBoxSpeloptie.Text = dataTableSpeloptie.Rows[0][0].ToString();
            }
        }

       
        public string gamenrreturn, genrenrreturn;
        public DataTable tableSpeloptienr = new DataTable();

        private void returnMethodeSpeloptienr()
        {
            string command2;
            if (comboBoxSpeloptie.Text == "Single en multiplayer")
            {
                command2 = "SELECT speloptienr FROM SPELOPTIE WHERE speloptie = 'Singleplayer' OR speloptie = 'Multiplayer'";
            }
            else
            {
                command2 = "SELECT speloptienr FROM SPELOPTIE WHERE speloptie = '" + comboBoxSpeloptie.Text + "'";
            }
            
            OleDbDataAdapter adapter = new OleDbDataAdapter(command2, Form1.connectionstring);
            tableSpeloptienr.Clear();
            adapter.Fill(tableSpeloptienr);
            MessageBox.Show(tableSpeloptienr.ToString());
        }

        private void returnMethodeGenrenr()
        {
            string command2;
            
            command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + textBoxGenre.Text +"'";
            DataTable dataTable = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command2, Form1.connectionstring);
            dataTable.Clear();
            adapter.Fill(dataTable);

            genrenrreturn = dataTable.Rows[0][0].ToString();
        }

        private void returnMethodeGamenr()
        {
            string command3;

            command3 = "SELECT gamenr FROM GAME WHERE titel = '" + textBoxTitel.Text + "'";
            DataTable dataTable = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command3, Form1.connectionstring);
            dataTable.Clear();
            adapter.Fill(dataTable);

            gamenrreturn = dataTable.Rows[0][0].ToString();
        } 


        private void aanpassingenOkButton_Click(object sender, EventArgs e)
        {
            // spelopties van deze actie
            string spelopties = comboBoxSpeloptie.Text;
            // genre van deze actie
            string genre = textBoxGenre.Text;

            if (Form4.aanpassing == true)
            {
                OleDbConnection connection = new OleDbConnection(connectionstring);
                OleDbCommand updateCommand = new OleDbCommand();

                connection.Open();
                //spel zelf
                OleDbDataAdapter adapterGame = new OleDbDataAdapter();
                string command = "UPDATE GAME SET titel = '" + textBoxTitel.Text + "', maker = '" +
                    textBoxMaker.Text + "', prijs = '" + Convert.ToInt32(textBoxPrijs.Text) +
                    "', leeftijd = '" + Convert.ToInt32(textBoxLeeftijd.Text) + "', datum = '" +
                    textBoxDatum.Text + "' WHERE gamenr = '" + Form4.adminGamenr + "'";

                updateCommand.CommandText = command;
                updateCommand.Connection = connection;
                adapterGame.UpdateCommand = updateCommand;
                adapterGame.UpdateCommand.ExecuteNonQuery();

                //genre
                DataTable dataTableGenrenr = new DataTable();
                string commandGenrenr = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '" + Form4.adminGamenr + "'";
                OleDbDataAdapter adapterGenrenr = new OleDbDataAdapter(commandGenrenr, Form1.connectionstring);
                dataTableGenrenr.Clear();
                adapterGenrenr.Fill(dataTableGenrenr);

                OleDbDataAdapter adapterGenre = new OleDbDataAdapter();
                string commandGenre = "UPDATE GENRE SET genre = '" + textBoxGenre.Text + "' WHERE genrenr = '"
                    + dataTableGenrenr.Rows[0][0].ToString() + "'";

                updateCommand.CommandText = commandGenre;
                updateCommand.Connection = connection;
                adapterGenre.UpdateCommand = updateCommand;
                adapterGenre.UpdateCommand.ExecuteNonQuery();

                //speloptie
                DataTable dataTableSpeloptienr = new DataTable();
                string commandSpeloptienr = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '" + Form4.adminGamenr + "'";
                OleDbDataAdapter adapterSpeloptienr = new OleDbDataAdapter(commandSpeloptienr, Form1.connectionstring);
                dataTableSpeloptienr.Clear();
                adapterSpeloptienr.Fill(dataTableSpeloptienr);

                OleDbDataAdapter adapterSpeloptie = new OleDbDataAdapter();
                string commandSpeloptie = "UPDATE SPELOPTIE SET speloptie = '" + comboBoxSpeloptie.Text + 
                    "' WHERE speloptienr = '" + dataTableSpeloptienr.Rows[0][0].ToString() + "'";

                updateCommand.CommandText = commandSpeloptie;
                updateCommand.Connection = connection;
                adapterSpeloptie.UpdateCommand = updateCommand;
                adapterSpeloptie.UpdateCommand.ExecuteNonQuery();

                connection.Close();
                this.Close();
                Form4.aanpassing = false;
            }
            else if (Form4.aanpassing == false)
            {
                OleDbConnection connection = new OleDbConnection(connectionstring);
                OleDbCommand insertCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                OleDbCommand insertCommand2 = new OleDbCommand();
                OleDbDataAdapter adapter2 = new OleDbDataAdapter();

                OleDbCommand insertCommand3 = new OleDbCommand();
                OleDbDataAdapter adapter3 = new OleDbDataAdapter();

                OleDbCommand insertCommand4 = new OleDbCommand();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter();

                OleDbCommand insertCommand5 = new OleDbCommand();
                OleDbDataAdapter adapter5 = new OleDbDataAdapter();

                string commandgamespelopties;
                string commandgamegenre;
                string commandgenre;

                try
                {
                    connection.Open();
                    string command = "INSERT INTO GAME(titel, maker, prijs, leeftijd, datum) VALUES('" +
                        textBoxTitel.Text + "', '" + textBoxMaker.Text + "', '" + Convert.ToInt32(textBoxPrijs.Text) +
                        "', '" + Convert.ToInt32(textBoxLeeftijd.Text) + "', '" + textBoxDatum.Text + "')";

                    // eerste command
                    insertCommand.Connection = connection;
                    insertCommand.CommandText = command;
                    adapter.InsertCommand = insertCommand;
                    adapter.InsertCommand.ExecuteNonQuery();

                    
                    commandgenre = " INSERT INTO GENRE(genre) VALUES('" + genre + "')";

                    insertCommand4.CommandText = commandgenre;
                    insertCommand4.Connection = connection;
                    adapter4.InsertCommand = insertCommand4;
                    adapter4.InsertCommand.ExecuteNonQuery();

                    returnMethodeSpeloptienr();
                    returnMethodeGamenr();
                    returnMethodeGenrenr();

                    for (int i = 0; i < tableSpeloptienr.Rows.Count; i++)
                    {
                        commandgamespelopties = "INSERT INTO GAME_SPELOPTIE(speloptienr, gamenr) VALUES('"
                            + tableSpeloptienr.Rows[i][0] + "', '" + gamenrreturn + "')";

                        insertCommand2.CommandText = commandgamespelopties;
                        insertCommand2.Connection = connection;
                        adapter2.InsertCommand = insertCommand2;
                        adapter2.InsertCommand.ExecuteNonQuery();
                    }

                    commandgamegenre = " INSERT INTO GAME_GENRE(genrenr, gamenr) VALUES('" + genrenrreturn + "', '" +
                        gamenrreturn + "')";

                    insertCommand3.CommandText = commandgamegenre;
                    insertCommand3.Connection = connection;
                    adapter3.InsertCommand = insertCommand3;
                    adapter3.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("GESLAAGD");
                    this.Close();
                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private int genres = 0;
        private string genre1;
        private string genre2;
        private string genre3;
        private string genre4;
        private string genre5;

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            if (genres == 0)
            {
                genre1 = textBoxGenre.Text;
                textBoxGenre.Text = "";
                labelGenres.Text = "1";
            }

            if (genres == 1)
            {
                genre2 = textBoxGenre.Text;
                textBoxGenre.Text = "";
                labelGenres.Text = "2";
            }

            if (genres == 2)
            {
                genre3 = textBoxGenre.Text;
                textBoxGenre.Text = "";
                labelGenres.Text = "3";
            }

            if (genres == 3)
            {
                genre4 = textBoxGenre.Text;
                textBoxGenre.Text = "";
                labelGenres.Text = "4";
            }


            if (genres == 4)
            {
                genre5 = textBoxGenre.Text;
                textBoxGenre.Text = "";
                labelGenres.Text = "5";

            }

            genres++;
        }
    }
}
