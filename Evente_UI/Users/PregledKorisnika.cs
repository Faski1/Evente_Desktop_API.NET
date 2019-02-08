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
    public partial class PregledKorisnika : Form
    {
        private WebAPIHelper KorisniciService = new WebAPIHelper("http://localhost:61253", "api/Korisnici");
      

        public PregledKorisnika()
        {
            InitializeComponent();
            KorisniciGridView.AutoGenerateColumns = false;
        }
        
        private void BindGrid()
        {
            HttpResponseMessage response = KorisniciService.GetActionResponse("SearchByName", PretragaInput.Text);


            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> users = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                KorisniciGridView.DataSource = users;
                KorisniciGridView.ClearSelection();
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

        private void Izmijeni_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm(Convert.ToInt32(KorisniciGridView.SelectedRows[0].Cells[0].Value));
                this.Hide();
                editForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.sel_usr_err);
                DialogResult = DialogResult.None;
            }
        }
        private void BrisanjeKorisnika_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Da li ste sigurni, korisnik će biti nepovrativ?!","Potvrdite brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    KorisniciService.DeleteResponse(Int32.Parse(KorisniciGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    BindGrid();
                    MessageBox.Show(Messages.del_usr_succ);
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.sel_usr_err);
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

        private void IzvjestajiNavBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToReport();
        }
    }
}
