

namespace Evente_UI
{
    partial class PregledKorisnika
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKorisnika));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IzvjestajiNavBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pocetna = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KorisniciGridView = new System.Windows.Forms.DataGridView();
            this.korisnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.korisniciResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.PretragaInput = new System.Windows.Forms.MaskedTextBox();
            this.PretragaKorisnici_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Izmijeni = new System.Windows.Forms.Button();
            this.BrisanjeKorisnika_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IzvjestajiNavBtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Pocetna);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 625);
            this.panel1.TabIndex = 0;
            // 
            // IzvjestajiNavBtn
            // 
            this.IzvjestajiNavBtn.FlatAppearance.BorderSize = 0;
            this.IzvjestajiNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IzvjestajiNavBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzvjestajiNavBtn.ForeColor = System.Drawing.Color.White;
            this.IzvjestajiNavBtn.Image = global::Evente_UI.Properties.Resources.Izvjestaji;
            this.IzvjestajiNavBtn.Location = new System.Drawing.Point(0, 519);
            this.IzvjestajiNavBtn.Name = "IzvjestajiNavBtn";
            this.IzvjestajiNavBtn.Size = new System.Drawing.Size(148, 91);
            this.IzvjestajiNavBtn.TabIndex = 6;
            this.IzvjestajiNavBtn.Text = "Izvještaji";
            this.IzvjestajiNavBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IzvjestajiNavBtn.UseVisualStyleBackColor = true;
            this.IzvjestajiNavBtn.Click += new System.EventHandler(this.IzvjestajiNavBtn_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Evente_UI.Properties.Resources.icons8_train_ticket_32;
            this.button4.Location = new System.Drawing.Point(0, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 91);
            this.button4.TabIndex = 4;
            this.button4.Text = "Karte";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Evente_UI.Properties.Resources.Event_icon;
            this.button3.Location = new System.Drawing.Point(3, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eventi";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Evente_UI.Properties.Resources.Users_icon;
            this.button2.Location = new System.Drawing.Point(3, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "Korisnici";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pocetna
            // 
            this.Pocetna.FlatAppearance.BorderSize = 0;
            this.Pocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pocetna.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pocetna.ForeColor = System.Drawing.Color.White;
            this.Pocetna.Image = global::Evente_UI.Properties.Resources.Home_icon;
            this.Pocetna.Location = new System.Drawing.Point(0, 131);
            this.Pocetna.Name = "Pocetna";
            this.Pocetna.Size = new System.Drawing.Size(148, 91);
            this.Pocetna.TabIndex = 1;
            this.Pocetna.Text = "Početna";
            this.Pocetna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pocetna.UseVisualStyleBackColor = true;
            this.Pocetna.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 125);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Evente_UI.Properties.Resources._82d65338_e433_47c2_84a8_a6c522ed21d4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(151, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 125);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pregled korisnika";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(925, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "Odjava";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(895, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli " + Global.prijavljeniKorisnik.Ime;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KorisniciGridView
            // 
            this.KorisniciGridView.AllowUserToAddRows = false;
            this.KorisniciGridView.AllowUserToDeleteRows = false;
            this.KorisniciGridView.AutoGenerateColumns = false;
            this.KorisniciGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.KorisniciGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.KorisniciGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.KorisniciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KorisniciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikIdDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.KorisniciGridView.DataSource = this.korisniciResultBindingSource;
            this.KorisniciGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.KorisniciGridView.Location = new System.Drawing.Point(157, 228);
            this.KorisniciGridView.Name = "KorisniciGridView";
            this.KorisniciGridView.ReadOnly = true;
            this.KorisniciGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.KorisniciGridView.Size = new System.Drawing.Size(1075, 397);
            this.KorisniciGridView.TabIndex = 4;
            this.KorisniciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KorisniciGridView_CellContentClick);
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            this.korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "KorisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.HeaderText = "KorisnikId";
            this.korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            this.korisnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikIdDataGridViewTextBoxColumn.Visible = false;
            this.korisnikIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.imeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.prezimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 210;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.telefonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.korisnickoImeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "Korisnicko ime";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.statusDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // korisniciResultBindingSource
            // 
            this.korisniciResultBindingSource.DataSource = typeof(Evente_API.Models.Korisnici_Result);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime i prezime";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PretragaInput
            // 
            this.PretragaInput.Location = new System.Drawing.Point(359, 154);
            this.PretragaInput.Name = "PretragaInput";
            this.PretragaInput.Size = new System.Drawing.Size(196, 32);
            this.PretragaInput.TabIndex = 7;
            // 
            // PretragaKorisnici_btn
            // 
            this.PretragaKorisnici_btn.BackColor = System.Drawing.Color.White;
            this.PretragaKorisnici_btn.FlatAppearance.BorderSize = 0;
            this.PretragaKorisnici_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PretragaKorisnici_btn.ForeColor = System.Drawing.Color.Black;
            this.PretragaKorisnici_btn.Location = new System.Drawing.Point(578, 152);
            this.PretragaKorisnici_btn.Name = "PretragaKorisnici_btn";
            this.PretragaKorisnici_btn.Size = new System.Drawing.Size(88, 30);
            this.PretragaKorisnici_btn.TabIndex = 14;
            this.PretragaKorisnici_btn.Text = "Pretrazi";
            this.PretragaKorisnici_btn.UseVisualStyleBackColor = false;
            this.PretragaKorisnici_btn.Click += new System.EventHandler(this.PretragaKorisnici_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(157, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // Izmijeni
            // 
            this.Izmijeni.BackColor = System.Drawing.Color.White;
            this.Izmijeni.FlatAppearance.BorderSize = 0;
            this.Izmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izmijeni.ForeColor = System.Drawing.Color.Black;
            this.Izmijeni.Location = new System.Drawing.Point(811, 155);
            this.Izmijeni.Name = "Izmijeni";
            this.Izmijeni.Size = new System.Drawing.Size(88, 30);
            this.Izmijeni.TabIndex = 16;
            this.Izmijeni.Text = "Izmijeni";
            this.Izmijeni.UseVisualStyleBackColor = false;
            this.Izmijeni.Click += new System.EventHandler(this.Izmijeni_Click);
            // 
            // BrisanjeKorisnika_btn
            // 
            this.BrisanjeKorisnika_btn.BackColor = System.Drawing.Color.DarkRed;
            this.BrisanjeKorisnika_btn.FlatAppearance.BorderSize = 0;
            this.BrisanjeKorisnika_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrisanjeKorisnika_btn.ForeColor = System.Drawing.Color.White;
            this.BrisanjeKorisnika_btn.Location = new System.Drawing.Point(951, 155);
            this.BrisanjeKorisnika_btn.Name = "BrisanjeKorisnika_btn";
            this.BrisanjeKorisnika_btn.Size = new System.Drawing.Size(157, 30);
            this.BrisanjeKorisnika_btn.TabIndex = 17;
            this.BrisanjeKorisnika_btn.Text = "Obriši korisnika";
            this.BrisanjeKorisnika_btn.UseVisualStyleBackColor = false;
            this.BrisanjeKorisnika_btn.Click += new System.EventHandler(this.BrisanjeKorisnika_btn_Click);
            // 
            // PregledKorisnika
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1232, 625);
            this.Controls.Add(this.BrisanjeKorisnika_btn);
            this.Controls.Add(this.Izmijeni);
            this.Controls.Add(this.PretragaKorisnici_btn);
            this.Controls.Add(this.PretragaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KorisniciGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evente";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pocetna;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView KorisniciGridView;
        private System.Windows.Forms.BindingSource korisniciResultBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox PretragaInput;
        private System.Windows.Forms.Button PretragaKorisnici_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Izmijeni;
        private System.Windows.Forms.Button BrisanjeKorisnika_btn;
        private System.Windows.Forms.Button IzvjestajiNavBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}

