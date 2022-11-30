namespace BookiniApplication
{
    partial class EmployeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DateEmploye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdEmploye = new System.Windows.Forms.TextBox();
            this.AgeEmploye = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.CinEmploye = new System.Windows.Forms.TextBox();
            this.NomEmploye = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ResetSearch = new System.Windows.Forms.PictureBox();
            this.EmpSearch = new System.Windows.Forms.PictureBox();
            this.EmployeSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewEmploye = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.DateEmploye);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 96);
            this.panel1.TabIndex = 1;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // DateEmploye
            // 
            this.DateEmploye.AutoSize = true;
            this.DateEmploye.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateEmploye.ForeColor = System.Drawing.Color.White;
            this.DateEmploye.Location = new System.Drawing.Point(921, 55);
            this.DateEmploye.Name = "DateEmploye";
            this.DateEmploye.Size = new System.Drawing.Size(79, 35);
            this.DateEmploye.TabIndex = 2;
            this.DateEmploye.Text = "Date";
            this.DateEmploye.Click += new System.EventHandler(this.DateEmploye_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espace de l\'employé";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdEmploye
            // 
            this.IdEmploye.Enabled = false;
            this.IdEmploye.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdEmploye.Location = new System.Drawing.Point(17, 128);
            this.IdEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdEmploye.Name = "IdEmploye";
            this.IdEmploye.PlaceholderText = "Id de l\'employé";
            this.IdEmploye.Size = new System.Drawing.Size(194, 26);
            this.IdEmploye.TabIndex = 17;
            // 
            // AgeEmploye
            // 
            this.AgeEmploye.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeEmploye.Location = new System.Drawing.Point(17, 367);
            this.AgeEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgeEmploye.Name = "AgeEmploye";
            this.AgeEmploye.PlaceholderText = "Age de l\'employé";
            this.AgeEmploye.Size = new System.Drawing.Size(194, 26);
            this.AgeEmploye.TabIndex = 16;
            this.AgeEmploye.TextChanged += new System.EventHandler(this.TelClient_TextChanged);
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.Genre.Location = new System.Drawing.Point(17, 307);
            this.Genre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(194, 28);
            this.Genre.TabIndex = 15;
            this.Genre.Text = "Genre";
            // 
            // CinEmploye
            // 
            this.CinEmploye.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CinEmploye.Location = new System.Drawing.Point(17, 248);
            this.CinEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CinEmploye.Name = "CinEmploye";
            this.CinEmploye.PlaceholderText = "Cin de l\'employé";
            this.CinEmploye.Size = new System.Drawing.Size(194, 26);
            this.CinEmploye.TabIndex = 14;
            // 
            // NomEmploye
            // 
            this.NomEmploye.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomEmploye.Location = new System.Drawing.Point(17, 187);
            this.NomEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NomEmploye.Name = "NomEmploye";
            this.NomEmploye.PlaceholderText = "Nom de l\'employé";
            this.NomEmploye.Size = new System.Drawing.Size(194, 26);
            this.NomEmploye.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(17, 427);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "Nom d\'utilisateur";
            this.Username.Size = new System.Drawing.Size(194, 26);
            this.Username.TabIndex = 18;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(17, 489);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderText = "Mot de passe";
            this.Password.Size = new System.Drawing.Size(194, 26);
            this.Password.TabIndex = 19;
            // 
            // ResetSearch
            // 
            this.ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("ResetSearch.Image")));
            this.ResetSearch.Location = new System.Drawing.Point(943, 120);
            this.ResetSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetSearch.Name = "ResetSearch";
            this.ResetSearch.Size = new System.Drawing.Size(26, 31);
            this.ResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetSearch.TabIndex = 23;
            this.ResetSearch.TabStop = false;
            this.ResetSearch.Click += new System.EventHandler(this.ResetSearch_Click);
            // 
            // EmpSearch
            // 
            this.EmpSearch.Image = ((System.Drawing.Image)(resources.GetObject("EmpSearch.Image")));
            this.EmpSearch.Location = new System.Drawing.Point(902, 120);
            this.EmpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpSearch.Name = "EmpSearch";
            this.EmpSearch.Size = new System.Drawing.Size(26, 31);
            this.EmpSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpSearch.TabIndex = 22;
            this.EmpSearch.TabStop = false;
            this.EmpSearch.Click += new System.EventHandler(this.ClientSearch_Click);
            // 
            // EmployeSearch
            // 
            this.EmployeSearch.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeSearch.Location = new System.Drawing.Point(537, 120);
            this.EmployeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeSearch.Name = "EmployeSearch";
            this.EmployeSearch.PlaceholderText = "Nom de l\'employé";
            this.EmployeSearch.Size = new System.Drawing.Size(364, 26);
            this.EmployeSearch.TabIndex = 21;
            // 
            // dataGridViewEmploye
            // 
            this.dataGridViewEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmploye.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmploye.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmploye.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewEmploye.Location = new System.Drawing.Point(351, 187);
            this.dataGridViewEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewEmploye.Name = "dataGridViewEmploye";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmploye.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmploye.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmploye.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmploye.RowTemplate.Height = 25;
            this.dataGridViewEmploye.Size = new System.Drawing.Size(797, 472);
            this.dataGridViewEmploye.TabIndex = 20;
            this.dataGridViewEmploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmploye_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(218, 565);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(118, 36);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(106, 565);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(105, 36);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(7, 565);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 36);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // EmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 687);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ResetSearch);
            this.Controls.Add(this.EmpSearch);
            this.Controls.Add(this.EmployeSearch);
            this.Controls.Add(this.dataGridViewEmploye);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.IdEmploye);
            this.Controls.Add(this.AgeEmploye);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.CinEmploye);
            this.Controls.Add(this.NomEmploye);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeForm";
            this.Load += new System.EventHandler(this.EmployeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Close;
        private Label DateEmploye;
        private Label label2;
        private TextBox IdEmploye;
        private TextBox AgeEmploye;
        private ComboBox Genre;
        private TextBox CinEmploye;
        private TextBox NomEmploye;
        private TextBox Username;
        private TextBox Password;
        private PictureBox ResetSearch;
        private PictureBox EmpSearch;
        private TextBox EmployeSearch;
        private DataGridView dataGridViewEmploye;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private System.Windows.Forms.Timer timer2;
    }
}