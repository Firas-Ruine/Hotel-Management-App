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
using System.Net.Sockets;
using System.Net;

namespace BookiniApplication
{
    public partial class EmployeForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public EmployeForm()
        {
            InitializeComponent();
        }

        public void getEmployes()
        {
            Con.Open();
            string Query = "SELECT * from Employe";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewEmploye.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            DateEmploye.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
            getEmployes();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomEmploye.Text == "" || CinEmploye.Text == "" || Genre.SelectedIndex < 0 || AgeEmploye.Text == "" || Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employe(NomEmplye,CinEmploye,GenreEmploye,AgeEmploye,PasswordEmploye,UsernameEmploye) VALUES('" + NomEmploye.Text + "','" + CinEmploye.Text + "','" + Genre.SelectedItem.ToString()+ "','" + AgeEmploye.Text + "','" + Password.Text + "','" + Username.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employé Ajouté avec succès");
            Con.Close();
            IdEmploye.Text = "";
            NomEmploye.Text = "";
            CinEmploye.Text = "";
            Genre.Items.Clear();
            Genre.ResetText();
            AgeEmploye.Text = "";
            Username.Text = "";
            Password.Text = "";
            getEmployes();

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

        private void DateEmploye_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateEmploye.Text = DateTime.Now.ToLongTimeString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NomEmploye.Text == "" || CinEmploye.Text == "" || Genre.SelectedIndex < 0 || AgeEmploye.Text == "" || Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            string Query = "UPDATE Employe set NomEmplye = '" + NomEmploye.Text + "',CinEmploye='" + CinEmploye.Text + "',GenreEmploye='" + Genre.SelectedItem.ToString() + "',AgeEmploye='" + AgeEmploye.Text + "',PasswordEmploye='" + Password.Text + "',UsernameEmploye='" + Username.Text + "' WHERE IdEmploye = '" + IdEmploye.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employé Modifié avec succès");
            Con.Close();
            IdEmploye.Text = "";
            NomEmploye.Text = "";
            CinEmploye.Text = "";
            Genre.Items.Clear();
            Genre.ResetText();
            AgeEmploye.Text = "";
            Username.Text = "";
            Password.Text = "";
            getEmployes();
        }

        private void dataGridViewEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEmploye.Rows[e.RowIndex];
                IdEmploye.Text = row.Cells[0].Value.ToString();
                NomEmploye.Text = row.Cells[1].Value.ToString();
                CinEmploye.Text = row.Cells[2].Value.ToString();
                Genre.Text = row.Cells[3].Value.ToString();
                AgeEmploye.Text = row.Cells[4].Value.ToString();
                Password.Text = row.Cells[5].Value.ToString();
                Username.Text = row.Cells[6].Value.ToString();


            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer??","Confirmer!!",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string Query = "DELETE FROM Employe where IdEmploye = '" + IdEmploye.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employé supprimé avec succès");
                Con.Close();
                IdEmploye.Text = "";
                NomEmploye.Text = "";
                CinEmploye.Text = "";
                Genre.Items.Clear();
                Genre.ResetText();
                AgeEmploye.Text = "";
                Username.Text = "";
                Password.Text = "";
                getEmployes();
            }
        }

        private void ClientSearch_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "SELECT * from Employe where NomEmplye='" + EmployeSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewEmploye.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetSearch_Click(object sender, EventArgs e)
        {
            getEmployes();
        }
    }
}
