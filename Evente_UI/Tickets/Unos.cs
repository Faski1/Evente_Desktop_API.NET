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
    public partial class Unos : Form
    {
        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
        private WebAPIHelper KlasaService = new WebAPIHelper("http://localhost:61253", "api/Klasa");
        private WebAPIHelper KartaService = new WebAPIHelper("http://localhost:61253", "api/Karta");


        public Unos()
        {
            InitializeComponent();
            loadEventi();
            LoadKlase();
        }
        private void loadEventi()
        {
            HttpResponseMessage response = EventiService.GetActionResponse("BasicSelectAll");

            List<Eventi_Result> eventi = response.Content.ReadAsAsync<List<Eventi_Result>>().Result;

            EventiInput.DataSource = eventi;
            EventiInput.ValueMember = "EventId";
            EventiInput.DisplayMember = "Naziv";

        }
        private void LoadKlase()
        {
            HttpResponseMessage response = KlasaService.GetResponse();

            List<Klasa> klase = response.Content.ReadAsAsync<List<Klasa>>().Result;

            KlasaInput.DataSource = klase;
            KlasaInput.ValueMember = "Naziv";
            KlasaInput.DisplayMember = "Naziv";
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.Odjava();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        
        private void brojKarataInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToAddKlasa();
        }

        private void KlasaInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void DodajLokaciju_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToAddEventi();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Karte k = new Karte();
            k.BrojKarata = Convert.ToInt32(Math.Round(brojKarataInput.Value, 0));
            k.EventId = Convert.ToInt32(EventiInput.SelectedValue);
            k.KlasaId = KlasaInput.SelectedValue.ToString(); //potencijalni error
            k.Cijena = Convert.ToInt32(Math.Round(CijenaInput.Value, 0));

            HttpResponseMessage response = KartaService.PostResponse(k);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_karte_succ);
                DialogResult = DialogResult.OK;
                this.Hide();
                NavHelper.NavigateToKarte_Main();
            }

            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void EventiInput_SelectedIndexChanged(object sender, EventArgs e)
        {

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