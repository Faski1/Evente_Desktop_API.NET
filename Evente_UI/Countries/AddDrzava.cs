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
    public partial class AddDrzava : Form
    {
        //komentarisane stvari za implementaciju loadanja drzava

        private WebAPIHelper DrzavaService = new WebAPIHelper("http://localhost:61253", "api/Drzava");

        public AddDrzava()
        {
            InitializeComponent();
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
            if (NazivDrzavaInput.Text == "" || NazivDrzavaInput.Text.Length < 2)
            {
                MessageBox.Show("Molimo pravilno unesite ime drzave!");
                DialogResult = DialogResult.No;
                this.Hide();
                NavHelper.NavigateToAddGrad();
                return;
            }
            Drzava d = new Drzava();
            d.Naziv = NazivDrzavaInput.Text;
            HttpResponseMessage response = DrzavaService.PostResponse(d);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_ctry_succ);
                DialogResult = DialogResult.OK;
                this.Hide();
                NavHelper.NavigateToAddGrad();
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
