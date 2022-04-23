using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AdoTutoLycee
{
    public static class Manager
    {
        private static T GetReaderItem<T>(MySqlDataReader reader) where T : class, new()
        {
            var result = new T();
            PropertyInfo[] propertyInfos = typeof(T).GetProperties();

            foreach (PropertyInfo prop in propertyInfos)
            {
                if (reader[prop.Name].GetType() != typeof(DBNull)) prop.SetValue(result, reader[prop.Name]);
                else prop.SetValue(result, "");
            }

            return result;
        }

        public static List<T> GetListFromDB<T>() where T : class, new()
        {
            var list = new List<T>();

            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = $"select * from {typeof(T).Name}";
            monReader = maRequete.ExecuteReader();

            while (monReader.Read()) list.Add(GetReaderItem<T>(monReader));

            Connection.MaConnection.Close();
            monReader.Close();

            return list;
        }

        private static MySqlCommand CustQueryBuilder<T>(MySqlCommand maRequete, T obj, ButtonClicked buttonClicked) where T : class, new()
        {
            PropertyInfo[] propertyInfos = typeof(T).GetProperties();
            string cmdText = "";
            int num = 0;
            var paramObjValPair = new Dictionary<string, object>();
            var paramValNamePair = new Dictionary<string, string>();

            foreach (PropertyInfo prop in propertyInfos)
            {
                if (prop.Name != "Num")
                {
                    paramObjValPair.Add("@param" + prop.Name, prop.GetValue(obj).ToString());
                    paramValNamePair.Add("@param" + prop.Name, prop.Name.ToLower());
                }
                else num = Convert.ToInt32(prop.GetValue(obj));
            }

            if (buttonClicked == ButtonClicked.Nouveau)
            {
                cmdText += $"insert into {typeof(T).Name} ({String.Join(", ", paramValNamePair.Values)}) " +
                    $"values ({String.Join(", ", paramValNamePair.Keys)})";
            }
            else if (buttonClicked == ButtonClicked.Modifier)
            {
                cmdText += $"update {typeof(T).Name} set ";
                var tempList = new List<string>();
                foreach (var item in paramValNamePair)
                {
                    tempList.Add($"{item.Value}={item.Key}");
                }
                cmdText += $"{String.Join(", ", tempList)} where num=@paramNum";
            }

            maRequete.CommandText = cmdText;
            maRequete.Parameters.Clear();
            if (buttonClicked == ButtonClicked.Modifier) maRequete.Parameters.AddWithValue("@paramNum", num);
            foreach (var item in paramObjValPair)
            {
                maRequete.Parameters.AddWithValue(item.Key, item.Value);
            }

            return maRequete;
        }

        public static DialogResult Save<T>(T obj, ButtonClicked buttonClicked) where T : class, new()
        {
            DialogResult result = DialogResult.None;

            if (buttonClicked == ButtonClicked.Nouveau)
            {
                MySqlCommand maRequete = Connection.MaConnection.CreateCommand();

                maRequete = CustQueryBuilder<T>(maRequete, obj, buttonClicked);

                try
                {
                    Connection.MaConnection.Open();
                    int any = maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    if (any > 0)
                    {
                        MessageBox.Show("L'enregistrement} à bien été créé");
                        result = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite, l'enregistrement n'a pas été créé");
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

                maRequete = CustQueryBuilder<T>(maRequete, obj, buttonClicked);

                try
                {
                    Connection.MaConnection.Open();
                    int any = maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    if (any > 0)
                    {
                        MessageBox.Show("L'enregistrement à bien été mis à jours");
                        result = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite, l'enregistrement n'a pas été mis à jours");
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

        public static bool Delete<T>(T obj) where T : class
        {
            bool result = false;
            try
            {
                PropertyInfo[] propertyInfos = typeof(T).GetProperties();
                string libelle = "";
                int num = 0;
                string[] names = new string[]
                {
                    "Nom",
                    "Libelle",
                    "Titre"
                };
                foreach (PropertyInfo prop in propertyInfos)
                {
                    if (names.Contains(prop.Name)) libelle = prop.GetValue(obj).ToString();
                    if (prop.Name == "Num") num = Convert.ToInt32(prop.GetValue(obj));
                }

                if (obj != null && MessageBox.Show($"Voulez vous vraiment supprimer {libelle} ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
                    Connection.MaConnection.Open();
                    maRequete.CommandText = $"delete from {typeof(T).Name} where num=@paramNum";
                    maRequete.Parameters.Clear();
                    maRequete.Parameters.AddWithValue("@paramNum", num);
                    maRequete.ExecuteNonQuery();
                    Connection.MaConnection.Close();
                    result = true;
                }
                else if (obj == null) MessageBox.Show("Veuillez sélectionner un enregistrement à supprimer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
    public enum ButtonClicked
    {
        Afficher,
        Modifier,
        Nouveau
    }
}
