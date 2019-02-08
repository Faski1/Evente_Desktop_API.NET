using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Windows.Forms;
using Evente_API.Models;

namespace Evente_API.Controllers
{
    public class KartaController : ApiController
    {
        
        private EventeEntities dm = new EventeEntities();

        //api/Gradovi
        [HttpGet]
        public List<Karte> GetKarta()
        {
            var Karta = dm.Kartes;
            return Karta.ToList();
        }
        [Route("api/Karta/GetKarteKategorija/{EventId}")]
        [HttpGet]
        public List<Karte_KategorijaResult> GetKarteKategorija(int EventId)
        {
            return dm.esp_Eventi_Karte(EventId).ToList();
        }
        public IHttpActionResult PostKarta(Karte obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Kartes.Add(obj);
            try
            {
                dm.SaveChanges();
                return Ok();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return Ok();

        }
        [HttpGet]
        [Route("api/Karta/GetEventiReport/{danOd}/{mjesecOd}/{godinaOd}/{danDo}/{mjesecDo}/{godinaDo}")]
        public List<Eventi_Report> GetEventiReport(int danOd, int mjesecOd , int godinaOd , int danDo, int mjesecDo, int godinaDo)
        {
            return dm.esp_Eventi_Report(danOd, mjesecOd, godinaOd, danDo, mjesecDo, godinaDo).ToList();
        }
        [HttpGet]
        [Route("api/Karta/GetSifraReport/{sifra}")]
        public List<Eventi_Report>GetSifraReport(string sifra)
        {
            if(sifra== "0")
            {
                return dm.esp_Eventi_SifraReport(null).ToList();
            }
            return dm.esp_Eventi_SifraReport(sifra).ToList();
        }
        [HttpGet]
        [Route("api/Karta/GetKupljene/{KorisnikId}")]
        public List<Karte_Korisnici_Kupljene> GetKupljene(int KorisnikId)
        {
            return dm.esp_Karte_Korisnici_Kupljene(KorisnikId).ToList();
        }
        [HttpGet]
        [Route("api/Karta/GetSearchKarte/{EventId?}/{KlasaId?}")]
        public List<Karte_SearchResult> GetSearchKarte(string EventId = "0", string KlasaId = "")
        {
            try
            {
                if ((EventId == "0") && (string.IsNullOrEmpty(KlasaId)))
                {
                    return (dm.esp_Karte_SelectByEventKlasa(null, null)).ToList();
                }
                else if (EventId == "0")
                {
                    return (dm.esp_Karte_SelectByEventKlasa(null, KlasaId)).ToList();
                }
                else if (string.IsNullOrEmpty(KlasaId))
                {
                    return (dm.esp_Karte_SelectByEventKlasa(Int32.Parse(EventId), null)).ToList();
                }
                else
                {
                    return (dm.esp_Karte_SelectByEventKlasa(Int32.Parse(EventId), KlasaId)).ToList();
                }
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return new List<Karte_SearchResult>();
        }

        [ResponseType(typeof(void))]
        [Route("api/Karta/{id}")]
        public IHttpActionResult DeleteKarte(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                dm.esp_Karte_Delete(id);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {


            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }
    }
}