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
    public partial class PregledEventi : Form
    {
        private WebAPIHelper EventiService = new WebAPIHelper("http://localhost:61253", "api/Eventi");
      

        public PregledEventi()
        {
            InitializeComponent();
            EventiGridView.AutoGenerateColumns = false;
        }
        
        private void BindGrid()
        {
            HttpResponseMessage response = EventiService.GetActionResponse("SearchByName", PretragaInput.Text);


            if (response.IsSuccessStatusCode)
            {
                List<Eventi_SearchResult> eventi = response.Content.ReadAsAsync<List<Eventi_SearchResult>>().Result;
                
                EventiGridView.DataSource = eventi;
                EventiGridView.ClearSelection();
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
                EditEventi editForm = new EditEventi(Convert.ToInt32(EventiGridView.SelectedRows[0].Cells[0].Value));
                this.Hide();
                editForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.sel_eve_err);
                DialogResult = DialogResult.None;
            }
        }
        private void BrisanjeKorisnika_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Da li ste sigurni, event će biti nepovrativ?!", "Potvrdite brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    EventiService.DeleteResponse(Int32.Parse(EventiGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    BindGrid();
                    MessageBox.Show(Messages.del_eve_succ);
                }
                catch (Exception)
                {
                    MessageBox.Show(Messages.sel_eve_err);
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
