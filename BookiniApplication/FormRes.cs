using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace BookiniApplication
{
    public partial class FormRes : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public FormRes()
        {
            InitializeComponent();
        }

        public void getReservations()
        {
            Con.Open();
            string Query = "SELECT * from Reservation";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRes.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FormRes_Load(object sender, EventArgs e)
        {
           
                DateChambre.Text = DateTime.Now.ToLongTimeString();
                timer1.Start();
                getReservations();
                Con.Open();
                string Query = "SELECT NomChambre from Chambre where StatusChambre='Disponible'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Chambre.Items.Add(DR[0]);

                }
            Con.Close();
            Con.Open();
            string Query1 = "SELECT NomClient from Client";
            SqlCommand cmd1 = new SqlCommand(Query1, Con);
            SqlDataReader DR1 = cmd1.ExecuteReader();
            while (DR1.Read())
            {
                Client.Items.Add(DR1[0]);

            }
            Con.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateChambre.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void dataGridViewChambre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewRes.Rows[e.RowIndex];
                Con.Open();
                SqlDataAdapter cmd1 = new SqlDataAdapter("select NomChambre from Chambre where IdChambre='" + row.Cells[1].Value.ToString() + "'", Con);
                DataTable dtable1 = new DataTable();
                cmd1.Fill(dtable1);
                SqlDataAdapter cmd2 = new SqlDataAdapter("select NomClient from Client where IdClient='" + row.Cells[2].Value.ToString() + "'", Con);
                DataTable dtable2 = new DataTable();
                cmd2.Fill(dtable2);
                IdRes.Text = row.Cells[0].Value.ToString();
                Chambre.Text = dtable1.Rows[0][0].ToString();
                Client.Text = dtable2.Rows[0][0].ToString();
                Date.Value = Convert.ToDateTime(row.Cells[3].Value);
                nbjours.Text = row.Cells[4].Value.ToString();
                Con.Close();    
            }
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Date.Text == "" || Chambre.SelectedIndex < 0 || Client.SelectedIndex < 0 || nbjours.Text=="")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Reservation(Chambre,Client,DateRes,nbJours,Montant) VALUES(@ch,@cl,@date,@nbj,@mt)", Con);
            SqlDataAdapter cmd1 = new SqlDataAdapter("select IdChambre from Chambre where  NomChambre='" + Chambre.SelectedItem + "'", Con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            cmd.Parameters.AddWithValue("@ch", dtable1.Rows[0][0].ToString());
            SqlDataAdapter cmd2 = new SqlDataAdapter("SELECT IdClient FROM Client WHERE NomClient='" + Client.SelectedItem + "'", Con);
            DataTable dtable2 = new DataTable();
            cmd2.Fill(dtable2);
            cmd.Parameters.AddWithValue("@cl", dtable2.Rows[0][0].ToString());
            SqlDataAdapter cmd3 = new SqlDataAdapter("SELECT MontantCat  from Categorie WHERE IdCat = (select CatChambre from Chambre where NomChambre='" + Chambre.SelectedItem + "')", Con);
            DataTable dtable3 = new DataTable();
            cmd3.Fill(dtable3);
            cmd.Parameters.AddWithValue("@mt", Int32.Parse(dtable3.Rows[0][0].ToString())*Int32.Parse(nbjours.Text));
            cmd.Parameters.AddWithValue("@date", Date.Value.Date.Year + "/" + Date.Value.Date.Month + "/" + Date.Value.Date.Day);
            cmd.Parameters.AddWithValue("@nbj", nbjours.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd4 = new SqlCommand("UPDATE Chambre SET StatusChambre='Réservée' WHERE NomChambre='" + Chambre.SelectedItem + "'", Con);
            cmd4.ExecuteNonQuery();
            MessageBox.Show("Réservation Ajoutée avec succès");
            Con.Close();
            IdRes.Text = "";
            Chambre.ResetText();
            Client.ResetText();
            Date.Value = DateTime.Now;
            nbjours.Text = "";
            getReservations();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Date.Text == "" || Chambre.SelectedIndex < 0 || Client.SelectedIndex < 0 || nbjours.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Reservation SET Chambre=@ch,Client=@cl,DateRes=@date,nbJours=@nbj,Montant=@mt WHERE IdRes='"+IdRes.Text+"'", Con);
            SqlDataAdapter cmd1 = new SqlDataAdapter("SELECT IdChambre FROM Chambre WHERE  NomChambre='" + Chambre.SelectedItem + "'", Con);
            DataTable dtable1 = new DataTable();
            cmd1.Fill(dtable1);
            cmd.Parameters.AddWithValue("@ch", dtable1.Rows[0][0].ToString());
            SqlDataAdapter cmd2 = new SqlDataAdapter("SELECT IdClient FROM Client WHERE NomClient='" + Client.SelectedItem + "'", Con);
            DataTable dtable2 = new DataTable();
            cmd2.Fill(dtable2);
            cmd.Parameters.AddWithValue("@cl", dtable2.Rows[0][0].ToString());
            SqlDataAdapter cmd3 = new SqlDataAdapter("SELECT MontantCat  FROM Categorie WHERE IdCat = (SELECT CatChambre FROM Chambre WHERE NomChambre='" + Chambre.SelectedItem + "')", Con);
            DataTable dtable3 = new DataTable();
            cmd3.Fill(dtable3);
            cmd.Parameters.AddWithValue("@mt", Int32.Parse(dtable3.Rows[0][0].ToString()) * Int32.Parse(nbjours.Text));
            cmd.Parameters.AddWithValue("@date", Date.Value.Date.Year + "/" + Date.Value.Date.Month + "/" + Date.Value.Date.Day);
            cmd.Parameters.AddWithValue("@nbj", nbjours.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Réservation Modifiée avec succès");
            Con.Close();
            IdRes.Text = "";
            Chambre.ResetText();
            Client.ResetText();
            Date.Value = DateTime.Now;
            nbjours.Text = "";
            getReservations();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer??", "Confirmer!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string Query = "DELETE FROM Reservation where IdRes = '" + IdRes.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("UPDATE Chambre SET StatusChambre='Disponible' WHERE NomChambre='" + Chambre.Text + "'", Con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Réservation supprimée avec succès");
                Con.Close();
                IdRes.Text = "";
                Chambre.ResetText();
                Client.ResetText();
                Date.Value = DateTime.Now;
                nbjours.Text = "";
                getReservations();
            }
        }

        private void ChambreSearch_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "SELECT * from Reservation where IdRes='" + EmployeSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewRes.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetSearch_Click(object sender, EventArgs e)
        {
            getReservations();
            EmployeSearch.Text = "";
        }

        private void EmployeSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
