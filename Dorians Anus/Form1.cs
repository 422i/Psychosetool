using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorians_Anus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hallobtn_Click(object sender, EventArgs e)
        {
            if(phillcbox.SelectedItem == "Phill")
            {
                MessageBox.Show("Phill hat 99% Psychose!!!!!");
            }
            else if(phillcbox.SelectedItem == "Jeff")
            {
                MessageBox.Show("Phill hat 101% Psychose!!!!!");
            }
            else
            {
                MessageBox.Show("Ok");
                Environment.Exit(0);
            }
        }
    }
}
