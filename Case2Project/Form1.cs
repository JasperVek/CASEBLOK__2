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
    public partial class Form1 : Form
    {
        public static string connectionstring =
            @"Provider = Microsoft.SQLSERVER.CE.OLEDB.4.0;" +
            @"Data Source=|DataDirectory|\GAMES.sdf";

        public static bool admin;
        public static string gebruikerNaam;
        public login login = new login();

        public Form1()
        {
            InitializeComponent();
        }

        private void registreerButton_Click(object sender, EventArgs e)
        {
            login.registreer(registreerNaamTextbox.Text, registreerWachtwoordTextbox.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login.inloggen(loginNaamTextbox.Text, loginWachtwoordTextbox.Text);

            if (login.aantalRegels != 0)
            {
                gebruikerNaam = loginNaamTextbox.Text;
                MessageBox.Show("Welkom");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); //verstopt form1, de applicatie sluit als form2 word gesloten
            }
            else
            {
                MessageBox.Show("Gebruikersnaam en/of wachtwoord is verkeerd.\n \t Probeer opnieuw");
            }
        }
    }
}
