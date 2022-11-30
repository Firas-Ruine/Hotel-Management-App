using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookiniApplication
{
    public partial class FormCategorie : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public FormCategorie()
        {
            InitializeComponent();
        }

        public void getCategories()
        {
            Con.Open();
            string Query = "SELECT * from Categorie";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewCategorie.DataSource = ds.Tables[0];
            Con.Close();
        }



        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateCategorie.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormCategorie_Load(object sender, EventArgs e)
        {
            DateCategorie.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            getCategories();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomCategorie.Text == "" || MontantCategorie.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Categorie(NomCat,MontantCat) VALUES('" + NomCategorie.Text + "','" + MontantCategorie.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Catégorie Ajoutée avec succès");
            Con.Close();
            IdCategorie.Text = "";
            NomCategorie.Text = "";
            MontantCategorie.Text = "";
            getCategories();
        }

        private void dataGridViewCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCategorie.Rows[e.RowIndex];
                IdCategorie.Text = row.Cells[0].Value.ToString();
                NomCategorie.Text = row.Cells[1].Value.ToString();
                MontantCategorie.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NomCategorie.Text == "" || MontantCategorie.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }

            Con.Open();
            string Query = "UPDATE Categorie set NomCat = '" + NomCategorie.Text + "',MontantCat='" + MontantCategorie.Text + "'WHERE IdCat = '" + IdCategorie.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Categorie Modifiée avec succès");
            Con.Close();
            IdCategorie.Text = "";
            NomCategorie.Text = "";
            MontantCategorie.Text = "";
            getCategories() ;
        }
    }
}
