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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Se connecter")
            {
                connection = new MySqlConnection("SERVER = db4free.net; PORT = 3306; DATABASE = monrestaurant; UID=projetest; PWD=basetest;");
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                   try
                    {
                        connection.Open();
                        button1.Text = "Se d�connecter";
                        isConnected = true;
                    }
                    catch  (Exception ex) { MessageBox.Show(ex.Message); } 
                }
                else
                {
                    connection.Close();
                    button1.Text = "Se connecter";
                    isConnected=false;
                }

                
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (textBoxAddFirstname.Text == "" || textBoxAddName.Text=="")
            {
                MessageBox.Show("Les champs doivent �tre renseign�s");
            }
            else if (isConnected = false)
            {
                MessageBox.Show("Veuillez vous connecter");
            }
            else
            {
                try
                {
                    MySqlCommand query = new MySqlCommand(" INSERT INTO Clients (Nom, Pr�nom) VALUES (@Nom, @Pr�nom) ");
                    query.Parameters.AddWithValue("@Name", textBoxAddName.Text);
                    query.Parameters.AddWithValue("@Pr�nom", textBoxAddFirstname.Text);
                    query.ExecuteNonQuery();
                    query.Parameters.Clear();

                    MessageBox.Show("Ajout�");

                }
            }
        }
    }
}