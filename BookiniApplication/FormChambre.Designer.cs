namespace BookiniApplication
{
    partial class FormChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChambre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DateChambre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.IdChambre = new System.Windows.Forms.TextBox();
            this.CatChambre = new System.Windows.Forms.ComboBox();
            this.StatusChambre = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResetSearch = new System.Windows.Forms.PictureBox();
            this.ChambreSearch = new System.Windows.Forms.PictureBox();
            this.EmployeSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewChambre = new System.Windows.Forms.DataGridView();
            this.NomChambre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChambreSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.DateChambre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 72);
            this.panel1.TabIndex = 2;
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
            // DateChambre
            // 
            this.DateChambre.AutoSize = true;
            this.DateChambre.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateChambre.ForeColor = System.Drawing.Color.White;
            this.DateChambre.Location = new System.Drawing.Point(806, 41);
            this.DateChambre.Name = "DateChambre";
            this.DateChambre.Size = new System.Drawing.Size(60, 28);
            this.DateChambre.TabIndex = 2;
            this.DateChambre.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espace de Chambre";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // IdChambre
            // 
            this.IdChambre.Enabled = false;
            this.IdChambre.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdChambre.Location = new System.Drawing.Point(15, 113);
            this.IdChambre.Name = "IdChambre";
            this.IdChambre.PlaceholderText = "Id de chambre";
            this.IdChambre.Size = new System.Drawing.Size(170, 23);
            this.IdChambre.TabIndex = 21;
            // 
            // CatChambre
            // 
            this.CatChambre.FormattingEnabled = true;
            this.CatChambre.Location = new System.Drawing.Point(15, 216);
            this.CatChambre.Name = "CatChambre";
            this.CatChambre.Size = new System.Drawing.Size(170, 23);
            this.CatChambre.TabIndex = 20;
            this.CatChambre.Text = "Catégorie";
            // 
            // StatusChambre
            // 
            this.StatusChambre.FormattingEnabled = true;
            this.StatusChambre.Items.AddRange(new object[] {
            "Disponible",
            "Réservée"});
            this.StatusChambre.Location = new System.Drawing.Point(15, 265);
            this.StatusChambre.Name = "StatusChambre";
            this.StatusChambre.Size = new System.Drawing.Size(170, 23);
            this.StatusChambre.TabIndex = 22;
            this.StatusChambre.Text = "Status";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(191, 330);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 27);
            this.DeleteBtn.TabIndex = 29;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(93, 330);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(92, 27);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(6, 330);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(83, 27);
            this.AddBtn.TabIndex = 27;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResetSearch
            // 
            this.ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("ResetSearch.Image")));
            this.ResetSearch.Location = new System.Drawing.Point(838, 99);
            this.ResetSearch.Name = "ResetSearch";
            this.ResetSearch.Size = new System.Drawing.Size(23, 23);
            this.ResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetSearch.TabIndex = 33;
            this.ResetSearch.TabStop = false;
            this.ResetSearch.Click += new System.EventHandler(this.ResetSearch_Click);
            // 
            // ChambreSearch
            // 
            this.ChambreSearch.Image = ((System.Drawing.Image)(resources.GetObject("ChambreSearch.Image")));
            this.ChambreSearch.Location = new System.Drawing.Point(802, 99);
            this.ChambreSearch.Name = "ChambreSearch";
            this.ChambreSearch.Size = new System.Drawing.Size(23, 23);
            this.ChambreSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChambreSearch.TabIndex = 32;
            this.ChambreSearch.TabStop = false;
            this.ChambreSearch.Click += new System.EventHandler(this.EmpSearch_Click);
            // 
            // EmployeSearch
            // 
            this.EmployeSearch.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeSearch.Location = new System.Drawing.Point(483, 99);
            this.EmployeSearch.Name = "EmployeSearch";
            this.EmployeSearch.PlaceholderText = "Nom de chambre";
            this.EmployeSearch.Size = new System.Drawing.Size(319, 23);
            this.EmployeSearch.TabIndex = 31;
            this.EmployeSearch.TextChanged += new System.EventHandler(this.EmployeSearch_TextChanged);
            // 
            // dataGridViewChambre
            // 
            this.dataGridViewChambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChambre.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChambre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChambre.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewChambre.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewChambre.Location = new System.Drawing.Point(320, 149);
            this.dataGridViewChambre.Name = "dataGridViewChambre";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChambre.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewChambre.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewChambre.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewChambre.RowTemplate.Height = 25;
            this.dataGridViewChambre.Size = new System.Drawing.Size(697, 354);
            this.dataGridViewChambre.TabIndex = 30;
            this.dataGridViewChambre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChambre_CellContentClick);
            // 
            // NomChambre
            // 
            this.NomChambre.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomChambre.Location = new System.Drawing.Point(15, 164);
            this.NomChambre.Name = "NomChambre";
            this.NomChambre.PlaceholderText = "Nom de chambre";
            this.NomChambre.Size = new System.Drawing.Size(170, 23);
            this.NomChambre.TabIndex = 18;
            // 
            // FormChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.ResetSearch);
            this.Controls.Add(this.ChambreSearch);
            this.Controls.Add(this.EmployeSearch);
            this.Controls.Add(this.dataGridViewChambre);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StatusChambre);
            this.Controls.Add(this.IdChambre);
            this.Controls.Add(this.CatChambre);
            this.Controls.Add(this.NomChambre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChambre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChambre";
            this.Load += new System.EventHandler(this.FormChambre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChambreSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Close;
        private Label DateChambre;
        private Label label2;
        private System.Windows.Forms.Timer timer3;
        private TextBox IdChambre;
        private ComboBox CatChambre;
        private ComboBox StatusChambre;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private PictureBox ResetSearch;
        private PictureBox ChambreSearch;
        private TextBox EmployeSearch;
        private DataGridView dataGridViewChambre;
        private TextBox NomChambre;
    }
}