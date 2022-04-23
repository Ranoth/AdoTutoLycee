using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoTutoLycee
{
    public partial class FormAuteurs : Form
    {
        private List<Auteur> lesAuteurs = new List<Auteur>();
        public FormAuteurs()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            try
            {
                //lesAuteurs = ManagerAuteur.DonneAuteurs();
                lesAuteurs = Manager.GetListFromDB<Auteur>();
                bs.DataSource = lesAuteurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            var auteur = dgv_ListeAuteurs.SelectedRows[0].DataBoundItem as Auteur;
            var form = new FicheAuteur(ButtonClicked.Afficher, auteur);
            form.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dgv_ListeAuteurs.SelectedRows[0].Index;
            var auteur = dgv_ListeAuteurs.SelectedRows[0].DataBoundItem as Auteur;
            var form = new FicheAuteur(ButtonClicked.Modifier, auteur);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeAuteurs.ClearSelection();
                GridLoad();
                dgv_ListeAuteurs.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (Manager.Delete(dgv_ListeAuteurs.SelectedRows[0].DataBoundItem as Auteur)) GridLoad();

        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            var form = new FicheAuteur(ButtonClicked.Nouveau, new Auteur() { Num = lesAuteurs.Max(x => x.Num) + 1});
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeAuteurs.ClearSelection();
                GridLoad();
            }
        }
    }
}
