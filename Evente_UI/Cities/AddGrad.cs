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
    public partial class AddGrad : Form
    {
        //komentarisane stvari za implementaciju loadanja drzava

        private WebAPIHelper DrzavaService = new WebAPIHelper("http://localhost:61253", "api/Drzava");
        private WebAPIHelper GradService = new WebAPIHelper("http://localhost:61253", "api/Grad");

        public AddGrad()
        {
            InitializeComponent();
            loadDrzave();
            this.AutoValidate = AutoValidate.Disable;
        }
        //private void loadGradovi()
        //{
        //    HttpResponseMessage response = GradService.GetResponse();

        //    List<Grad_Result> gradovi = response.Content.ReadAsAsync<List<Grad_Result>>().Result;

        //    DrzavaInput.DataSource = gradovi;
        //    DrzavaInput.ValueMember = "GradId";
        //    DrzavaInput.DisplayMember = "Naziv";
            
        //}
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
        private void loadDrzave()
        {
            HttpResponseMessage response = DrzavaService.GetResponse();

            List<Drzava> drzave = response.Content.ReadAsAsync<List<Drzava>>().Result;
            drzave.Insert(0, new Drzava());
            DrzavaInput.DataSource = drzave;
            DrzavaInput.DisplayMember = "Naziv";
            DrzavaInput.ValueMember = "DrzavaId";
        }
        private void SacuvajDodavanjeGrada_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Grad g = new Grad();
                g.Naziv = NazivGradaInput.Text;
                g.PostanskiBroj = PostanskiBroj_input.Text;
                g.DrzavaId = Convert.ToInt32(DrzavaInput.SelectedValue);
                HttpResponseMessage response = GradService.PostResponse(g);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_city_succ);
                    DialogResult = DialogResult.OK;
                    this.Hide();
                    NavHelper.NavigateToAddKorisnik();
                }
                //else if(response.StatusCode==System.Net.HttpStatusCode.NotFound)
                //{
                //    DialogResult = DialogResult.None;
                //}
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
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
            AddDrzava a = new AddDrzava();
            this.Hide();
            a.ShowDialog();
        }

        private void DrzavaInput_Validating(object sender, CancelEventArgs e)
        {
            if(DrzavaInput.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider.SetError(DrzavaInput, Messages.cntry_req);
            }
            else
            {
                errorProvider.SetError(DrzavaInput, null);
            }
        }

        private void NazivGradaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivGradaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivGradaInput, Messages.field_req);
            }
            else if (NazivGradaInput.Text.Length <= 3)
            {
                e.Cancel = true;
                errorProvider.SetError(NazivGradaInput, Messages.field_len);
            }
            else
            {
                errorProvider.SetError(NazivGradaInput, null);
            }
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
