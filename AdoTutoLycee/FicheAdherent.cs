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
    public partial class FicheAdherent : Form
    {
        private Adherent CurrentAdherent = new Adherent();
        private ButtonClicked buttonClicked;
        public FicheAdherent(ButtonClicked buttonClicked, Adherent monAdherent)
        {
            InitializeComponent();
            this.buttonClicked = buttonClicked;
            if (monAdherent != null) CurrentAdherent = monAdherent;
            bs.DataSource = CurrentAdherent;
            if (buttonClicked == ButtonClicked.Afficher)
            {
                txt_Nom.Enabled = false;
                txt_Mail.Enabled = false;
                txt_Post.Enabled = false;
                txt_Prenom.Enabled = false;
                txt_Rue.Enabled = false;
                txt_Tel.Enabled = false;
                txt_Ville.Enabled = false;
                btn_Valider.Enabled = false;
            }
        }

        private void btw_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            //if (ControleSaisie()) DialogResult = ManagerAuteur.Save(AuteurCourant, buttonClicked);
            if (ControleSaisie()) DialogResult = Manager.Save(CurrentAdherent, buttonClicked);
        }

        private bool ControleSaisie()
        {
            bool controle = true;
            var strList = new List<string>();

            if (txt_Nom.Text == String.Empty)
            {
                strList.Add("un nom");
                controle = false;
            }
            if (txt_Ville.Text == String.Empty)
            {
                strList.Add("une ville");
                controle = false;
            }
            if (txt_Tel.Text == String.Empty)
            {
                strList.Add("un numéro de téléphone");
                controle = false;
            }
            if (txt_Rue.Text == String.Empty)
            {
                strList.Add("une rue");
                controle = false;
            }
            if (txt_Prenom.Text == String.Empty)
            {
                strList.Add("un prénom");
                controle = false;
            }
            if (txt_Post.Text == String.Empty)
            {
                strList.Add("un code postal");
                controle = false;
            }
            if (txt_Mail.Text == String.Empty)
            {
                strList.Add("un mail");
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
