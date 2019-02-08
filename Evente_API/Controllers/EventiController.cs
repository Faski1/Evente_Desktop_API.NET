using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Windows.Forms;
using Evente_API.Models;

namespace Evente_API.Controllers
{
    public class EventiController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [HttpGet]
        public List<Eventi> GetEventi()
        {
            return dm.esp_Eventi_SelectAll().ToList();
        }
        [HttpGet]
        [Route("api/Eventi/BasicSelectAll")]
        public List<Eventi_Result> BasicSelectAll()
        {
            return dm.esp_Eventi_BasicSelectAll().ToList();
        }
        [ResponseType(typeof(Eventi))]
        [HttpPost]
        public IHttpActionResult PostEventi(Eventi obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                obj.EventId = Convert.ToInt32(dm.esp_Eventi_Insert(obj.Naziv, obj.Opis, obj.MinimumGodine, obj.ObjekatOdrzavanja, obj.Adresa, obj.OrganizatorId, obj.KategorijaId, obj.GradId, obj.Slika, obj.SlikaThumb, obj.DatumOdrzavanja, obj.Status).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            try
            {
                dm.esp_EventiUcesnici_Insert(obj.EventId, obj.GlavniUcesnik.UcesnikId);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            
            return CreatedAtRoute("DefaultApi", new { id = obj.EventId }, obj);
        }
        [HttpGet]
        [Route("api/Eventi/SearchByName/{name?}")]
        public List<Eventi_SearchResult> SearchByName(string name = "")
        {
            try
            {
                return dm.esp_Eventi_SelectByNaziv(name).ToList();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Eventi/SearchByKategorija/{KategorijaId}")]
        public List<Eventi_SelectByVrsta> SearchByKategorija(int KategorijaId)
        {
            try
            {
                return dm.esp_Eventi_SelectByVrsta(KategorijaId).ToList();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return null;
        }
        [ResponseType(typeof(void))]
        [Route("api/Eventi/{id}")]
        public IHttpActionResult DeleteEventi(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                dm.esp_Eventi_Delete(id);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        [Route("api/Eventi/GetEventiById/{EventId}")]
        public IHttpActionResult GetEventiById(int EventId)
        {
            Eventi_DetailsResult k = dm.esp_Eventi_Details(EventId).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }
        [Route("api/Eventi/GetEventiKategorijaFav/{KorisnikId}/{Kategorija}")]
        [HttpGet]
        public List<Eventi_Result> GetEventiKategorijaFav(int KorisnikId, string Kategorija)
        {
            try
            {
                return dm.esp_Eventi_Kategorija_NeKupljeni(KorisnikId, Kategorija).ToList();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Eventi/GetPreporuceni/{EventId}")]
        public Eventi_Preporuceni GetPreporuceni(int EventId)
        {
            try
            {
                return dm.esp_Eventi_Preporuceni(EventId).FirstOrDefault();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return null;
        }

        [HttpGet]
        [Route("api/Eventi/GetBezKatPreporuceni/{KorisnikId}")]
        public List<Eventi_Preporuceni> GetBezKatPreporuceni(int KorisnikId)
        {
            try
            {
                return dm.esp_Eventi_PreporuceniBezKategorije(KorisnikId).ToList();
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return null;
        }

        [Route("api/Eventi/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEventi(int id, Eventi k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != k.EventId)
            {
                return BadRequest();
            }

            dm.esp_Eventi_Update(id,k.Naziv, k.MinimumGodine, k.ObjekatOdrzavanja, k.Opis, k.Adresa, k.DatumOdrzavanja, k.Status, k.Slika, k.SlikaThumb, k.OrganizatorId, k.KategorijaId, k.GradId);

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