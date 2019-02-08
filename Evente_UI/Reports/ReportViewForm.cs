using Evente_API.Models;
using Evente_UI.Util;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportViewForm : Form
    {
        List<Eventi_Report> k;
        public ReportViewForm(List<Eventi_Report> eventi_Reports)
        {
            this.k = eventi_Reports;
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
            { 

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
           
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
           
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

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", k);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
           
            this.reportViewer1.RefreshReport();

            
        }
    }
}
