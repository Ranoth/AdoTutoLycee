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
    public partial class FormLivres : Form
    {
        private List<Livre> lesLivres = new List<Livre>();
        public FormLivres()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            try
            {
                lesLivres = Manager.GetListFromDB<Livre>();

                bs.DataSource = (from livres in lesLivres
                             join auteurs in Manager.GetListFromDB<Auteur>() on livres.NumAuteur equals auteurs.Num
                             join genres in Manager.GetListFromDB<Genre>() on livres.NumGenre equals genres.Num
                             select new QLivre
                             {
                                 Num = livres.Num,
                                 ISBN = livres.ISBN,
                                 Titre = livres.Titre,
                                 Prix = livres.Prix,
                                 Editeur = livres.Editeur,
                                 Annee = livres.Annee,
                                 Langue = livres.Langue,
                                 NomAuteur = auteurs.Nom,
                                 LibelleGenre = genres.Libelle
                             }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            var livre = lesLivres.Single(x => x.Num == (dgv_ListeLivres.SelectedRows[0].DataBoundItem as QLivre).Num);
            var form = new FicheLivre(ButtonClicked.Afficher, livre);
            form.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dgv_ListeLivres.SelectedRows[0].Index;
            var livre = lesLivres.Single(x => x.Num == (dgv_ListeLivres.SelectedRows[0].DataBoundItem as QLivre).Num);
            var form = new FicheLivre(ButtonClicked.Modifier, livre);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeLivres.ClearSelection();
                GridLoad();
                dgv_ListeLivres.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (Manager.Delete(lesLivres.Single(x => x.Num == (dgv_ListeLivres.SelectedRows[0].DataBoundItem as QLivre).Num)))
                GridLoad();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            var form = new FicheLivre(ButtonClicked.Nouveau, new Livre() { Num = lesLivres.Max(x => x.Num) + 1 });
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeLivres.ClearSelection();
                GridLoad();
            }
        }
    }
}
