using Evente_API.Models;
using Evente_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Evente_API.Util
{
    public class Recommender
    {
        private  WebAPIHelper KategorijeService = new WebAPIHelper(Evente_PCL.Global.API_IP, "api/Kategorije");
        private  WebAPIHelper EventiService = new WebAPIHelper(Evente_PCL.Global.API_IP, "api/Eventi");
        private  WebAPIHelper OcjeneService = new WebAPIHelper(Evente_PCL.Global.API_IP, "api/Ocjene");
        
        //top 3 omiljene kategorije (najvise narucivane)
        public List<Kategorije_Omiljena> GetOmiljeneKategorije(int KorisnikId)
        {
            HttpResponseMessage response = KategorijeService.GetActionResponse("GetOmiljena", KorisnikId.ToString());
            List<Kategorije_Omiljena> k = response.Content.ReadAsAsync<List<Kategorije_Omiljena>>().Result;

            if (k.Count == 0)
            {
                return null;
            }
            else
            {
                return k;
            }

        }
        //eventi koji nisu kupljeni i koji odgovaraju jednoj od omiljenih kategorija
        public List<Eventi_Result> UcitajEvente(int KorisnikId, string Kategorija)
        {
            HttpResponseMessage response = EventiService.GetActionResponse2("GetEventiKategorijaFav", KorisnikId.ToString(), Kategorija);

            return response.Content.ReadAsAsync<List<Eventi_Result>>().Result;
            
        }
        public double GetProsjecnaOcjena(int EventId)
        {
            HttpResponseMessage response = OcjeneService.GetActionResponse("GetProsjecna", EventId.ToString());

            try
            {
                return response.Content.ReadAsAsync<double>().Result;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        List<Kategorije_Omiljena> n;
        List<Eventi_Result> NePosjeceni_Kategorija;
        //provjera pronalaska odgovarajucih evenata iz top 3 omiljene kategorije i pronalazak visokoocijenjenih istih
        public List<Eventi_Preporuceni> RecommendedByTypeGrade(int KorisnikId)
        {
            
            try
            {
                n = GetOmiljeneKategorije(KorisnikId).ToList();
            }
            catch (Exception)
            {
                
            }
           
            if (n != null)
            {
                foreach (Kategorije_Omiljena item in n)
                {
                    try
                    {
                        if (UcitajEvente(KorisnikId, item.Naziv).Count >= 2)
                        {
                            NePosjeceni_Kategorija = UcitajEvente(KorisnikId, item.Naziv).ToList();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }
            }
            

            List<Eventi_Preporuceni> preporuceni = new List<Eventi_Preporuceni>();

            if (NePosjeceni_Kategorija.Count > 0)
            {
                foreach (Eventi_Result item in NePosjeceni_Kategorija)
                {

                    HttpResponseMessage response = EventiService.GetActionResponse("GetPreporuceni", item.EventId.ToString());
                    Eventi_Preporuceni ep = response.Content.ReadAsAsync<Eventi_Preporuceni>().Result;
                    if (ep.ProsjecnaOcjena >= 4)
                        preporuceni.Add(ep);
                }
                return preporuceni;
            }
            return vratiBezKategorije(KorisnikId);
            
        }

        private List<Eventi_Preporuceni> vratiBezKategorije(int KorisnikId)
        {
            List<Eventi_Preporuceni> preporuceni = new List<Eventi_Preporuceni>();
            HttpResponseMessage response2 = EventiService.GetActionResponse("GetBezKatPreporuceni", KorisnikId.ToString());

            preporuceni = response2.Content.ReadAsAsync<List<Eventi_Preporuceni>>().Result;

            return preporuceni;
        }
    }
}