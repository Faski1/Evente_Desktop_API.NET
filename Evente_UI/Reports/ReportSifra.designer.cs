using Evente_UI.Util;

namespace Evente_UI
{
    partial class ReportSifra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSifra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IzvjestajiNavBtn = new System.Windows.Forms.Button();
            this.KarteBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pocetna = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IzvjestajGridView = new System.Windows.Forms.DataGridView();
            this.eventNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojKarataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizatorNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumNarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espEventiReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventeDataSet = new Evente_UI.EventeDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.esp_Eventi_ReportTableAdapter = new Evente_UI.EventeDataSetTableAdapters.esp_Eventi_ReportTableAdapter();
            this.printajBtn = new System.Windows.Forms.Button();
            this.brojNarudzbeInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espEventiReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventeDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IzvjestajiNavBtn);
            this.panel1.Controls.Add(this.KarteBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Pocetna);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 784);
            this.panel1.TabIndex = 0;
            // 
            // IzvjestajiNavBtn
            // 
            this.IzvjestajiNavBtn.FlatAppearance.BorderSize = 0;
            this.IzvjestajiNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IzvjestajiNavBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzvjestajiNavBtn.ForeColor = System.Drawing.Color.White;
            this.IzvjestajiNavBtn.Image = global::Evente_UI.Properties.Resources.Izvjestaji;
            this.IzvjestajiNavBtn.Location = new System.Drawing.Point(3, 519);
            this.IzvjestajiNavBtn.Name = "IzvjestajiNavBtn";
            this.IzvjestajiNavBtn.Size = new System.Drawing.Size(148, 91);
            this.IzvjestajiNavBtn.TabIndex = 5;
            this.IzvjestajiNavBtn.Text = "Izvještaji";
            this.IzvjestajiNavBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IzvjestajiNavBtn.UseVisualStyleBackColor = true;
            this.IzvjestajiNavBtn.Click += new System.EventHandler(this.IzvjestajiNavBtn_Click);
            // 
            // KarteBtn
            // 
            this.KarteBtn.FlatAppearance.BorderSize = 0;
            this.KarteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KarteBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KarteBtn.ForeColor = System.Drawing.Color.White;
            this.KarteBtn.Image = global::Evente_UI.Properties.Resources.icons8_train_ticket_32;
            this.KarteBtn.Location = new System.Drawing.Point(0, 422);
            this.KarteBtn.Name = "KarteBtn";
            this.KarteBtn.Size = new System.Drawing.Size(148, 91);
            this.KarteBtn.TabIndex = 4;
            this.KarteBtn.Text = "Karte";
            this.KarteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KarteBtn.UseVisualStyleBackColor = true;
            this.KarteBtn.Click += new System.EventHandler(this.KarteBtn_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.brojNarudzbeInput);
            this.panel2.Controls.Add(this.printajBtn);
            this.panel2.Controls.Add(this.IzvjestajGridView);
            this.panel2.Location = new System.Drawing.Point(151, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 650);
            this.panel2.TabIndex = 1;
            // 
            // IzvjestajGridView
            // 
            this.IzvjestajGridView.AllowUserToAddRows = false;
            this.IzvjestajGridView.AllowUserToDeleteRows = false;
            this.IzvjestajGridView.AutoGenerateColumns = false;
            this.IzvjestajGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.IzvjestajGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.IzvjestajGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.IzvjestajGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzvjestajGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventNazivDataGridViewTextBoxColumn,
            this.brojKarataDataGridViewTextBoxColumn,
            this.klasaIdDataGridViewTextBoxColumn,
            this.organizatorNazivDataGridViewTextBoxColumn,
            this.datumNarudzbeDataGridViewTextBoxColumn});
            this.IzvjestajGridView.DataSource = this.espEventiReportBindingSource;
            this.IzvjestajGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.IzvjestajGridView.Location = new System.Drawing.Point(3, 87);
            this.IzvjestajGridView.Name = "IzvjestajGridView";
            this.IzvjestajGridView.ReadOnly = true;
            this.IzvjestajGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.IzvjestajGridView.RowTemplate.Height = 50;
            this.IzvjestajGridView.Size = new System.Drawing.Size(896, 563);
            this.IzvjestajGridView.TabIndex = 5;
            // 
            // eventNazivDataGridViewTextBoxColumn
            // 
            this.eventNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventNazivDataGridViewTextBoxColumn.DataPropertyName = "EventNaziv";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.eventNazivDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.eventNazivDataGridViewTextBoxColumn.HeaderText = "Event";
            this.eventNazivDataGridViewTextBoxColumn.Name = "eventNazivDataGridViewTextBoxColumn";
            this.eventNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojKarataDataGridViewTextBoxColumn
            // 
            this.brojKarataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojKarataDataGridViewTextBoxColumn.DataPropertyName = "BrojKarata";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.brojKarataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.brojKarataDataGridViewTextBoxColumn.HeaderText = "Broj Karata";
            this.brojKarataDataGridViewTextBoxColumn.Name = "brojKarataDataGridViewTextBoxColumn";
            this.brojKarataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klasaIdDataGridViewTextBoxColumn
            // 
            this.klasaIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.klasaIdDataGridViewTextBoxColumn.DataPropertyName = "KlasaId";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.klasaIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.klasaIdDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaIdDataGridViewTextBoxColumn.Name = "klasaIdDataGridViewTextBoxColumn";
            this.klasaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // organizatorNazivDataGridViewTextBoxColumn
            // 
            this.organizatorNazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.organizatorNazivDataGridViewTextBoxColumn.DataPropertyName = "OrganizatorNaziv";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.organizatorNazivDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.organizatorNazivDataGridViewTextBoxColumn.HeaderText = "Organizator";
            this.organizatorNazivDataGridViewTextBoxColumn.Name = "organizatorNazivDataGridViewTextBoxColumn";
            this.organizatorNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumNarudzbeDataGridViewTextBoxColumn
            // 
            this.datumNarudzbeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumNarudzbeDataGridViewTextBoxColumn.DataPropertyName = "DatumNarudzbe";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.datumNarudzbeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.datumNarudzbeDataGridViewTextBoxColumn.HeaderText = "Datum Narudzbe";
            this.datumNarudzbeDataGridViewTextBoxColumn.Name = "datumNarudzbeDataGridViewTextBoxColumn";
            this.datumNarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // espEventiReportBindingSource
            // 
            this.espEventiReportBindingSource.DataMember = "esp_Eventi_Report";
            this.espEventiReportBindingSource.DataSource = this.eventeDataSet;
            // 
            // eventeDataSet
            // 
            this.eventeDataSet.DataSetName = "EventeDataSet";
            this.eventeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel4.Size = new System.Drawing.Size(899, 125);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izvještaji";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(737, 51);
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
            this.label1.Location = new System.Drawing.Point(705, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli " + Global.prijavljeniKorisnik.Ime;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // esp_Eventi_ReportTableAdapter
            // 
            this.esp_Eventi_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // printajBtn
            // 
            this.printajBtn.BackColor = System.Drawing.Color.White;
            this.printajBtn.FlatAppearance.BorderSize = 0;
            this.printajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printajBtn.ForeColor = System.Drawing.Color.Black;
            this.printajBtn.Location = new System.Drawing.Point(753, 21);
            this.printajBtn.Name = "printajBtn";
            this.printajBtn.Size = new System.Drawing.Size(134, 47);
            this.printajBtn.TabIndex = 4;
            this.printajBtn.Text = "Printaj";
            this.printajBtn.UseVisualStyleBackColor = false;
            this.printajBtn.Click += new System.EventHandler(this.printajBtn_Click);
            // 
            // brojNarudzbeInput
            // 
            this.brojNarudzbeInput.AsciiOnly = true;
            this.brojNarudzbeInput.Location = new System.Drawing.Point(187, 30);
            this.brojNarudzbeInput.Name = "brojNarudzbeInput";
            this.brojNarudzbeInput.Size = new System.Drawing.Size(196, 32);
            this.brojNarudzbeInput.TabIndex = 6;
            this.brojNarudzbeInput.TextChanged += new System.EventHandler(this.brojNarudzbeInput_TextChanged);
            this.brojNarudzbeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brojNarudzbeInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj narudzbe";
            // 
            // ReportSifra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1050, 784);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportSifra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evente";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espEventiReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventeDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pocetna;
        private System.Windows.Forms.Button KarteBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IzvjestajiNavBtn;
        private System.Windows.Forms.DataGridView IzvjestajGridView;
        private System.Windows.Forms.BindingSource espEventiReportBindingSource;
        private EventeDataSet eventeDataSet;
        private EventeDataSetTableAdapters.esp_Eventi_ReportTableAdapter esp_Eventi_ReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojKarataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizatorNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumNarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox brojNarudzbeInput;
        private System.Windows.Forms.Button printajBtn;
    }
}

