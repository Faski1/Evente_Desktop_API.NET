using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evente_UI.Util
{
    class NavHelper
    {
        public static void NavigateToKorisnici_Main()
        {
            KorisniciMain k = new KorisniciMain();
            k.ShowDialog();
        }
        public static void NavigateToKarte_Main ()
        {
            KarteMain k = new KarteMain();
            k.ShowDialog();
        }
        public static void NavigateToEventi_Main()
        {
            EventiMain k = new EventiMain();
            k.ShowDialog();
        }
        public static void NavigateToReportSifra()
        {
            ReportSifra k = new ReportSifra();
            k.ShowDialog();
        }
        public static void NavigateToReport()
        {
            ReportMain k = new ReportMain();
            k.ShowDialog();
        }
        public static void NavigateToReportDatum()
        {
            ReportPretraga k = new ReportPretraga();
            k.ShowDialog();
        }
        public static void NavigateToAddUcesnik()
        {
            AddUcesnik k = new AddUcesnik();
            k.ShowDialog();
        }
        public static void NavigateToUcesnikMain()
        {
            UcesniciMain k = new UcesniciMain();
            k.ShowDialog();

        }
        public static void NavigateToPregledUcesnici(int? id)
        {
            PregledUcesnici k = new PregledUcesnici(id);
            k.ShowDialog();
        }
        public static void NavigateToPregledEventi()
        {
            PregledEventi k = new PregledEventi();
            k.ShowDialog();
        }
        public static void NavigateToAddUcesnici(Form pomocni)
        {
            AddUcesnici k = new AddUcesnici(pomocni);
            k.ShowDialog();
        }
        public static void DynamicNavigate(Form pomocni)
        {
            switch (pomocni.Name)
            {
                
                case "AddUcesnik": NavigateToAddUcesnik();
                    break;
                case "AddEventi": NavigateToAddEventi();
                    break;
                default: MessageBox.Show("Navigacija nije moguća");
                    break;
            }
        }
        public static void NavigateToAddEventi()
        {
            AddEventi k = new AddEventi();
            k.ShowDialog();
        }
        public static void NavigateToPregledKorisnici()
        {
            PregledKorisnika p = new PregledKorisnika();
            p.ShowDialog();
        }
        public static void NavigateToAddKategorije()
        {
            AddCategories p = new AddCategories();
            p.ShowDialog();
        }
        public static void NavigateToAddOrganizatori()
        {
            AddOrganizatori p = new AddOrganizatori();
            p.ShowDialog();
        }
        public static void NavigateToAddKarte()
        {
           Unos p = new Unos();
            p.ShowDialog();
        }
        public static void NavigateToAddKlasa()
        {
            AddKlasa p = new AddKlasa();
            p.ShowDialog();
        }
        public static void NavigateToAddGrad()
        {
            AddGrad a = new AddGrad();
            a.ShowDialog();
        }
        public static void NavigateToAddKorisnik()
        {
            AddForm a = new AddForm();
            a.ShowDialog();
        }
        public static void NavigateToAddDrzava()
        {
            AddDrzava a = new AddDrzava();
            a.ShowDialog();
        }
        public static void NavigateToMainPage()
        {
            MainPage a = new MainPage();
            a.ShowDialog();
        }
        public static void Odjava()
        {
            MainPage noviMain;
            MainLoginForm nova = new MainLoginForm();
            if (nova.ShowDialog() == DialogResult.OK)
            {
                nova.Hide();
                noviMain = new MainPage();
                noviMain.ShowDialog();
            }
        }
    }
}
