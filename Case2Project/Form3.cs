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
    public partial class Form3 : Form
    {
        public beoordeling beoordeling = new beoordeling();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonBeoordelingOk_Click(object sender, EventArgs e)
        {
            int cijfer = Convert.ToInt32(cijferTextBox.Text);
            beoordeling.reactie(beoordelingTextBox.Text, cijfer);
            this.Close();
        } 
    }
}
