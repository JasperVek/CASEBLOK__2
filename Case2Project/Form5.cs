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

        private void aanpassingenOkButton_Click(object sender, EventArgs e)
        {
            // 
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

            string command;
            string commandspelopties;
            string commandgenre;

            try
            {
                connection.Open();
                command = "INSERT INTO GAME(titel, maker, prijs, leeftijd, datum,) VALUES('" +
                    textBoxTitel.Text + "', '" + textBoxMaker.Text + "', '" + textBoxPrijs.Text +
                    "', '" + textBoxLeeftijd.Text + "', '" + textBoxDatum.Text + "')";
                // nog genre en spelopties en een if voor als er 2 of meerdere zijn
                // voor spelopties kan er maar 2 zijn in totaal

                insertCommand.CommandText = command;
                insertCommand.Connection = connection;
                adapter.InsertCommand = insertCommand;

                adapter.InsertCommand.ExecuteNonQuery();

                //2 spelopties
                insertCommand2.CommandText = commandspelopties;
                insertCommand2.Connection = connection;
                adapter2.InsertCommand = insertCommand2;

                adapter.InsertCommand.ExecuteNonQuery();

                //3 genre
                insertCommand.CommandText = commandgenre;
                insertCommand.Connection = connection;
                adapter.InsertCommand = insertCommand;

                adapter.InsertCommand.ExecuteNonQuery();

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
