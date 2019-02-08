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
    public partial class AddUcesnik : Form
    {

        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
        private WebAPIHelper UcesniciService = new WebAPIHelper("http://localhost:61253", "api/Ucesnici");
        private WebAPIHelper EventiUcesniciService = new WebAPIHelper("http://localhost:61253", "api/EventiUcesnici");

        public AddUcesnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            loadEventi();
            loadUcesnici();
        }
        private void loadEventi()
        {
            HttpResponseMessage response = EventiService.GetActionResponse("BasicSelectAll");

            List<Eventi_Result> eventi = response.Content.ReadAsAsync<List<Eventi_Result>>().Result;

            EventiInput.DataSource = eventi;
            EventiInput.ValueMember = "EventId";
            EventiInput.DisplayMember = "Naziv";

        }
        private void loadUcesnici()
        {
            HttpResponseMessage response = UcesniciService.GetResponse();

            List<Ucesnici> ucesnici = response.Content.ReadAsAsync<List<Ucesnici>>().Result;

            UcesnikInput.DataSource = ucesnici;
            UcesnikInput.ValueMember = "UcesnikId";
            UcesnikInput.DisplayMember = "Naziv";

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
            if (this.ValidateChildren())
            {
               HttpResponseMessage response = EventiUcesniciService.PostResponse(new EventiUcesnici { EventiId = Convert.ToInt32(EventiInput.SelectedValue), UcesnikId = Convert.ToInt32(UcesnikInput.SelectedValue) });

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_uces_succ);
                    DialogResult = DialogResult.OK;
                    this.Hide();
                    NavHelper.NavigateToEventi_Main();
                }

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

        


        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Name = "AddUcesnik";
            this.Hide();
            NavHelper.NavigateToAddUcesnici(this);
        }

        private void DodajLokaciju_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToAddEventi();
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


        //public new void Show()
        //{
        //    loadEventi();
        //    loadUcesnici();
        //    MessageBox.Show("Evo ga!");

        //    //call the shadowed Show method on the form.       
        //    base.Show();

        //}
    }
}
