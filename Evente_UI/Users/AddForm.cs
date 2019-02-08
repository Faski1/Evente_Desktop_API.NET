using Evente_API.Models;
using Evente_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http.Description;
using System.Resources;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;

namespace Evente_UI
{
    public partial class AddForm : Form
    {
        private WebAPIHelper KorisniciService = new WebAPIHelper("http://localhost:61253", "api/Korisnici");
        private WebAPIHelper GradService = new WebAPIHelper("http://localhost:61253", "api/Grad");
        private WebAPIHelper UlogeService = new WebAPIHelper("http://localhost:61253", "api/Uloge");

        public Korisnici k { get; set; }

        public AddForm()
        {
            InitializeComponent();
            k = new Korisnici();
            loadGradoviUloge();
            this.AutoValidate = AutoValidate.Disable;
        }
        private void loadGradoviUloge()
        {
            HttpResponseMessage response = GradService.GetResponse();
            HttpResponseMessage ulogeResponse = UlogeService.GetResponse();

            List<Grad_Result> gradovi = response.Content.ReadAsAsync<List<Grad_Result>>().Result;
            gradovi.Insert(0, new Grad_Result());
            GradInput.DataSource = gradovi;
            GradInput.DisplayMember = "Naziv";
            GradInput.ValueMember = "GradId";
            //GradInput.SelectedItem = gradovi.Find(u => u.Naziv == "Sarajevo");
            ulogeListCheckedBox.DataSource = ulogeResponse.Content.ReadAsAsync<List<Uloge>>().Result;
            ulogeListCheckedBox.DisplayMember = "Naziv";
            ulogeListCheckedBox.ClearSelected();

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
        private void SacuvajDodavanjeKorisnika_btn_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                k.Ime = ImeInput.Text;
                k.Prezime = PrezimeInput.Text;
                k.GradId = Convert.ToInt32(GradInput.SelectedValue);
                k.Adresa = AdresaInput.Text;
                k.Email = EmailInput.Text;
                k.Telefon = TelefonInput.Text;
                k.KorisnickoIme = KorisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, k.LozinkaSalt);
                k.Status = statusCheckBox.Checked;
                k.Uloge = ulogeListCheckedBox.CheckedItems.Cast<Uloge>().ToList();

                //try
                //{
                HttpResponseMessage response = KorisniciService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                //}
                //catch (HttpResponseException ex)
                //{
                else
                {
                    string message = response.ReasonPhrase;

                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        message = Messages.ResourceManager.GetString(response.ReasonPhrase);


                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + message);
                    //}
                }




                //HttpResponseMessage response = KorisniciService.PostResponse(k);
                //if (response.IsSuccessStatusCode)
                //{
                //    MessageBox.Show(Messages.add_usr_succ);
                //    DialogResult = DialogResult.OK;
                //    Close();
                //}
                //else
                //{
                //    string message = response.ReasonPhrase;
                //    if (string.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                //        message = Messages.ResourceManager.GetString(response.ReasonPhrase);


                //    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + message);
                //}
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
            AddGrad grad = new AddGrad();
            this.Hide();
            grad.ShowDialog();

        }

        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ImeInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(ImeInput, null);
            }
        }

        private void PrezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PrezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PrezimeInput, Messages.lname_req);
            }
            else
            {
                errorProvider.SetError(PrezimeInput, null);
            }
        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(EmailInput, Messages.email_req);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(EmailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(EmailInput, Messages.email_format);
                }

            }
            if (e.Cancel == false)
            {
                errorProvider.SetError(EmailInput, null);
            }
        }

        private void AdresaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AdresaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(AdresaInput, Messages.adr_req);
            }
            else if (AdresaInput.Text.Length <= 4)
            {
                e.Cancel = true;
                errorProvider.SetError(AdresaInput, Messages.adr_len);
            }
            else
            {
                errorProvider.SetError(AdresaInput, null);
            }
        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(KorisnickoImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(KorisnickoImeInput, Messages.usrn_req);
            }
            else if (KorisnickoImeInput.Text.Length <= 3)
            {
                e.Cancel = true;
                errorProvider.SetError(KorisnickoImeInput, Messages.usrn_len);
            }
            else
            {
                errorProvider.SetError(KorisnickoImeInput, null);
            }
        }
        private Regex regex = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,20}$");
        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.psw_req);
            }
            else if (!regex.IsMatch(LozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.psw_regex);
            }
            else
            {
                errorProvider.SetError(LozinkaInput, null);
            }
        }

        private void ulogeListCheckedBox_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeListCheckedBox.CheckedIndices.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeListCheckedBox, Messages.uloge_req);
            }
            else
            {

                errorProvider.SetError(ulogeListCheckedBox, null);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GradInput_Validating(object sender, CancelEventArgs e)
        {
            if (GradInput.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(GradInput, Messages.city_req);
            }
            else
            {
                errorProvider.SetError(GradInput, null);
            }
        }

        private void DodajSlikuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SlikaTextBox.Text = openFileDialog.FileName;

                    Image originalImage = Image.FromFile(openFileDialog.FileName);

                    MemoryStream ms = new MemoryStream();

                    originalImage.Save(ms, ImageFormat.Jpeg);

                    k.Slika = ms.ToArray();

                    int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                    int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                    int croppedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageWidth"]);
                    int croppedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageHeight"]);

                    if (originalImage.Width > resizedImageWidth)
                    {
                        Image resizedImage = Util.UIHelper.ResizeImage(originalImage, new Size(resizedImageWidth, resizedImageHeight));
                        Image croppedImage = resizedImage;

                        if (resizedImage.Width > croppedImageWidth && resizedImage.Height > croppedImageHeight)
                        {
                            int croppedXposition = (resizedImage.Width - croppedImageWidth) / 2;
                            int croppedYposition = (resizedImage.Height - croppedImageHeight) / 2;

                            croppedImage = Util.UIHelper.CropImage(resizedImage, new Rectangle(croppedXposition, croppedYposition, croppedImageWidth, croppedImageHeight));

                            ms = new MemoryStream();
                            croppedImage.Save(ms, ImageFormat.Jpeg);
                            k.SlikaThumb = ms.ToArray();


                            KorisnikSlika.Image = croppedImage;
                        }
                        else
                        {
                            MessageBox.Show(Messages.picture_war + " " + resizedImageWidth + "x" + resizedImageHeight + ".", Messages.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            k = null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                k.Slika = null;
                k.SlikaThumb = null;
                SlikaTextBox.Text = null;
                KorisnikSlika.Image = null;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToMainPage();
        }

        private void TelefonInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void IzvjestajiNavBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToReport();
        }
    }
}
