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
    public partial class MainLoginForm : Form
    {

        private WebAPIHelper KorisniciService = new WebAPIHelper("http://localhost:61253", "api/Korisnici");


        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void OdustaniPrijava_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Prijava_btn_Click(object sender, EventArgs e)
        {
           HttpResponseMessage response = KorisniciService.GetActionResponse("LoginSelect", KorisnickoImeInput.Text);
           if (response.IsSuccessStatusCode)
            {
                Korisnici_LoginResult k = response.Content.ReadAsAsync<Korisnici_LoginResult>().Result;
                if (k.LozinkaHash == UIHelper.GenerateHash(LozinkaInput.Text, k.LozinkaSalt))
                {
                    if(k.UlogaId!=4)
                    { 
                    MessageBox.Show("Dobrodošli " + k.Ime + " " + k.Prezime);
                    DialogResult = DialogResult.OK;
                    Global.prijavljeniKorisnik = k;
                    Close();
                    }
                    else
                    {
                        MessageBox.Show("Niste autorizovani za pristup!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show(Messages.login_err, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(response.StatusCode== System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show(Messages.login_err, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
        }
    }
}
