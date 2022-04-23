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
    public partial class FormAdherents : Form
    {
        private List<Adherent> lesAdherents = new List<Adherent>();
        public FormAdherents()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            try
            {
                //lesAuteurs = ManagerAuteur.DonneAuteurs();
                lesAdherents = Manager.GetListFromDB<Adherent>();
                bs.DataSource = lesAdherents;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            var adherent = dgv_ListeAdherents.SelectedRows[0].DataBoundItem as Adherent;
            var form = new FicheAdherent(ButtonClicked.Afficher, adherent);
            form.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dgv_ListeAdherents.SelectedRows[0].Index;
            var adherent = dgv_ListeAdherents.SelectedRows[0].DataBoundItem as Adherent;
            var form = new FicheAdherent(ButtonClicked.Modifier, adherent);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeAdherents.ClearSelection();
                GridLoad();
                dgv_ListeAdherents.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (Manager.Delete(dgv_ListeAdherents.SelectedRows[0].DataBoundItem as Adherent)) GridLoad();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            var form = new FicheAdherent(ButtonClicked.Nouveau, new Adherent() { Num = lesAdherents.Max(x => x.Num) + 1 });
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dgv_ListeAdherents.ClearSelection();
                GridLoad();
            }
        }
    }
}
