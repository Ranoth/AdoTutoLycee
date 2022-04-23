using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AdoTutoLycee
{
    public class ManagerAuteur
    {
        public static Auteur DonneAuteurDuReader(MySqlDataReader monReader)
        {
            return new Auteur()
            {
                Num = Convert.ToInt16(monReader["num"]),
                Nom = monReader["nom"].ToString() ?? "",
                Prenom = monReader["prenom"].ToString() ?? "",
                Nationalite = monReader["nationalite"].ToString() ?? "",
            };
        }

        public static List<Auteur> DonneAuteurs()
        {
            var list = new List<Auteur>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from auteur order by nom";
            monReader = maRequete.ExecuteReader();

            while (monReader.Read()) list.Add(DonneAuteurDuReader(monReader));

            Connection.MaConnection.Close();
            monReader.Close();

            return list;
        }

        public static Auteur DonneAuteurParId(int id)
        {
            var auteur = new Auteur();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from auteur where num = @paramNum order by nom";
            maRequete.Parameters.AddWithValue("@paramNum", id);
            monReader = maRequete.ExecuteReader();

            while (monReader.Read()) auteur = DonneAuteurDuReader(monReader);

            Connection.MaConnection.Close();
            monReader.Close();

            return auteur;
        }

        public static DialogResult Save(Auteur a, ButtonClicked buttonClicked)
        {
            DialogResult result = DialogResult.None;

            if (buttonClicked == ButtonClicked.Nouveau)
            {
                MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "insert into auteur (nom, prenom, nationalite) " +
                    "values (@paramNom, @paramPrenom, @paramNation)";

                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
                maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
                maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);

                try
                {
                    Connection.MaConnection.Open();
                    int any = maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    if (any > 0)
                    {
                        MessageBox.Show("L'auteur à bien été créé");
                        result = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été créé");
                        result = DialogResult.Cancel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonClicked == ButtonClicked.Modifier)
            {
                MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "update auteur set " +
                    "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation where num=@paramNum";

                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
                maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
                maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);
                maRequete.Parameters.AddWithValue("@paramNum", a.Num);

                try
                {
                    Connection.MaConnection.Open();
                    int any = maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    if (any > 0)
                    {
                        MessageBox.Show("L'auteur à bien été mis à jours");
                        result = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été mis à jours");
                        result = DialogResult.Cancel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }

        //public static DialogResult ModifierAuteur(Auteur a)
        //{
        //    MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
        //    DialogResult result = DialogResult.None;
        //    maRequete.CommandText = "update auteur set " +
        //        "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation where num=@paramNum";

        //    maRequete.Parameters.Clear();
        //    maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
        //    maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
        //    maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);
        //    maRequete.Parameters.AddWithValue("@paramNum", a.Num);

        //    try
        //    {
        //        Connection.MaConnection.Open();
        //        int any = maRequete.ExecuteNonQuery();
        //        Connection.MaConnection.Close();
        //        if (any > 0)
        //        {
        //            MessageBox.Show("L'auteur à bien été mis à jours");
        //            result = DialogResult.OK;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été mis à jours");
        //            result = DialogResult.Cancel;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return result;
        //}

        public static bool SupprimerAuteur(Auteur a)
        {
            bool result = false;
            try
            {
                if (a != null && MessageBox.Show($"Voulez vous vraiment supprimer l'auteur {a.Nom} ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
                    Connection.MaConnection.Open();
                    maRequete.CommandText = "delete from auteur where num=@paramNum";
                    maRequete.Parameters.Clear();
                    maRequete.Parameters.AddWithValue("@paramNum", a.Num);
                    maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    result = true;
                }
                else if (a == null) MessageBox.Show("Veuillez sélectionner un auteur à supprimer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}


