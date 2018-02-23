using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace GR_BDD_Final1
{
    public class DBconnect
    {
        private MySqlConnection connection;
        private string server;
        public string database;
        private string uid;
        private string password;

        //  Constructor
        public DBconnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            server = "localhost";
            database = "clicom";
            uid = "revan";
            password = "albafica130";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot");
                        break;

                    case 1045:
                        MessageBox.Show("Cant");
                        break;

                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        /*
                public void Insert()
                {
                    string query = "INSERT INTO client (NCLI,NOM,LOCALITE,ADRESSE,CAT,COMPTE) VALUES('6663','Stiles','Beacon Hills','13 Wolf Square','B2','30000')";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
        */

        public bool Insert_Client
            (string nCli, string nOm, string lOcalite, string aDresse,
            string cAt, string cOmpte)
        {
            string query = "INSERT INTO client (NCLI,NOM,LOCALITE,ADRESSE,CAT,COMPTE) VALUES('" + nCli + "','" + nOm + "','" + lOcalite + "','" + aDresse + "','" + cAt + "','" + cOmpte + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert_Item
            (string nProd, string lIbelle, string pRix, string sTock)
        {
            string query = "INSERT INTO produit (NPRO,LIBELLE,PRIX,QSTOCK) VALUES('" + nProd + "','" + lIbelle + "','" + pRix + "','" + sTock + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert_Comm
            (string nComm, string nCli, string dAte)
        {
            string query = "INSERT INTO commande (NCOM,NCLI,DATECOM) VALUES('" + nComm + "','" + nCli + "','" + dAte + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool List_Client()
        {
//  Probleme de connexion
            string query = "SELECT * FROM client";
            MySqlDataReader reader = null;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                WriteList(reader);
                this.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[,] WriteList(MySqlDataReader reader)
        {
            string[,] str = new string[10, 5];
            int i = 0;
            int j = 0;
            while (reader.Read())
            {
                str[i, j] = reader.GetString(0);
                j++;
                if (j == 5)
                {
                    i++;
                }
            }
            return str;
        }

        public void Recherche_Client(string resch)
        {
            string query = "SELECT * FROM client WHERE NOM = '" + resch + "'";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            connection.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetString(1));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            connection.Close();
        }

    }
}

