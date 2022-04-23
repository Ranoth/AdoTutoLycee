using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdoTutoLycee
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAuteurs();
            form.ShowDialog(this);
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormGenres();
            form.ShowDialog(this);
        }

        private void adhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAdherents();
            form.ShowDialog(this);
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormLivres();
            form.ShowDialog(this);
        }
    }
}
