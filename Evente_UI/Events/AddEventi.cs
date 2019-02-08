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
    public partial class AddEventi : Form
    {
        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
        private WebAPIHelper GradService = new WebAPIHelper("http://localhost:61253", "api/Grad");
        private WebAPIHelper OrganizatoriService = new WebAPIHelper("http://localhost:61253", "api/Organizatori");
        private WebAPIHelper KategorijeService = new WebAPIHelper("http://localhost:61253", "api/Kategorije");
        private WebAPIHelper UcesniciService = new WebAPIHelper("http://localhost:61253", "api/Ucesnici");
        
        public Eventi k { get; set; }
        public AddEventi()
        {
            InitializeComponent();
            k = new Eventi();
            loadGradovi();
            loadOrganizatori();
            loadKategorije();
            loadUcesnici();
            this.AutoValidate = AutoValidate.Disable;
        }
        private void loadGradovi()
        {
            HttpResponseMessage response = GradService.GetResponse();

            List<Grad_Result> gradovi = response.Content.ReadAsAsync<List<Grad_Result>>().Result;
            gradovi.Insert(0, new Grad_Result());
            GradInput.DataSource = gradovi;
            GradInput.DisplayMember = "Naziv";
            GradInput.ValueMember = "GradId";
        }
        private void loadUcesnici()
        {
            HttpResponseMessage response = UcesniciService.GetResponse();

            List<Ucesnici> ucesnici = response.Content.ReadAsAsync<List<Ucesnici>>().Result;
            ucesnici.Insert(0, new Ucesnici());
            GlavniUcesnikInput.DataSource = ucesnici;
            GlavniUcesnikInput.DisplayMember = "Naziv";
            GlavniUcesnikInput.ValueMember = "UcesnikId";
        }
        private void loadOrganizatori()
        {
            HttpResponseMessage response = OrganizatoriService.GetActionResponse("GetBasicOrganizatori");

            List<Organizatori_Result> organizatori = response.Content.ReadAsAsync<List<Organizatori_Result>>().Result;
            organizatori.Insert(0, new Organizatori_Result());
            OrganizatorInput.DataSource = organizatori;
            OrganizatorInput.DisplayMember = "Naziv";
            OrganizatorInput.ValueMember = "OrganizatorId";
        }
        private void loadKategorije()
        {
            HttpResponseMessage response = KategorijeService.GetResponse();

            List<Kategorije> kategorije = response.Content.ReadAsAsync<List<Kategorije>>().Result;
            kategorije.Insert(0, new Kategorije());
            KategorijaInput.DataSource = kategorije;
            KategorijaInput.DisplayMember = "Naziv";
            KategorijaInput.ValueMember = "KategorijaId";
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
        private void SacuvajDodavanjeEventa_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                k.Naziv = NazivInput.Text;
                k.MinimumGodine = Convert.ToInt32(Math.Round(MinimumGodineNumericUD.Value,0));
                k.ObjekatOdrzavanja = ObjekatOdrzavanjaInput.Text;
                k.OrganizatorId = Convert.ToInt32(OrganizatorInput.SelectedValue);
                k.KategorijaId = Convert.ToInt32(KategorijaInput.SelectedValue);
                k.GradId = Convert.ToInt32(GradInput.SelectedValue);
                k.Adresa = AdresaInput.Text;
                k.DatumOdrzavanja = DatumInput.Value;
                k.Status = statusCheckBox.Checked;
                k.Opis = OpisInput.Text;
                k.GlavniUcesnik = new Ucesnici { UcesnikId = Convert.ToInt32(GlavniUcesnikInput.SelectedValue), Naziv=GlavniUcesnikInput.SelectedText };
                //Convert.ToInt32(GlavniUcesnikInput.SelectedValue); //error - vraca null
                HttpResponseMessage response = EventiService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.evt_add_succ);
                    DialogResult = DialogResult.OK;
                    this.Hide();
                    NavHelper.NavigateToEventi_Main();
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
            AddOrganizatori organizatori = new AddOrganizatori();
            this.Hide();
            organizatori.ShowDialog();

        }

        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(NazivInput, null);
            }
        }

       

       

        

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AdresaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(AdresaInput, Messages.usrn_req);
            }
            else if (AdresaInput.Text.Length <= 3)
            {
                e.Cancel = true;
                errorProvider.SetError(AdresaInput, Messages.usrn_len);
            }
            else
            {
                errorProvider.SetError(AdresaInput, null);
            }
        }
        

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GradInput_Validating(object sender, CancelEventArgs e)
        {
            if (OrganizatorInput.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(OrganizatorInput, Messages.city_req);
            }
            else
            {
                errorProvider.SetError(OrganizatorInput, null);
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

        private void PrezimeInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddCategories addCategories = new AddCategories();
            this.Hide();
            addCategories.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Name = "AddEventi";
            this.Hide();
            NavHelper.NavigateToAddUcesnici(this);
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
