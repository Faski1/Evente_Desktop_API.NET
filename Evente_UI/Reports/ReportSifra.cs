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
    public partial class ReportSifra : Form
    {
        private WebAPIHelper KartaService = new WebAPIHelper("http://localhost:61253", "api/Karta");

        public ReportSifra()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            if(string.IsNullOrEmpty(brojNarudzbeInput.Text))
            {
                HttpResponseMessage response = KartaService.GetActionResponse("GetSifraReport", "0" );
                List<Eventi_Report> eventi_Report = response.Content.ReadAsAsync<List<Eventi_Report>>().Result;
                IzvjestajGridView.DataSource = eventi_Report;
            }
            else
            {
                HttpResponseMessage response = KartaService.GetActionResponse("GetSifraReport", brojNarudzbeInput.Text);
                List<Eventi_Report> eventi_Report = response.Content.ReadAsAsync<List<Eventi_Report>>().Result;
                IzvjestajGridView.DataSource = eventi_Report;
            }
            //ReportDataSource rds = new ReportDataSource("dsEventiReport", eventi_Report);
            //this.reportViewer1.LocalReport.DataSources.Add(rds);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.Odjava();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void KarteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKarte_Main();
        }

        private void IzvjestajiNavBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToReport();
        }

       
        private void printajBtn_Click(object sender, EventArgs e)
        {
            ReportViewForm n = new ReportViewForm((List<Eventi_Report>)IzvjestajGridView.DataSource);
            n.Show();
        }

        private void brojNarudzbeInput_TextChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void brojNarudzbeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !isDash(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isDash(char keyChar)
        {
            if (keyChar != '-')
                return false;
            return true;
        }
    }
}
