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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookiniApplication
{
    public partial class Clients : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Firas\OneDrive\Documents\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public void getClients()
        {
            Con.Open();
            string Query = "SELECT * from Client";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewClient.DataSource = ds.Tables[0];
            Con.Close();
        }

        public Clients()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "SELECT * from Client where NomClient='"+NomSearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridViewClient.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            getClients();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NomClient.Text == "" || CinClient.Text == "" || Date.Text == "" || Etat.SelectedIndex<0 || TelClient.Text == "" )
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Client(NomClient,CinClient,dateNaissClient,EtatCivil,TelClient) VALUES('" + NomClient.Text + "','"+CinClient.Text+"','" + Date.Value.Date.Year + "/" +Date.Value.Date.Month + "/" + Date.Value.Date.Day + "','" +Etat.SelectedItem.ToString()+"','"+TelClient.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Ajouté avec succès");
            Con.Close();
            IdClient.Text = "";
            NomClient.Text = "";
            CinClient.Text = "";
            Date.Value = DateTime.Now;
            Etat.Items.Clear();
            Etat.ResetText();
            TelClient.Text = "";
            getClients();
        }

        private void NomClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NomClient.Text == "" || CinClient.Text == "" || Date.Text == "" || Etat.SelectedIndex < 0 || TelClient.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires!");
                return;
            }
            Con.Open();
            string Query = "UPDATE Client set NomClient = '" + NomClient.Text + "',CinClient='"+CinClient.Text+ "',dateNaissClient='"+ Date.Value.Date.Year + "/" + Date.Value.Date.Month + "/" + Date.Value.Date.Day + "',EtatCivil='"+ Etat.SelectedItem.ToString() + "',TelClient='"+ TelClient.Text + "' WHERE IdClient = '"+ IdClient.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Modifié avec succès");
            Con.Close();
            IdClient.Text = "";
            NomClient.Text = "";
            CinClient.Text = "";
            Date.Value = DateTime.Now;
            Etat.ResetText();
            TelClient.Text = "";
            getClients();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClient.Rows[e.RowIndex];
                IdClient.Text = row.Cells[0].Value.ToString();
                NomClient.Text = row.Cells[1].Value.ToString();
                CinClient.Text = row.Cells[2].Value.ToString();
                Date.Value = Convert.ToDateTime(row.Cells[3].Value);
                Etat.Text = row.Cells[4].Value.ToString();
                TelClient.Text = row.Cells[5].Value.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer??", "Confirmer!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Con.Open();
                string Query = "DELETE FROM Client where IdClient = '" + IdClient.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client supprimé avec succès");
                Con.Close();
                IdClient.Text = "";
                NomClient.Text = "";
                CinClient.Text = "";
                Date.Value = DateTime.Now;
                Etat.Items.Clear();
                Etat.ResetText();
                TelClient.Text = "";
                getClients();
            }
        }

        private void ResetSearch_Click(object sender, EventArgs e)
        {
            getClients();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
