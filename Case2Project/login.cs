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
    public class login
    {
        OleDbConnection connection = new OleDbConnection(Inloggen.connectionstring);
        OleDbCommand insertCommand = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        public static int aantalRegels;

        public void registreer(string naam, string wachtwoord)
        {
            string command;

            try
            {
                connection.Open();
                command = "INSERT INTO LOGIN(username,wachtwoord) VALUES('" +
                    naam + "', '" + wachtwoord + "')";

                insertCommand.CommandText = command;
                insertCommand.Connection = connection;
                adapter.InsertCommand = insertCommand;

                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("U bent geregistreerd");
            }
            catch (Exception)
            {
                MessageBox.Show("Dit account bestaat al.");
            }
            finally
            {
                connection.Close();
            }
        }

        public void inloggen(string naam, string wachtwoord)
        {
            DataTable table = new DataTable();

            if (naam == "admin") //controleert of je als admin inlogt
            {
                Inloggen.admin = true;
            }
            else
            {
                Inloggen.admin = false;
            }

            string command = "SELECT * FROM LOGIN WHERE " +
                " username = '" + naam + "' AND wachtwoord = '" + wachtwoord + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command, Inloggen.connectionstring);

            aantalRegels = adapter.Fill(table);
        }
    }
}
