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
        }

        object returnValueSpeloptienr;
        object returnValueGenrenr;
        object returnValueGamenr;
        string speloptienrreturn, gamenrreturn, genrenrreturn;

        private void returnMethodeSpeloptienr()
        {
            OleDbConnection connection = new OleDbConnection(connectionstring);
            OleDbCommand insertCommand2 = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            string command2;
            
            connection.Open();
            command2 = "SELECT speloptienr FROM SPELOPTIE WHERE speloptie = '" + comboBoxSpeloptie.Text + "'";

            insertCommand2.CommandText = command2;
            insertCommand2.Connection = connection;
            adapter.InsertCommand = insertCommand2;

            returnValueSpeloptienr = insertCommand2.ExecuteScalar();
            connection.Close();
            speloptienrreturn = returnValueSpeloptienr.ToString();
        }

        private void returnMethodeGenrenr()
        {
            OleDbConnection connection = new OleDbConnection(connectionstring);
            OleDbCommand insertCommand2 = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            string command2;
            
            connection.Open();
            command2 = "SELECT genrenr FROM GENRE WHERE genre = '" + textBoxGenre.Text +"'";

            insertCommand2.CommandText = command2;
            insertCommand2.Connection = connection;
            adapter.InsertCommand = insertCommand2;

            returnValueGenrenr = insertCommand2.ExecuteScalar();
            connection.Close();
            genrenrreturn = returnValueGenrenr.ToString();
        }

        private void returnMethodeGamenr()
        {
            OleDbConnection connection = new OleDbConnection(connectionstring);
            OleDbCommand insertCommand3 = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            string command3;

            connection.Open();
            command3 = "SELECT gamenr FROM GAME WHERE titel = " + textBoxTitel.Text + "'";

            insertCommand3.CommandText = command3;
            insertCommand3.Connection = connection;
            adapter.InsertCommand = insertCommand3;

            returnValueGamenr = insertCommand3.ExecuteScalar();
            connection.Close();

            gamenrreturn = returnValueGamenr.ToString();
        } 


        private void aanpassingenOkButton_Click(object sender, EventArgs e)
        {
            // spelopties van deze actie
            string spelopties = comboBoxSpeloptie.Text;
            // genre van deze actie
            string genre = textBoxGenre.Text;

            if (Form4.aanpassing == true)
            {
                //einde
                Form4.aanpassing = false;
            }

            if (Form4.aanpassing == false)
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

                string command;

                string commandgamespelopties;
                string commandgamegenre;
                string commandgenre;


                try
                {
                    connection.Open();
                    command = "INSERT INTO GAME(titel, maker, prijs, leeftijd, datum) VALUES('" +
                        textBoxTitel.Text + "', '" + textBoxMaker.Text + "', '" + Convert.ToInt32(textBoxPrijs.Text) +
                        "', '" + Convert.ToInt32(textBoxLeeftijd.Text) + "', '" + textBoxDatum.Text + "')";

                    // eerste command

                    insertCommand.Connection = connection;
                    insertCommand.CommandText = command;
                    adapter.InsertCommand = insertCommand;
                    adapter.InsertCommand.ExecuteNonQuery();

                    // zoeken
                    returnMethodeGamenr();
                    returnMethodeGenrenr();
                    returnMethodeSpeloptienr();
                    MessageBox.Show(gamenrreturn);
                    commandgenre = " INSERT INTO GENRE(genre) VALUES('" + genre + "')";
                    commandgamegenre = " INSERT INTO GAME_GENRE(genrenr, gamenr) VALUES('" + genrenrreturn + "', '" +
                        gamenrreturn + "')";
                    commandgamespelopties = " INSERT INTO GAME_SPELOPTIE(speloptienr, gamenr) VALUES('" + speloptienrreturn + "', '" +
                        gamenrreturn + "')";


                    insertCommand4.CommandText = commandgamespelopties;
                    insertCommand4.Connection = connection;

                    // spelopties
                    insertCommand2.CommandText = commandgamespelopties;
                    insertCommand2.Connection = connection;
                    // genre
                    insertCommand3.CommandText = commandgamegenre;
                    insertCommand3.Connection = connection;

                    // de adapters en uitvoeringen

                    adapter3.InsertCommand = insertCommand3;
                    adapter2.InsertCommand = insertCommand2;

                    adapter2.InsertCommand.ExecuteNonQuery();
                    adapter3.InsertCommand.ExecuteNonQuery();

                    adapter4.InsertCommand.ExecuteNonQuery();

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
    }
}
