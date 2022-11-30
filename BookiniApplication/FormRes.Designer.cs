namespace BookiniApplication
{
    partial class FormRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResetSearch = new System.Windows.Forms.PictureBox();
            this.ChambreSearch = new System.Windows.Forms.PictureBox();
            this.EmployeSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.nbjours = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Client = new System.Windows.Forms.ComboBox();
            this.IdRes = new System.Windows.Forms.TextBox();
            this.Chambre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.DateChambre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChambreSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(222, 499);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(118, 36);
            this.DeleteBtn.TabIndex = 54;
            this.DeleteBtn.Text = "Annuler";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditBtn.Location = new System.Drawing.Point(110, 499);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(105, 36);
            this.EditBtn.TabIndex = 53;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddBtn.Location = new System.Drawing.Point(10, 499);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 36);
            this.AddBtn.TabIndex = 52;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ResetSearch
            // 
            this.ResetSearch.Image = ((System.Drawing.Image)(resources.GetObject("ResetSearch.Image")));
            this.ResetSearch.Location = new System.Drawing.Point(963, 140);
            this.ResetSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetSearch.Name = "ResetSearch";
            this.ResetSearch.Size = new System.Drawing.Size(26, 31);
            this.ResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetSearch.TabIndex = 51;
            this.ResetSearch.TabStop = false;
            this.ResetSearch.Click += new System.EventHandler(this.ResetSearch_Click);
            // 
            // ChambreSearch
            // 
            this.ChambreSearch.Image = ((System.Drawing.Image)(resources.GetObject("ChambreSearch.Image")));
            this.ChambreSearch.Location = new System.Drawing.Point(922, 140);
            this.ChambreSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChambreSearch.Name = "ChambreSearch";
            this.ChambreSearch.Size = new System.Drawing.Size(26, 31);
            this.ChambreSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChambreSearch.TabIndex = 50;
            this.ChambreSearch.TabStop = false;
            this.ChambreSearch.Click += new System.EventHandler(this.ChambreSearch_Click);
            // 
            // EmployeSearch
            // 
            this.EmployeSearch.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeSearch.Location = new System.Drawing.Point(558, 140);
            this.EmployeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeSearch.Name = "EmployeSearch";
            this.EmployeSearch.PlaceholderText = "Id de réservation";
            this.EmployeSearch.Size = new System.Drawing.Size(364, 26);
            this.EmployeSearch.TabIndex = 49;
            this.EmployeSearch.TextChanged += new System.EventHandler(this.EmployeSearch_TextChanged);
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRes.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewRes.Location = new System.Drawing.Point(371, 207);
            this.dataGridViewRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRes.RowTemplate.Height = 25;
            this.dataGridViewRes.Size = new System.Drawing.Size(797, 472);
            this.dataGridViewRes.TabIndex = 48;
            this.dataGridViewRes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChambre_CellContentClick);
            // 
            // nbjours
            // 
            this.nbjours.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbjours.Location = new System.Drawing.Point(17, 429);
            this.nbjours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbjours.Name = "nbjours";
            this.nbjours.PlaceholderText = "Nombre de jour";
            this.nbjours.Size = new System.Drawing.Size(194, 26);
            this.nbjours.TabIndex = 46;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(17, 360);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(194, 27);
            this.Date.TabIndex = 45;
            // 
            // Client
            // 
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(17, 291);
            this.Client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(194, 28);
            this.Client.TabIndex = 44;
            this.Client.Text = "Client";
            // 
            // IdRes
            // 
            this.IdRes.Enabled = false;
            this.IdRes.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdRes.Location = new System.Drawing.Point(17, 155);
            this.IdRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdRes.Name = "IdRes";
            this.IdRes.PlaceholderText = "Id de réservation";
            this.IdRes.Size = new System.Drawing.Size(194, 26);
            this.IdRes.TabIndex = 43;
            // 
            // Chambre
            // 
            this.Chambre.FormattingEnabled = true;
            this.Chambre.Location = new System.Drawing.Point(17, 225);
            this.Chambre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chambre.Name = "Chambre";
            this.Chambre.Size = new System.Drawing.Size(194, 28);
            this.Chambre.TabIndex = 42;
            this.Chambre.Text = "Chambre";
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 96);
            this.panel1.TabIndex = 41;
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
            // DateChambre
            // 
            this.DateChambre.AutoSize = true;
            this.DateChambre.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateChambre.ForeColor = System.Drawing.Color.White;
            this.DateChambre.Location = new System.Drawing.Point(921, 55);
            this.DateChambre.Name = "DateChambre";
            this.DateChambre.Size = new System.Drawing.Size(79, 35);
            this.DateChambre.TabIndex = 2;
            this.DateChambre.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espace de Réservation";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 687);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ResetSearch);
            this.Controls.Add(this.ChambreSearch);
            this.Controls.Add(this.EmployeSearch);
            this.Controls.Add(this.dataGridViewRes);
            this.Controls.Add(this.nbjours);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.IdRes);
            this.Controls.Add(this.Chambre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRes";
            this.Load += new System.EventHandler(this.FormRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChambreSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private PictureBox ResetSearch;
        private PictureBox ChambreSearch;
        private TextBox EmployeSearch;
        private DataGridView dataGridViewRes;
        private TextBox montant;
        private TextBox nbjours;
        private DateTimePicker Date;
        private ComboBox Client;
        private TextBox IdRes;
        private ComboBox Chambre;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox Close;
        private Label DateChambre;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}