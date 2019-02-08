namespace Evente_UI
{
    partial class MainLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            this.LozinkaInput = new System.Windows.Forms.MaskedTextBox();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.KorisnickoImeInput = new System.Windows.Forms.MaskedTextBox();
            this.KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.OdustaniPrijava_btn = new System.Windows.Forms.Button();
            this.Prijava_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LozinkaInput
            // 
            this.LozinkaInput.Location = new System.Drawing.Point(190, 67);
            this.LozinkaInput.Name = "LozinkaInput";
            this.LozinkaInput.PasswordChar = '*';
            this.LozinkaInput.Size = new System.Drawing.Size(196, 20);
            this.LozinkaInput.TabIndex = 19;
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LozinkaLabel.ForeColor = System.Drawing.Color.White;
            this.LozinkaLabel.Location = new System.Drawing.Point(22, 67);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(80, 23);
            this.LozinkaLabel.TabIndex = 18;
            this.LozinkaLabel.Text = "Lozinka";
            // 
            // KorisnickoImeInput
            // 
            this.KorisnickoImeInput.Location = new System.Drawing.Point(190, 25);
            this.KorisnickoImeInput.Name = "KorisnickoImeInput";
            this.KorisnickoImeInput.Size = new System.Drawing.Size(196, 20);
            this.KorisnickoImeInput.TabIndex = 17;
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorisnickoImeLabel.ForeColor = System.Drawing.Color.White;
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(22, 26);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(144, 23);
            this.KorisnickoImeLabel.TabIndex = 16;
            this.KorisnickoImeLabel.Text = "Korisnicko ime";
            // 
            // OdustaniPrijava_btn
            // 
            this.OdustaniPrijava_btn.BackColor = System.Drawing.Color.White;
            this.OdustaniPrijava_btn.FlatAppearance.BorderSize = 0;
            this.OdustaniPrijava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OdustaniPrijava_btn.ForeColor = System.Drawing.Color.Black;
            this.OdustaniPrijava_btn.Location = new System.Drawing.Point(210, 106);
            this.OdustaniPrijava_btn.Name = "OdustaniPrijava_btn";
            this.OdustaniPrijava_btn.Size = new System.Drawing.Size(80, 30);
            this.OdustaniPrijava_btn.TabIndex = 20;
            this.OdustaniPrijava_btn.Text = "Odustani";
            this.OdustaniPrijava_btn.UseVisualStyleBackColor = false;
            this.OdustaniPrijava_btn.Click += new System.EventHandler(this.OdustaniPrijava_btn_Click);
            // 
            // Prijava_btn
            // 
            this.Prijava_btn.BackColor = System.Drawing.Color.White;
            this.Prijava_btn.FlatAppearance.BorderSize = 0;
            this.Prijava_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prijava_btn.ForeColor = System.Drawing.Color.Black;
            this.Prijava_btn.Location = new System.Drawing.Point(306, 106);
            this.Prijava_btn.Name = "Prijava_btn";
            this.Prijava_btn.Size = new System.Drawing.Size(80, 30);
            this.Prijava_btn.TabIndex = 21;
            this.Prijava_btn.Text = "Prijava";
            this.Prijava_btn.UseVisualStyleBackColor = false;
            this.Prijava_btn.Click += new System.EventHandler(this.Prijava_btn_Click);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(421, 157);
            this.Controls.Add(this.Prijava_btn);
            this.Controls.Add(this.OdustaniPrijava_btn);
            this.Controls.Add(this.LozinkaInput);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.KorisnickoImeInput);
            this.Controls.Add(this.KorisnickoImeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox LozinkaInput;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.MaskedTextBox KorisnickoImeInput;
        private System.Windows.Forms.Label KorisnickoImeLabel;
        private System.Windows.Forms.Button OdustaniPrijava_btn;
        private System.Windows.Forms.Button Prijava_btn;
    }
}