using Evente_API.Models;
using Evente_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evente_UI
{
    public partial class EditEventi : Form
    {
        private WebAPIHelper OrganizatoriService = new WebAPIHelper("http://localhost:61253", "api/Organizatori");
        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
        private WebAPIHelper GradService = new WebAPIHelper("http://localhost:61253", "api/Grad");
        private WebAPIHelper KategorijeService = new WebAPIHelper("http://localhost:61253", "api/Kategorije");

        

        private Eventi k { get; set; }

        public EditEventi(int EventId)
        {
            InitializeComponent();

            HttpResponseMessage response = EventiService.GetActionResponse("GetEventiById", EventId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                k = null;
                MessageBox.Show("Event nije pronadjen!");
            }
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Eventi>().Result;
                FillForm();
            }

            this.AutoValidate = AutoValidate.Disable;
        }

        private void FillForm()
        {

            NazivInput.Text = k.Naziv;
            MinimumGodineNumericUD.Value = (decimal)k.MinimumGodine;
            ObjekatOdrzavanjaInput.Text = k.ObjekatOdrzavanja;
            AdresaInput.Text = k.Adresa;
            DatumInput.Value = k.DatumOdrzavanja;
            statusCheckBox.Checked = k.Status;
            OpisInput.Text = k.Opis;

            HttpResponseMessage response = GradService.GetResponse();
            HttpResponseMessage organizatorResponse = OrganizatoriService.GetResponse();
            HttpResponseMessage kategorijeResponse = KategorijeService.GetResponse();


            List<Grad_Result> gradovi = response.Content.ReadAsAsync<List<Grad_Result>>().Result;
            List<Organizatori> organizatori = organizatorResponse.Content.ReadAsAsync<List<Organizatori>>().Result;
            List<Kategorije> kategorije = kategorijeResponse.Content.ReadAsAsync<List<Kategorije>>().Result;

            KategorijaInput.DataSource = kategorije;
            KategorijaInput.ValueMember = "KategorijaId";
            KategorijaInput.DisplayMember = "Naziv";
            KategorijaInput.SelectedItem = kategorije.Find(u => u.KategorijaId == k.KategorijaId);

            OrganizatorInput.DataSource = organizatori;
            OrganizatorInput.ValueMember = "OrganizatorId";
            OrganizatorInput.DisplayMember = "Naziv";
            OrganizatorInput.SelectedItem = organizatori.Find(u => u.OrganizatorId == k.OrganizatorId);

            GradInput.DataSource = gradovi;
            GradInput.ValueMember = "GradId";
            GradInput.DisplayMember = "Naziv";
            GradInput.SelectedItem = gradovi.Find(u => u.GradId == k.GradId);
            if (k.SlikaThumb != null)
            {
                MemoryStream ms = new MemoryStream(k.SlikaThumb);
                KorisnikSlika.Image = new Bitmap(ms);
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
            this.Hide();
            NavHelper.NavigateToAddGrad();
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

     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }
        /////////////////

        

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

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void SacuvajDodavanjeEventa_btn_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                if (this.ValidateChildren())
                {
                    k.Naziv = NazivInput.Text;
                    k.MinimumGodine = Convert.ToInt32(Math.Round(MinimumGodineNumericUD.Value, 0));
                    k.ObjekatOdrzavanja = ObjekatOdrzavanjaInput.Text;
                    k.Opis = OpisInput.Text;
                    k.Adresa = AdresaInput.Text;
                    k.DatumOdrzavanja = DatumInput.Value;
                    k.Status = statusCheckBox.Checked;
                    k.OrganizatorId = Convert.ToInt32(OrganizatorInput.SelectedValue);
                    k.KategorijaId = Convert.ToInt32(KategorijaInput.SelectedValue);
                    k.GradId = Convert.ToInt32(GradInput.SelectedValue);



                    HttpResponseMessage response = EventiService.PutResponse(k.EventId, k);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.edit_eve_succ, "Poruka o uspjehu!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.OK;
                        this.Hide();
                        NavHelper.NavigateToPregledEventi();
                    }
                    else
                    {
                        MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void DodajLokaciju_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToAddOrganizatori();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToAddKategorije();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToPregledUcesnici(k.EventId);
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
