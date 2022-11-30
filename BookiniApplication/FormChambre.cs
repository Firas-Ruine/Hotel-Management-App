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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookiniApplication
{
    public partial class FormChambre : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public FormChambre()
        {
            InitializeComponent();
        }

        public void getChambres()
        {
            Con.Open();
            string Query = "SELECT * from Chambre";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewChambre.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateChambre.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormChambre_Load(object sender, EventArgs e)
        {
            DateChambre.Text = DateTime.Now.ToLongTimeString();
            timer3.Start();
            getChambres();
            Con.Open();
            string Query = "SELECT NomCat from Categorie";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                CatChambre.Items.Add(DR[0]);

            }
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomChambre.Text == "" || CatChambre.SelectedIndex <0 || StatusChambre.SelectedIndex <0)
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Chambre(NomChambre,CatChambre,StatusChambre) VALUES(@nom,@cat,@status)", Con);
            cmd.Parameters.AddWithValue("@nom", NomChambre.Text);
            cmd.Parameters.AddWithValue("@status", StatusChambre.SelectedItem.ToString());
            SqlDataAdapter cmd1 = new SqlDataAdapter("select IdCat from Categorie where NomCat='" + CatChambre.SelectedItem + "'", Con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            cmd.Parameters.AddWithValue("@cat", dtable1.Rows[0][0].ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chambre Ajoutée avec succès");
            Con.Close();
            IdChambre.Text = "";
            NomChambre.Text = "";
            CatChambre.ResetText();
            StatusChambre.ResetText();
            getChambres();
        }

        private void dataGridViewChambre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewChambre.Rows[e.RowIndex];
                Con.Open();
                SqlDataAdapter cmd1 = new SqlDataAdapter("select NomCat from Categorie where IdCat='" + row.Cells[2].Value.ToString() + "'", Con);
                DataTable dtable1 = new DataTable();
                cmd1.Fill(dtable1);
                IdChambre.Text = row.Cells[0].Value.ToString();
                NomChambre.Text = row.Cells[1].Value.ToString();
                CatChambre.Text = dtable1.Rows[0][0].ToString();
                StatusChambre.Text = row.Cells[3].Value.ToString();
                Con.Close();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NomChambre.Text == "" || CatChambre.SelectedIndex < 0 || StatusChambre.SelectedIndex < 0)
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Chambre SET NomChambre=@nom,CatChambre=@cat,StatusChambre=@status WHERE IdChambre=@id", Con);
            cmd.Parameters.AddWithValue("@id", IdChambre.Text);
            cmd.Parameters.AddWithValue("@nom", NomChambre.Text);
            cmd.Parameters.AddWithValue("@status", StatusChambre.SelectedItem.ToString());
            SqlDataAdapter cmd1 = new SqlDataAdapter("SELECT IdCat FROM Categorie WHERE NomCat='" + CatChambre.SelectedItem + "'", Con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            cmd.Parameters.AddWithValue("@cat", dtable1.Rows[0][0].ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chambre Modifiée avec succès");
            Con.Close();
            IdChambre.Text = "";
            NomChambre.Text = "";
            CatChambre.ResetText();
            StatusChambre.ResetText();
            getChambres();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer??", "Confirmer!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string Query = "DELETE FROM Chambre where IdChambre = '" + IdChambre.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chambre supprimée avec succès");
                Con.Close();
                IdChambre.Text = "";
                NomChambre.Text = "";
                CatChambre.ResetText();
                StatusChambre.ResetText();
                getChambres();
            }
        }

        private void EmployeSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpSearch_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "SELECT * from Employe where NomEmplye='" + EmployeSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewChambre.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetSearch_Click(object sender, EventArgs e)
        {
            getChambres();
        }
    }
}
