using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Windows.Forms;
using Evente_API.Models;
using Evente_API.Util;


namespace Evente_API.Controllers
{
    public class KorisniciLoginController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult PostKorisniciLogin(Korisnici obj)
        {
            if (!ModelState.IsValid)
               return BadRequest(ModelState);
            try
            {
                obj.KorisnikId = Convert.ToInt32(dm.esp_Korisnici_SimpleInsert(obj.Ime,obj.Prezime,obj.Email,obj.KorisnickoIme,obj.LozinkaSalt,obj.LozinkaHash).FirstOrDefault());
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
    }
}


