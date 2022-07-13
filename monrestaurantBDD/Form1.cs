using MySql.Data.MySqlClient;

namespace monrestaurantBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        MySqlConnection connection;
        Boolean isConnected = false;
        private void btnConnection_Click_1(object sender, EventArgs e)
        {
            if (btnConnection.Text == "Se connecter")
            {
                connection = new MySqlConnection("SERVER = db4free.net; PORT = 3306; DATABASE = monrestaurant; UID=projetest; PWD=basetest;");

                {
                    try
                    {
                        if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
                        btnConnection.Text = "Se déconnecter";
                        isConnected = true;

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }



            }
            else
            {
                connection.Close();
                btnConnection.Text = "Se connecter";
                isConnected = false;

                listView1.Clear();
            }
        }


        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxAddFirstname.Text == "" || textBoxAddName.Text=="")
            {
                MessageBox.Show("Les champs doivent être renseignés");
            }
            else if (isConnected == false)
            {
                MessageBox.Show("Veuillez vous connecter");
            }
            else
            {
                try
                {
                    MySqlCommand query = new MySqlCommand(" INSERT INTO Clients (Nom, Prénom) VALUES (@Nom, @Prénom) ", connection);
                    query.Parameters.AddWithValue("@Nom", textBoxAddName.Text);
                    query.Parameters.AddWithValue("@Prénom", textBoxAddFirstname.Text);
                    query.ExecuteNonQuery();
                    
                    MessageBox.Show("Ajouté");

                    query.Parameters.Clear();
                    textBoxAddName.Clear();
                    textBoxAddFirstname.Clear();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (isConnected == false )
            {
                MessageBox.Show("Veuillez vous identifier");
            }
            else
            {
                listView1.Items.Clear();
                MySqlCommand query = new MySqlCommand("SELECT * from Clients", connection);
                using(MySqlDataReader dataReader = query.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        String id = dataReader["id"].ToString();
                        String nom = dataReader["Nom"].ToString();
                        String prenom = dataReader["Prénom"].ToString();

                        listView1.Items.Add(new ListViewItem(new String[] { id, nom, prenom }));
                    }
                }

            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isConnected == false )
            {
                MessageBox.Show("Veuillez vous connecter");
            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selection = listView1.SelectedItems[0];
                    String id = selection.SubItems[0].Text;
                    MySqlCommand query = new MySqlCommand("DELETE FROM Clients WHERE id=@id ", connection);
                    query.Parameters.AddWithValue("id", id);
                    query.ExecuteNonQuery();

                }

            }
        }
    }
}