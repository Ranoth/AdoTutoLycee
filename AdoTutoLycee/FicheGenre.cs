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
    public partial class FicheGenre : Form
    {
        private Genre CurrentGenre = new Genre();
        private ButtonClicked buttonClicked;
        public FicheGenre(ButtonClicked buttonClicked, Genre monGenre)
        {
            InitializeComponent();
            this.buttonClicked = buttonClicked;
            if (monGenre != null) CurrentGenre = monGenre;
            bs.DataSource = CurrentGenre;
            if (buttonClicked == ButtonClicked.Afficher)
            {
                txt_Nom.Enabled = false;
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
            if (ControleSaisie()) DialogResult = Manager.Save(CurrentGenre, buttonClicked);
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
