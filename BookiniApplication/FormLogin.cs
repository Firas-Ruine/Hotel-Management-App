
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace BookiniApplication

{
    public partial class FormLogin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employe where UsernameEmploye='"+Username.Text+"' and PasswordEmploye= '"+Password.Text+"' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte");
            }
            Con.Close();
        }
    }
}