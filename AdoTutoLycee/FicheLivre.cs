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
    public partial class FicheLivre : Form
    {
        private Livre currentLivre = new Livre();
        private ButtonClicked buttonClicked;
        public FicheLivre(ButtonClicked buttonClicked, Livre monLivre)
        {
            InitializeComponent();
            this.buttonClicked = buttonClicked;
            if (monLivre != null) currentLivre = monLivre;
            bs.DataSource = currentLivre;
            LoadCbo();
            if (buttonClicked == ButtonClicked.Afficher)
            {
                txt_ISBN.Enabled = false;
                txt_Annee.Enabled = false;
                txt_Editeur.Enabled = false;
                txt_Langue.Enabled = false;
                txt_Prix.Enabled = false;
                txt_Titre.Enabled = false;
                btn_Valider.Enabled = false;

                cboAuteur.Enabled = false;
                cboGenre.Enabled = false;
            }
        }

        private void LoadCbo()
        {
            cboAuteur.DataSource = Manager.GetListFromDB<Auteur>().Select(x => new { x.Num, x.Nom }).ToList();
            cboAuteur.ValueMember = nameof(Auteur.Num);
            cboAuteur.DisplayMember = nameof(Auteur.Nom);
            cboAuteur.SelectedValue = currentLivre.NumAuteur;

            cboGenre.DataSource = Manager.GetListFromDB<Genre>();
            cboGenre.ValueMember = nameof(Genre.Num);
            cboGenre.DisplayMember = nameof(Genre.Libelle);
            cboGenre.SelectedValue = currentLivre.NumGenre;
        }

        private void btw_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (cboAuteur.SelectedValue != null) currentLivre.NumAuteur = (int)cboAuteur.SelectedValue;
            if (cboGenre.SelectedValue != null) currentLivre.NumGenre = (int)cboGenre.SelectedValue;
            if (ControleSaisie()) DialogResult = Manager.Save(currentLivre, buttonClicked);
        }

        private bool ControleSaisie()
        {
            bool controle = true;
            var strList = new List<string>();

            if (txt_ISBN.Text == "")
            {
                strList.Add("un ISBN");
                controle = false;
            }
            if (txt_Titre.Text == "")
            {
                strList.Add("un titre");
                controle = false;
            }
            if (txt_Prix.Text == "" || txt_Prix.Text == "0.00")
            {
                strList.Add("un prix");
                controle = false;
            }
            if (txt_Langue.Text == "")
            {
                strList.Add("une langue");
                controle = false;
            }
            if (txt_Editeur.Text == "")
            {
                strList.Add("un éditeur");
                controle = false;
            }
            if (txt_Annee.Text == "" || txt_Annee.Text == "0")
            {
                strList.Add("une année");
                controle = false;
            }
            if (cboAuteur.SelectedValue == null)
            {
                strList.Add("un auteur");
                controle = false;
            }
            if (cboGenre.SelectedValue == null)
            {
                strList.Add("un genre");
                controle = false;
            }

            if (strList.Count > 1) strList[strList.Count - 1] = strList.Last().Insert(0, "et ");

            if (!controle)
            {
                string str = $"Veuillez saisir {String.Join(", ", strList)}.";
                str = str.Remove(str.LastIndexOf(','), 1);
                MessageBox.Show(str);
            }

            return controle;
        }
    }
}
