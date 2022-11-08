using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Pixis Air Team Project
 * 152-168-2WY1 - IBM and .NET Enterprise Prog
 * Professor Allen Pearson
 * 
 * TEAM 5
 * Oskar Sierzega, Tony Beesly, Jack Clothier, Alec Barribeau.
 * 
 * Main form by Oskar Sierzega.
 */

namespace PixisAir_Team5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Exit Menu Item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTony_Click(object sender, EventArgs e)
        {
            tonyForm tony = new tonyForm();
            tony.Show();
        }

        private void btnOskar1_Click(object sender, EventArgs e)
        {
            OskarForm1 oskar = new OskarForm1();
            oskar.Show();
        }
    }
}
