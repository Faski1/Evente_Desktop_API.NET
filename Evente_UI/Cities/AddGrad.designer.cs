namespace Evente_UI
{
    partial class AddGrad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGrad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IzvjestajiNavBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostanskiBroj_input = new System.Windows.Forms.MaskedTextBox();
            this.DodajLokaciju_btn = new System.Windows.Forms.Button();
            this.SacuvajDodavanjeGrada_btn = new System.Windows.Forms.Button();
            this.NazivGradaInput = new System.Windows.Forms.MaskedTextBox();
            this.NazivLabel = new System.Windows.Forms.Label();
            this.DrzavaInput = new System.Windows.Forms.ComboBox();
            this.DrzavaLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.gradResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IzvjestajiNavBtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 626);
            this.panel1.TabIndex = 0;
            // 
            // IzvjestajiNavBtn
            // 
            this.IzvjestajiNavBtn.FlatAppearance.BorderSize = 0;
            this.IzvjestajiNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IzvjestajiNavBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzvjestajiNavBtn.ForeColor = System.Drawing.Color.White;
            this.IzvjestajiNavBtn.Image = global::Evente_UI.Properties.Resources.Izvjestaji;
            this.IzvjestajiNavBtn.Location = new System.Drawing.Point(-3, 519);
            this.IzvjestajiNavBtn.Name = "IzvjestajiNavBtn";
            this.IzvjestajiNavBtn.Size = new System.Drawing.Size(148, 91);
            this.IzvjestajiNavBtn.TabIndex = 7;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Evente_UI.Properties.Resources.Home_icon;
            this.button1.Location = new System.Drawing.Point(0, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Početna";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel2.Controls.Add(this.PostanskiBroj_input);
            this.panel2.Controls.Add(this.DodajLokaciju_btn);
            this.panel2.Controls.Add(this.SacuvajDodavanjeGrada_btn);
            this.panel2.Controls.Add(this.NazivGradaInput);
            this.panel2.Controls.Add(this.NazivLabel);
            this.panel2.Controls.Add(this.DrzavaInput);
            this.panel2.Controls.Add(this.DrzavaLabel);
            this.panel2.Controls.Add(this.AdresaLabel);
            this.panel2.Location = new System.Drawing.Point(151, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 501);
            this.panel2.TabIndex = 1;
            // 
            // PostanskiBroj_input
            // 
            this.PostanskiBroj_input.Location = new System.Drawing.Point(256, 203);
            this.PostanskiBroj_input.Name = "PostanskiBroj_input";
            this.PostanskiBroj_input.Size = new System.Drawing.Size(196, 32);
            this.PostanskiBroj_input.TabIndex = 19;
            // 
            // DodajLokaciju_btn
            // 
            this.DodajLokaciju_btn.BackColor = System.Drawing.Color.White;
            this.DodajLokaciju_btn.FlatAppearance.BorderSize = 0;
            this.DodajLokaciju_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajLokaciju_btn.ForeColor = System.Drawing.Color.Black;
            this.DodajLokaciju_btn.Location = new System.Drawing.Point(477, 266);
            this.DodajLokaciju_btn.Name = "DodajLokaciju_btn";
            this.DodajLokaciju_btn.Size = new System.Drawing.Size(88, 30);
            this.DodajLokaciju_btn.TabIndex = 13;
            this.DodajLokaciju_btn.Text = "Dodaj";
            this.DodajLokaciju_btn.UseVisualStyleBackColor = false;
            this.DodajLokaciju_btn.Click += new System.EventHandler(this.DodajLokaciju_btn_Click);
            // 
            // SacuvajDodavanjeGrada_btn
            // 
            this.SacuvajDodavanjeGrada_btn.BackColor = System.Drawing.Color.White;
            this.SacuvajDodavanjeGrada_btn.FlatAppearance.BorderSize = 0;
            this.SacuvajDodavanjeGrada_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SacuvajDodavanjeGrada_btn.ForeColor = System.Drawing.Color.Black;
            this.SacuvajDodavanjeGrada_btn.Location = new System.Drawing.Point(477, 389);
            this.SacuvajDodavanjeGrada_btn.Name = "SacuvajDodavanjeGrada_btn";
            this.SacuvajDodavanjeGrada_btn.Size = new System.Drawing.Size(88, 30);
            this.SacuvajDodavanjeGrada_btn.TabIndex = 4;
            this.SacuvajDodavanjeGrada_btn.Text = "Sačuvaj";
            this.SacuvajDodavanjeGrada_btn.UseVisualStyleBackColor = false;
            this.SacuvajDodavanjeGrada_btn.Click += new System.EventHandler(this.SacuvajDodavanjeGrada_btn_Click);
            // 
            // NazivGradaInput
            // 
            this.NazivGradaInput.Location = new System.Drawing.Point(256, 144);
            this.NazivGradaInput.Name = "NazivGradaInput";
            this.NazivGradaInput.Size = new System.Drawing.Size(196, 32);
            this.NazivGradaInput.TabIndex = 6;
            this.NazivGradaInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivGradaInput_Validating);
            // 
            // NazivLabel
            // 
            this.NazivLabel.AutoSize = true;
            this.NazivLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazivLabel.ForeColor = System.Drawing.Color.White;
            this.NazivLabel.Location = new System.Drawing.Point(85, 145);
            this.NazivLabel.Name = "NazivLabel";
            this.NazivLabel.Size = new System.Drawing.Size(81, 31);
            this.NazivLabel.TabIndex = 5;
            this.NazivLabel.Text = "Naziv";
            this.NazivLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // DrzavaInput
            // 
            this.DrzavaInput.FormattingEnabled = true;
            this.DrzavaInput.Location = new System.Drawing.Point(256, 266);
            this.DrzavaInput.Name = "DrzavaInput";
            this.DrzavaInput.Size = new System.Drawing.Size(196, 31);
            this.DrzavaInput.TabIndex = 3;
            this.DrzavaInput.SelectedIndexChanged += new System.EventHandler(this.GradInput_SelectedIndexChanged);
            this.DrzavaInput.Validating += new System.ComponentModel.CancelEventHandler(this.DrzavaInput_Validating);
            // 
            // DrzavaLabel
            // 
            this.DrzavaLabel.AutoSize = true;
            this.DrzavaLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrzavaLabel.ForeColor = System.Drawing.Color.White;
            this.DrzavaLabel.Location = new System.Drawing.Point(88, 266);
            this.DrzavaLabel.Name = "DrzavaLabel";
            this.DrzavaLabel.Size = new System.Drawing.Size(101, 31);
            this.DrzavaLabel.TabIndex = 2;
            this.DrzavaLabel.Text = "Drzava";
            this.DrzavaLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdresaLabel.ForeColor = System.Drawing.Color.White;
            this.AdresaLabel.Location = new System.Drawing.Point(88, 203);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(177, 31);
            this.AdresaLabel.TabIndex = 1;
            this.AdresaLabel.Text = "Postanski broj";
            this.AdresaLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // gradResultBindingSource1
            // 
            this.gradResultBindingSource1.DataSource = typeof(Evente_API.Models.Grad_Result);
            // 
            // gradResultBindingSource
            // 
            this.gradResultBindingSource.DataSource = typeof(Evente_API.Models.Grad_Result);
            // 
            // korisniciResultBindingSource
            // 
            this.korisniciResultBindingSource.DataSource = typeof(Evente_API.Models.Korisnici_Result);
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
            this.panel4.Size = new System.Drawing.Size(697, 125);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dodavanje grada";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(534, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "Odjava";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli " + Global.prijavljeniKorisnik.Ime;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddGrad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(848, 626);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGrad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evente";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciResultBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.Label DrzavaLabel;
        private System.Windows.Forms.Label NazivLabel;
        private System.Windows.Forms.ComboBox DrzavaInput;
        private System.Windows.Forms.Button SacuvajDodavanjeGrada_btn;
        private System.Windows.Forms.MaskedTextBox NazivGradaInput;
        private System.Windows.Forms.Button DodajLokaciju_btn;
        private System.Windows.Forms.MaskedTextBox PostanskiBroj_input;
        private System.Windows.Forms.BindingSource korisniciResultBindingSource;
        private System.Windows.Forms.BindingSource gradResultBindingSource;
        private System.Windows.Forms.BindingSource gradResultBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button IzvjestajiNavBtn;
    }
}

