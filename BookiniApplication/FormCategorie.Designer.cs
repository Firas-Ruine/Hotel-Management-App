namespace BookiniApplication
{
    partial class FormCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DateCategorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IdCategorie = new System.Windows.Forms.TextBox();
            this.NomCategorie = new System.Windows.Forms.TextBox();
            this.MontantCategorie = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResetSearch = new System.Windows.Forms.PictureBox();
            this.EmpSearch = new System.Windows.Forms.PictureBox();
            this.EmployeSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCategorie = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.DateCategorie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 72);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1007, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 23);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 14;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DateCategorie
            // 
            this.DateCategorie.AutoSize = true;
            this.DateCategorie.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateCategorie.ForeColor = System.Drawing.Color.White;
            this.DateCategorie.Location = new System.Drawing.Point(806, 41);
            this.DateCategorie.Name = "DateCategorie";
            this.DateCategorie.Size = new System.Drawing.Size(60, 28);
            this.DateCategorie.TabIndex = 2;
            this.DateCategorie.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espace de Catégorie";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IdCategorie
            // 
            this.IdCategorie.Enabled = false;
            this.IdCategorie.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdCategorie.Location = new System.Drawing.Point(15, 115);
            this.IdCategorie.Name = "IdCategorie";
            this.IdCategorie.PlaceholderText = "Id de catégorie";
            this.IdCategorie.Size = new System.Drawing.Size(170, 23);
            this.IdCategorie.TabIndex = 23;
            // 
            // NomCategorie
            // 
            this.NomCategorie.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomCategorie.Location = new System.Drawing.Point(15, 175);
            this.NomCategorie.Name = "NomCategorie";
            this.NomCategorie.PlaceholderText = "Nom de catégorie";
            this.NomCategorie.Size = new System.Drawing.Size(170, 23);
            this.NomCategorie.TabIndex = 22;
            // 
            // MontantCategorie
            // 
            this.MontantCategorie.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MontantCategorie.Location = new System.Drawing.Point(15, 231);
            this.MontantCategorie.Name = "MontantCategorie";
            this.MontantCategorie.PlaceholderText = "Montant de catégorie";
            this.MontantCategorie.Size = new System.Drawing.Size(170, 23);
            this.MontantCategorie.TabIndex = 24;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(191, 299);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 27);
            this.DeleteBtn.TabIndex = 32;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(93, 299);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(92, 27);
            this.EditBtn.TabIndex = 31;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(6, 299);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(83, 27);
            this.AddBtn.TabIndex = 30;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResetSearch
            // 
            this.ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("ResetSearch.Image")));
            this.ResetSearch.Location = new System.Drawing.Point(842, 86);
            this.ResetSearch.Name = "ResetSearch";
            this.ResetSearch.Size = new System.Drawing.Size(23, 23);
            this.ResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetSearch.TabIndex = 37;
            this.ResetSearch.TabStop = false;
            // 
            // EmpSearch
            // 
            this.EmpSearch.Image = ((System.Drawing.Image)(resources.GetObject("EmpSearch.Image")));
            this.EmpSearch.Location = new System.Drawing.Point(806, 86);
            this.EmpSearch.Name = "EmpSearch";
            this.EmpSearch.Size = new System.Drawing.Size(23, 23);
            this.EmpSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmpSearch.TabIndex = 36;
            this.EmpSearch.TabStop = false;
            // 
            // EmployeSearch
            // 
            this.EmployeSearch.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeSearch.Location = new System.Drawing.Point(487, 86);
            this.EmployeSearch.Name = "EmployeSearch";
            this.EmployeSearch.PlaceholderText = "Nom de catégorie";
            this.EmployeSearch.Size = new System.Drawing.Size(319, 23);
            this.EmployeSearch.TabIndex = 35;
            // 
            // dataGridViewCategorie
            // 
            this.dataGridViewCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorie.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategorie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCategorie.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewCategorie.Location = new System.Drawing.Point(324, 136);
            this.dataGridViewCategorie.Name = "dataGridViewCategorie";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategorie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCategorie.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCategorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCategorie.RowTemplate.Height = 25;
            this.dataGridViewCategorie.Size = new System.Drawing.Size(697, 354);
            this.dataGridViewCategorie.TabIndex = 34;
            this.dataGridViewCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategorie_CellContentClick);
            // 
            // FormCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.ResetSearch);
            this.Controls.Add(this.EmpSearch);
            this.Controls.Add(this.EmployeSearch);
            this.Controls.Add(this.dataGridViewCategorie);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MontantCategorie);
            this.Controls.Add(this.IdCategorie);
            this.Controls.Add(this.NomCategorie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategorie";
            this.Load += new System.EventHandler(this.FormCategorie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Close;
        private Label DateCategorie;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private TextBox IdCategorie;
        private TextBox NomCategorie;
        private TextBox MontantCategorie;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private PictureBox ResetSearch;
        private PictureBox EmpSearch;
        private TextBox EmployeSearch;
        private DataGridView dataGridViewCategorie;
    }
}