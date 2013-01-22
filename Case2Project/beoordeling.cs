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
    public class beoordeling
    {
        public void reactie(string tekst, int cijfer)
        {
            OleDbConnection connection = new OleDbConnection(Form1.connectionstring);
            OleDbCommand insertCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            // beoordeling
            string command;

            try
            {
                connection.Open();
                command = "INSERT INTO GAME_BEOORDELING(gamenr, gebruikernr, beoordeling, beoordelingscijfer) VALUES('" +
                     Form2.gamenr + "', '" + Form1.gebruikerNaam + "', '" + tekst + "', '" +
                      cijfer + "')";

                insertCommand.Connection = connection;
                insertCommand.CommandText = command;
                adapter.InsertCommand = insertCommand;

                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Reactie geplaatst");
            }
            catch (Exception obj)
            {
                // nog aanpassen dat er hier nog een is voor als cijfer null is, als de beoordeling leeg is etc.
                MessageBox.Show(obj.Message);
            }
            finally
            {
                connection.Close();
            } 
        }
    }
}
