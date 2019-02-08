using Evente_API.Models;
using Evente_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evente_UI
{
    public partial class AddOrganizatori : Form
    {
        private WebAPIHelper OrganizatoriService = new WebAPIHelper("http://localhost:61253", "api/Organizatori");

        public AddOrganizatori()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void button5_Click_1(object sender, EventArgs e)
        {
            Organizatori k = new Organizatori();

            if(this.ValidateChildren())
            {
                k.Naziv = nazivInput.Text;
                k.Telefon = TelefonInput.Text;
                k.Email = emailInput.Text;
                k.Fax = faxInput.Text;
                k.Web = webSiteInput.Text;
                k.ZiroRacun = ziroRacunInput.Text;
                k.Napomena = OpisInput.Text;

                HttpResponseMessage response = OrganizatoriService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_org_succ);
                    DialogResult = DialogResult.OK;
                    this.Hide();
                    AddEventi n = new AddEventi();
                    n.ShowDialog();
                }
                else
                {
                    string message = response.ReasonPhrase;

                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        message = Messages.ResourceManager.GetString(response.ReasonPhrase);
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + message);
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Messages.email_req);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_format);
                }

            }
            if (e.Cancel == false)
            {
                errorProvider.SetError(emailInput, null);
            }
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(nazivInput, null);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToEventi_Main();
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
