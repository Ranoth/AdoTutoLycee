using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdoTutoLycee
{
    public partial class FormGenres : Form
    {
        private List<Genre> lesGenres = new List<Genre>();
        public FormGenres()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            try
            {
                //lesAuteurs = ManagerAuteur.DonneAuteurs();
                lesGenres = Manager.GetListFromDB<Genre>();
                bs.DataSource = lesGenres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            var genre = dgv_ListeGenres.SelectedRows[0].DataBoundItem as Genre;
            var form = new FicheGenre(ButtonClicked.Afficher, genre);
            form.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dgv_ListeGenres.SelectedRows[0].Index;
            var genre = dgv_ListeGenres.SelectedRows[0].DataBoundItem as Genre;
            var form = new FicheGenre(ButtonClicked.Modifier, genre);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeGenres.ClearSelection();
                GridLoad();
                dgv_ListeGenres.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (Manager.Delete(dgv_ListeGenres.SelectedRows[0].DataBoundItem as Genre)) GridLoad();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            var form = new FicheGenre(ButtonClicked.Nouveau, new Genre() { Num = lesGenres.Max(x => x.Num) + 1 });
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeGenres.ClearSelection();
                GridLoad();
            }
        }
    }
}
