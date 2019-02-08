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
    public partial class PregledKarte : Form
    {
        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
        private WebAPIHelper KarteService = new WebAPIHelper("http://localhost:61253", "api/Karta");
        private WebAPIHelper KlasaService = new WebAPIHelper("http://localhost:61253", "api/Klasa");

        int brojUlazaka;
        string pomocniEvent;
        string pomocnaKlasa;
        public PregledKarte()
        {
            InitializeComponent();
            brojUlazaka = 0;
            EventiUcesniciGridView.AutoGenerateColumns = false;
            LoadEventi();
            LoadKlase();
            BindGrid();
        }

        private void LoadKlase()
        {
            HttpResponseMessage response = KlasaService.GetResponse();

            List<Klasa> klase = response.Content.ReadAsAsync<List<Klasa>>().Result;
            klase.Insert(0, new Klasa() { Naziv = ""});

            KlasaInput.DataSource = klase;
            KlasaInput.ValueMember = "Naziv";
            KlasaInput.DisplayMember = "Naziv";

            KlasaInput.SelectedValue = "";
        }

        private void LoadEventi()
        {
            HttpResponseMessage response = EventiService.GetActionResponse("BasicSelectAll");

            List<Eventi_Result> eventi = response.Content.ReadAsAsync<List<Eventi_Result>>().Result;
            eventi.Insert(0, new Eventi_Result());

            EventInput.DataSource = eventi;
            EventInput.ValueMember = "EventId";
            EventInput.DisplayMember = "Naziv";

            EventInput.SelectedValue = 0;
        }

        private void BindGrid()
        {
            if (Convert.ToInt32(EventInput.SelectedValue) == 0)
            {
                pomocniEvent = "0";
            }
            else
            {
                pomocniEvent = EventInput.SelectedValue.ToString();
            }
            if (Convert.ToString(KlasaInput.SelectedValue) == "")
            {
                pomocnaKlasa = "";
            }
            else
            {
                pomocnaKlasa = KlasaInput.SelectedValue.ToString();
            }

            HttpResponseMessage response = KarteService.GetActionResponse2("GetSearchKarte", pomocniEvent, pomocnaKlasa);


            if (response.IsSuccessStatusCode)
            {
                List<Karte_SearchResult> karte = response.Content.ReadAsAsync<List<Karte_SearchResult>>().Result;

                EventiUcesniciGridView.DataSource = karte;
                EventiUcesniciGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToMainPage();
        }

        private void KorisniciGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.Odjava();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PretragaKorisnici_btn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }


        private void BrisanjeKorisnika_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Da li ste sigurni, set karata će biti nepovrativ?!", "Potvrdite brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    KarteService.DeleteResponse(Int32.Parse(EventiUcesniciGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    BindGrid();
                    MessageBox.Show(Messages.del_tick_succ);
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.sel_err);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void EventInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            brojUlazaka++;
            if (brojUlazaka > 2)
            {
                BindGrid();

            }
        }

        private void UcesnikInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            brojUlazaka++;
            if (brojUlazaka > 2)
            {
                BindGrid();
            }
        }

        private void IzvjestajiNavBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToReport();
        }
    }
}
