namespace BookiniApplication
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            this.CinClient = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Etat = new System.Windows.Forms.ComboBox();
            this.TelClient = new System.Windows.Forms.TextBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NomSearch = new System.Windows.Forms.TextBox();
            this.ClientSearch = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IdClient = new System.Windows.Forms.TextBox();
            this.ResetSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 96);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1151, 11);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 31);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 14;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(921, 55);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 35);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espace de client";
            // 
            // NomClient
            // 
            this.NomClient.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomClient.Location = new System.Drawing.Point(17, 185);
            this.NomClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NomClient.Name = "NomClient";
            this.NomClient.PlaceholderText = "Nom de client";
            this.NomClient.Size = new System.Drawing.Size(194, 26);
            this.NomClient.TabIndex = 1;
            this.NomClient.TextChanged += new System.EventHandler(this.NomClient_TextChanged);
            // 
            // CinClient
            // 
            this.CinClient.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CinClient.Location = new System.Drawing.Point(17, 260);
            this.CinClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CinClient.Name = "CinClient";
            this.CinClient.PlaceholderText = "Cin de client";
            this.CinClient.Size = new System.Drawing.Size(194, 26);
            this.CinClient.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(17, 340);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(194, 27);
            this.Date.TabIndex = 3;
            // 
            // Etat
            // 
            this.Etat.FormattingEnabled = true;
            this.Etat.Items.AddRange(new object[] {
            "Célibataire",
            "Marié(e)"});
            this.Etat.Location = new System.Drawing.Point(17, 419);
            this.Etat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(194, 28);
            this.Etat.TabIndex = 4;
            this.Etat.Text = "Etat Civil";
            this.Etat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TelClient
            // 
            this.TelClient.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TelClient.Location = new System.Drawing.Point(17, 501);
            this.TelClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TelClient.Name = "TelClient";
            this.TelClient.PlaceholderText = "Tél de client";
            this.TelClient.Size = new System.Drawing.Size(194, 26);
            this.TelClient.TabIndex = 5;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClient.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewClient.Location = new System.Drawing.Point(369, 185);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClient.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClient.RowTemplate.Height = 25;
            this.dataGridViewClient.Size = new System.Drawing.Size(797, 472);
            this.dataGridViewClient.TabIndex = 6;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(14, 572);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 36);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(113, 572);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(105, 36);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(225, 572);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(118, 36);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NomSearch
            // 
            this.NomSearch.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomSearch.Location = new System.Drawing.Point(555, 119);
            this.NomSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NomSearch.Name = "NomSearch";
            this.NomSearch.PlaceholderText = "Nom de client";
            this.NomSearch.Size = new System.Drawing.Size(364, 26);
            this.NomSearch.TabIndex = 10;
            this.NomSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ClientSearch
            // 
            this.ClientSearch.Image = ((System.Drawing.Image)(resources.GetObject("ClientSearch.Image")));
            this.ClientSearch.Location = new System.Drawing.Point(920, 119);
            this.ClientSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientSearch.Name = "ClientSearch";
            this.ClientSearch.Size = new System.Drawing.Size(26, 31);
            this.ClientSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientSearch.TabIndex = 11;
            this.ClientSearch.TabStop = false;
            this.ClientSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // IdClient
            // 
            this.IdClient.Enabled = false;
            this.IdClient.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdClient.Location = new System.Drawing.Point(17, 119);
            this.IdClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdClient.Name = "IdClient";
            this.IdClient.PlaceholderText = "Id de client";
            this.IdClient.Size = new System.Drawing.Size(194, 26);
            this.IdClient.TabIndex = 12;
            this.IdClient.TextChanged += new System.EventHandler(this.IdClient_TextChanged);
            // 
            // ResetSearch
            // 
            this.ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("ResetSearch.Image")));
            this.ResetSearch.Location = new System.Drawing.Point(961, 119);
            this.ResetSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetSearch.Name = "ResetSearch";
            this.ResetSearch.Size = new System.Drawing.Size(26, 31);
            this.ResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetSearch.TabIndex = 13;
            this.ResetSearch.TabStop = false;
            this.ResetSearch.Click += new System.EventHandler(this.ResetSearch_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 687);
            this.Controls.Add(this.ResetSearch);
            this.Controls.Add(this.IdClient);
            this.Controls.Add(this.ClientSearch);
            this.Controls.Add(this.NomSearch);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.TelClient);
            this.Controls.Add(this.Etat);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CinClient);
            this.Controls.Add(this.NomClient);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox NomClient;
        private TextBox CinClient;
        private DateTimePicker Date;
        private ComboBox Etat;
        private TextBox TelClient;
        private DataGridView dataGridViewClient;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private TextBox NomSearch;
        private PictureBox ClientSearch;
        private Label DateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox IdClient;
        private PictureBox ResetSearch;
        private PictureBox pictureBox1;
        private PictureBox Close;
    }
}