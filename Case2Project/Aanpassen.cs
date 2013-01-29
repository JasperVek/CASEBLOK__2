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
    public partial class Aanpassen : Form
    {
        private string connectionstring = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;" +
            @"Data Source=|DataDirectory|\GAMES.sdf";

        public Aanpassen()
        {
            InitializeComponent();

            if (ADMIN.aanpassing == true)
            {
                // titel
                string commandTitel = "SELECT titel FROM GAME WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableTitel = new DataTable();
                OleDbDataAdapter adapterTitel = new OleDbDataAdapter(commandTitel, Inloggen.connectionstring);
                dataTableTitel.Clear();
                adapterTitel.Fill(dataTableTitel);
                textBoxTitel.Text = dataTableTitel.Rows[0][0].ToString();

                //maker
                string commandMaker = "SELECT maker FROM GAME WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableMaker = new DataTable();
                OleDbDataAdapter adapterMaker = new OleDbDataAdapter(commandMaker, Inloggen.connectionstring);
                dataTableMaker.Clear();
                adapterMaker.Fill(dataTableMaker);
                textBoxMaker.Text = dataTableMaker.Rows[0][0].ToString();

                //prijs
                string commandPrijs = "SELECT prijs FROM GAME WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTablePrijs = new DataTable();
                OleDbDataAdapter adapterPrijs = new OleDbDataAdapter(commandPrijs, Inloggen.connectionstring);
                dataTablePrijs.Clear();
                adapterPrijs.Fill(dataTablePrijs);
                textBoxPrijs.Text = dataTablePrijs.Rows[0][0].ToString();

                //leeftijd
                string commandLeeftijd = "SELECT leeftijd FROM GAME WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableLeeftijd = new DataTable();
                OleDbDataAdapter adapterLeeftijd = new OleDbDataAdapter(commandLeeftijd, Inloggen.connectionstring);
                dataTableLeeftijd.Clear();
                adapterLeeftijd.Fill(dataTableLeeftijd);
                textBoxLeeftijd.Text = dataTableLeeftijd.Rows[0][0].ToString();

                //datum
                string commandDatum = "SELECT datum FROM GAME WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableDatum = new DataTable();
                OleDbDataAdapter adapterDatum = new OleDbDataAdapter(commandDatum, Inloggen.connectionstring);
                dataTableDatum.Clear();
                adapterDatum.Fill(dataTableDatum);
                textBoxDatum.Text = dataTableDatum.Rows[0][0].ToString();

                //genre
                string commandGenrenr = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableGenrenr = new DataTable();
                OleDbDataAdapter adapterGenrenr = new OleDbDataAdapter(commandGenrenr, Inloggen.connectionstring);
                dataTableGenrenr.Clear();
                adapterGenrenr.Fill(dataTableGenrenr);

                string commandGenre = "SELECT genre FROM GENRE WHERE genrenr = '"
                    + dataTableGenrenr.Rows[0][0].ToString() + "'";
                DataTable dataTableGenre = new DataTable();
                OleDbDataAdapter adapterGenre = new OleDbDataAdapter(commandGenre, Inloggen.connectionstring);
                dataTableGenre.Clear();
                adapterGenre.Fill(dataTableGenre);
                textBoxGenre.Text = dataTableGenre.Rows[0][0].ToString();

                //speloptie
                string commandSpeloptienr = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                DataTable dataTableSpeloptienr = new DataTable();
                OleDbDataAdapter adapterSpeloptienr = new OleDbDataAdapter(commandSpeloptienr, Inloggen.connectionstring);
                dataTableSpeloptienr.Clear();
                adapterSpeloptienr.Fill(dataTableSpeloptienr);

                string commandSpeloptie = "SELECT speloptie FROM SPELOPTIE WHERE speloptienr = '"
                    + dataTableSpeloptienr.Rows[0][0].ToString() + "'";
                DataTable dataTableSpeloptie = new DataTable();
                OleDbDataAdapter adapterSpeloptie = new OleDbDataAdapter(commandSpeloptie, Inloggen.connectionstring);
                dataTableSpeloptie.Clear();
                adapterSpeloptie.Fill(dataTableSpeloptie);
                comboBoxSpeloptie.Text = dataTableSpeloptie.Rows[0][0].ToString();
            }
        }

       
        public string gamenrreturn, genrenrreturn;
        public DataTable tableSpeloptienr = new DataTable();

        private void genreInvoer()
        {
            // controleren of genre1,2,3,4,5 er zijn
            // invoer query's maken

            // genre1,2,3,4,5 voorbereiding
            OleDbConnection connection = new OleDbConnection(connectionstring);
            OleDbCommand insertCommandGenre1 = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand insertCommandGenre2 = new OleDbCommand();

            OleDbCommand insertCommandGenre3 = new OleDbCommand();

            OleDbCommand insertCommandGenre4 = new OleDbCommand();

            OleDbCommand insertCommandGenre5 = new OleDbCommand();

            connection.Open();

            if (genre1 != null)
            {
                // controleren van genre1
                string controlecommand1 = "SELECT genre FROM GENRE WHERE genre = '" + genre1 + "'";

                DataTable dataTable = new DataTable();
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(controlecommand1, connection);
                dataTable.Clear();
                adapter2.Fill(dataTable);
                
                if (dataTable.Rows.Count == 0)
                {
                    // genre 1 invoeren
                    string command = "INSERT INTO GENRE(genre) VALUES('" + genre1 + "')";

                    OleDbCommand insertCommandGenreExtra1 = new OleDbCommand();
                    insertCommandGenreExtra1.Connection = connection;
                    insertCommandGenreExtra1.CommandText = command;
                    adapter.InsertCommand = insertCommandGenreExtra1;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                // koppelen genre via gamenr
                string command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + genre1 + "'";
                DataTable dataTable2 = new DataTable();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter4.Fill(dataTable2);

                string genrenrreturn1 = dataTable2.Rows[0][0].ToString();

                string command3 = "INSERT INTO GAME_GENRE(gamenr, genrenr) VALUES('" 
                    + gamenrreturn + "', '" + genrenrreturn1 + "')";

                insertCommandGenre1.Connection = connection;
                insertCommandGenre1.CommandText = command3;
                adapter.InsertCommand = insertCommandGenre1;
                adapter.InsertCommand.ExecuteNonQuery();
            }

            if (genre2 != null)
            {
                // controleren van genre2
                string controlecommand2 = "SELECT genre FROM GENRE WHERE genre = '" + genre2 + "'";

                DataTable dataTable = new DataTable();
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(controlecommand2, Inloggen.connectionstring);
                dataTable.Clear();
                adapter3.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    // genre 2 invoeren
                    string command = "INSERT INTO GENRE(genre) VALUES('" + genre2 + "')";

                    OleDbCommand insertCommandGenreExtra2 = new OleDbCommand();
                    insertCommandGenreExtra2.Connection = connection;
                    insertCommandGenreExtra2.CommandText = command;
                    adapter.InsertCommand = insertCommandGenreExtra2;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                //koppelen genre2
                string command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + genre2 + "'";
                DataTable dataTable2 = new DataTable();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter4.Fill(dataTable2);

                string genrenrreturn2 = dataTable2.Rows[0][0].ToString();

                string command3 = "INSERT INTO GAME_GENRE(gamenr, genrenr) VALUES('" 
                    + gamenrreturn + "', '" + genrenrreturn2 + "')";

                insertCommandGenre2.Connection = connection;
                insertCommandGenre2.CommandText = command3;
                adapter.InsertCommand = insertCommandGenre2;
                adapter.InsertCommand.ExecuteNonQuery();
            }

            if (genre3 != null)
            {
                // controleren van genre3
                string controlecommand3 = "SELECT genre FROM GENRE WHERE genre = '" + genre3 + "'";

                DataTable dataTable = new DataTable();
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(controlecommand3, Inloggen.connectionstring);
                dataTable.Clear();
                adapter3.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    // genre 3 invoeren
                    string command = "INSERT INTO GENRE(genre) VALUES('" + genre3 + "')";

                    OleDbCommand insertCommandGenreExtra3 = new OleDbCommand();
                    insertCommandGenreExtra3.Connection = connection;
                    insertCommandGenreExtra3.CommandText = command;
                    adapter.InsertCommand = insertCommandGenreExtra3;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                string command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + genre3 + "'";
                DataTable dataTable2 = new DataTable();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter4.Fill(dataTable2);

                string genrenrreturn3 = dataTable2.Rows[0][0].ToString();

                string command3 = "INSERT INTO GAME_GENRE(gamenr, genrenr) VALUES('" 
                    + gamenrreturn + "', '" + genrenrreturn3 + "')";

                insertCommandGenre3.Connection = connection;
                insertCommandGenre3.CommandText = command3;
                adapter.InsertCommand = insertCommandGenre3;
                adapter.InsertCommand.ExecuteNonQuery();
            }

            if (genre4 != null)
            {
                // controleren van genre4
                string controlecommand4 = "SELECT genre FROM GENRE WHERE genre = '" + genre4 + "'";

                DataTable dataTable = new DataTable();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(controlecommand4, Inloggen.connectionstring);
                dataTable.Clear();
                adapter4.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    // genre 4 invoeren
                    string command = "INSERT INTO GENRE(genre) VALUES('" + genre4 + "')";

                    OleDbCommand insertCommandGenreExtra4 = new OleDbCommand();
                    insertCommandGenreExtra4.Connection = connection;
                    insertCommandGenreExtra4.CommandText = command;
                    adapter.InsertCommand = insertCommandGenreExtra4;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                string command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + genre4 + "'";
                DataTable dataTable2 = new DataTable();
                OleDbDataAdapter adapter5 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter5.Fill(dataTable2);

                string genrenrreturn4 = dataTable2.Rows[0][0].ToString();

                string command3 = "INSERT INTO GAME_GENRE(gamenr, genrenr) VALUES('" 
                    + gamenrreturn + "', '" + genrenrreturn4 + "')";

                insertCommandGenre4.Connection = connection;
                insertCommandGenre4.CommandText = command3;
                adapter.InsertCommand = insertCommandGenre4;
                adapter.InsertCommand.ExecuteNonQuery();
            }

            if (genre5 != null)
            {
                // controleren van genre5
                string controlecommand5 = "SELECT genre FROM GENRE WHERE genre = '" + genre5 + "'";

                DataTable dataTable = new DataTable();
                OleDbDataAdapter adapter5 = new OleDbDataAdapter(controlecommand5, Inloggen.connectionstring);
                dataTable.Clear();
                adapter5.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    // genre 5 invoeren
                    string command = "INSERT INTO GENRE(genre) VALUES('" + genre5 + "')";

                    OleDbCommand insertCommandGenreExtra5 = new OleDbCommand();
                    insertCommandGenreExtra5.Connection = connection;
                    insertCommandGenreExtra5.CommandText = command;
                    adapter.InsertCommand = insertCommandGenreExtra5;
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                string command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + genre5 + "'";
                DataTable dataTable2 = new DataTable();
                OleDbDataAdapter adapter4 = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                dataTable2.Clear();
                adapter4.Fill(dataTable2);

                string genrenrreturn5 = dataTable2.Rows[0][0].ToString();

                string command3 = "INSERT INTO GAME_GENRE(gamenr, genrenr) VALUES('" 
                    + gamenrreturn + "', '" + genrenrreturn5 + "')";

                insertCommandGenre5.Connection = connection;
                insertCommandGenre5.CommandText = command3;
                adapter.InsertCommand = insertCommandGenre5;
                adapter.InsertCommand.ExecuteNonQuery();

                // koppelen gamenr via gamegenre genre5
            }
            connection.Close();
        }
        private void returnMethodeSpeloptienr()
        {
            string command2;
            OleDbConnection connection = new OleDbConnection(connectionstring);
            OleDbCommand insertCommand2 = new OleDbCommand();
            OleDbDataAdapter adapter2 = new OleDbDataAdapter();
            connection.Open();
            if (comboBoxSpeloptie.Text == "Single en multiplayer")
            {
                command2 = "SELECT speloptienr FROM SPELOPTIE WHERE speloptie = '"
                    + comboBoxSpeloptie.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                tableSpeloptienr.Clear();
                adapter.Fill(tableSpeloptienr);

                string commandgamespelopties1 = "INSERT INTO GAME_SPELOPTIE(speloptienr, gamenr) VALUES('1', '"
                    + gamenrreturn + "')";
                string commandgamespelopties2 = "INSERT INTO GAME_SPELOPTIE(speloptienr, gamenr) VALUES('2', '"
                    + gamenrreturn + "')";

                insertCommand2.CommandText = commandgamespelopties1;
                insertCommand2.Connection = connection;
                adapter2.InsertCommand = insertCommand2;
                adapter2.InsertCommand.ExecuteNonQuery();
                insertCommand2.CommandText = commandgamespelopties2;
                adapter2.InsertCommand = insertCommand2;
                adapter2.InsertCommand.ExecuteNonQuery();
            }
            else
            {
                command2 = "SELECT speloptienr FROM SPELOPTIE WHERE speloptie = '" 
                    + comboBoxSpeloptie.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command2, Inloggen.connectionstring);
                tableSpeloptienr.Clear();
                adapter.Fill(tableSpeloptienr);

                string commandgamespelopties = "INSERT INTO GAME_SPELOPTIE(speloptienr, gamenr) VALUES('"
                    + tableSpeloptienr.Rows[0][0] + "', '" + gamenrreturn + "')";

                insertCommand2.CommandText = commandgamespelopties;
                insertCommand2.Connection = connection;
                adapter2.InsertCommand = insertCommand2;
                adapter2.InsertCommand.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void returnMethodeGenrenr()
        {
            string command2;
            
            command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + textBoxGenre.Text +"'";
            DataTable dataTable = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command2, Inloggen.connectionstring);
            dataTable.Clear();
            adapter.Fill(dataTable);

            genrenrreturn = dataTable.Rows[0][0].ToString();
        }

        private void returnMethodeGamenr()
        {
            string command3;

            command3 = "SELECT gamenr FROM GAME WHERE titel = '" + textBoxTitel.Text + "'";
            DataTable dataTable = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command3, Inloggen.connectionstring);
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

            if (ADMIN.aanpassing == true)
            {
                
                OleDbConnection connection = new OleDbConnection(connectionstring);
                OleDbCommand updateCommand = new OleDbCommand();

                connection.Open();
                //spel zelf
                OleDbDataAdapter adapterGame = new OleDbDataAdapter();
                string command = "UPDATE GAME SET titel = '" + textBoxTitel.Text + "', maker = '" +
                    textBoxMaker.Text + "', prijs = '" + Convert.ToInt32(textBoxPrijs.Text) +
                    "', leeftijd = '" + Convert.ToInt32(textBoxLeeftijd.Text) + "', datum = '" +
                    textBoxDatum.Text + "' WHERE gamenr = '" + ADMIN.adminGamenr + "'";

                updateCommand.CommandText = command;
                updateCommand.Connection = connection;
                adapterGame.UpdateCommand = updateCommand;
                adapterGame.UpdateCommand.ExecuteNonQuery();

                //genre
                DataTable dataTableGenrenr = new DataTable();
                string commandGenrenr = "SELECT genrenr FROM GAME_GENRE WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                OleDbDataAdapter adapterGenrenr = new OleDbDataAdapter(commandGenrenr, Inloggen.connectionstring);
                dataTableGenrenr.Clear();
                adapterGenrenr.Fill(dataTableGenrenr);

                OleDbDataAdapter adapterGenre = new OleDbDataAdapter();
                string commandGenre = "UPDATE GENRE SET genre = '" + textBoxGenre.Text + "' WHERE genrenr = '"
                    + dataTableGenrenr.Rows[0][0].ToString() + "'";

                updateCommand.CommandText = commandGenre;
                updateCommand.Connection = connection;
                adapterGenre.UpdateCommand = updateCommand;
                adapterGenre.UpdateCommand.ExecuteNonQuery();

                //speloptie select
                DataTable dataTableSelect = new DataTable();
                string command8 = "DELETE FROM GAME_SPELOPTIE WHERE gamenr = '" + ADMIN.adminGamenr + "'";

                OleDbDataAdapter adapterofdoom = new OleDbDataAdapter();
                OleDbCommand dropCommand3 = new OleDbCommand();
                dropCommand3.CommandText = command8;
                dropCommand3.Connection = connection;
                adapterofdoom.DeleteCommand = dropCommand3;
                adapterofdoom.DeleteCommand.ExecuteNonQuery();                

                // de rest
                returnMethodeGamenr();
                returnMethodeSpeloptienr();
                /*DataTable dataTableSpeloptienr = new DataTable();
                string commandSpeloptienr = "SELECT speloptienr FROM GAME_SPELOPTIE WHERE gamenr = '" + ADMIN.adminGamenr + "'";
                OleDbDataAdapter adapterSpeloptienr = new OleDbDataAdapter(commandSpeloptienr, Inloggen.connectionstring);
                dataTableSpeloptienr.Clear();
                adapterSpeloptienr.Fill(dataTableSpeloptienr);

                OleDbDataAdapter adapterSpeloptie = new OleDbDataAdapter();
                string commandSpeloptie = "UPDATE SPELOPTIE SET speloptie = '" + comboBoxSpeloptie.Text + 
                    "' WHERE speloptienr = '" + dataTableSpeloptienr.Rows[0][0].ToString() + "'";

                updateCommand.CommandText = commandSpeloptie;
                updateCommand.Connection = connection;
                adapterSpeloptie.UpdateCommand = updateCommand;
                adapterSpeloptie.UpdateCommand.ExecuteNonQuery();*/

                connection.Close();
                this.Close();
                ADMIN.aanpassing = false;
            }
            else if (ADMIN.aanpassing == false)
            {
                OleDbConnection connection = new OleDbConnection(connectionstring);
                OleDbCommand insertCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

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

                    returnMethodeGamenr();
                    returnMethodeSpeloptienr();
                    genreInvoer();

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
