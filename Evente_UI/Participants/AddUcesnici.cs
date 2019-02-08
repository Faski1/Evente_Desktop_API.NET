using Evente_API.Models;
using Evente_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Evente_UI
{
    public partial class AddUcesnici : Form
    {
        //komentarisane stvari za implementaciju loadanja drzava

        private WebAPIHelper UcesniciService = new WebAPIHelper("http://localhost:61253", "api/Ucesnici");
        Form pomocni { get; set; }

        public AddUcesnici(Form parentForm)
        {
            InitializeComponent();
            pomocni = parentForm;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToEventi_Main();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        internal void FormClosed(DialogResult dialogResult)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void SacuvajDodavanjeGrada_btn_Click(object sender, EventArgs e)
        {
            
            Ucesnici d = new Ucesnici();
            d.Naziv = UcesniciInput.Text;
            HttpResponseMessage response = UcesniciService.PostResponse(d);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_uces_succ);
                DialogResult = DialogResult.OK;
                this.Hide();
                NavHelper.DynamicNavigate(pomocni);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        private void GradInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajLokaciju_btn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToMainPage();
        }

        private void IzvjestajiNavBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToReport();
        }
    }
}
