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
    public partial class EventiMain : Form
    {
        private WebAPIHelper KorisniciService = new WebAPIHelper("http://localhost:61253", "api/Korisnici");

        public EventiMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            NavHelper.NavigateToAddEventi();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToMainPage();
        }

        private void pregledKorisnika_nav_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToPregledEventi();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.Odjava();
        }

        private void DobrodosliLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToKorisnici_Main();
        }

        

        private void btnDodajUcesnika_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavHelper.NavigateToUcesnikMain();
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
