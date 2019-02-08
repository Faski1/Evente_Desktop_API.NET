using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Description;
using System.Windows.Forms;
using Evente_API.Models;
using Evente_API.Util;

namespace Evente_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        //api/Korisnici
        [HttpGet]
        public List<Korisnici_Result> GetKorisnici()
        {
            return dm.esp_Korisnici_SelectAll().ToList();
        }


        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {
            Korisnici k = dm.Korisnicis.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            if (k == null)
                return NotFound();


            return Ok(k);
        }
        [Route("api/Korisnici/GetBasicInfo/{KorisnikId}")]
        [HttpGet]
        public Korisnici_BasicInfo GetBasicInfo(int KorisnikId)
        {
            return dm.esp_Korisnci_GetBasicInfo(KorisnikId).FirstOrDefault();
        }

        [Route("api/Korisnici/LoginSelect/{username}")]
        [HttpGet]
        public IHttpActionResult LoginSelect(string username)
        {
            Korisnici_LoginResult k = dm.esp_Korisnici_LoginSelect(username).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }

        [Route("api/Korisnici/GetKorisniciById/{KorisnikId}")]
        public IHttpActionResult GetKorisniciById(string KorisnikId)
        {
            Korisnici k = dm.Korisnicis.Where(x => x.KorisnikId.ToString() == KorisnikId).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }


        //GET api/Korisnici/SearchKorisnici
        [HttpGet]
        [Route("api/Korisnici/SearchByName/{name?}")]
        public List<Korisnici_Result> SearchByName(string name = "")
        {
            return dm.esp_Korisnici_SelectByImePrezime(name).ToList();
        }

        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult PostKorisnici(Korisnici obj)
        {
            if (!ModelState.IsValid)
               return BadRequest(ModelState);
            try
            {
                obj.KorisnikId = Convert.ToInt32(dm.esp_Korisnici_Insert(obj.Ime, obj.Prezime, obj.Email, obj.Telefon, obj.KorisnickoIme, obj.LozinkaSalt, obj.LozinkaHash, obj.Status, obj.Adresa, obj.GradId, obj.Slika, obj.SlikaThumb).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            foreach (var item in obj.Uloge)
            {
                dm.esp_KorisniciUloge_Insert(obj.KorisnikId, item.UlogaId);
            }
            

            return CreatedAtRoute("DefaultApi", new { id = obj.KorisnikId }, obj);
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

        [Route("api/Korisnici/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != k.KorisnikId)
            {
                return BadRequest();
            }

            dm.esp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email, k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Status, k.GradId, k.Adresa, k.Slika, k.SlikaThumb);

            return StatusCode(HttpStatusCode.NoContent);
        }
        [ResponseType(typeof(void))]
        [Route("api/Korisnici/{id}")]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                dm.esp_Korisnici_Delete(id);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dm.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
