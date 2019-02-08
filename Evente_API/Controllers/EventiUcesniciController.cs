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
    public class EventiUcesniciController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [HttpGet]
        [Route("api/EventiUcesnici/GetSearchEventiUcesnici/{EventId?}/{UcesnikId?}")]
        public List<EventiUcesnici_SearchResult> GetSearchEventiUcesnici(string EventId="0", string UcesnikId="")
        {
            try
            {
                if ((EventId=="0") && (string.IsNullOrEmpty(UcesnikId)))
                {
                    return (dm.esp_EventiUcesnici_SelectByEventUcesnik(null, null)).ToList();
                }
                else if (EventId == "0")
                {
                    return (dm.esp_EventiUcesnici_SelectByEventUcesnik(null, Int32.Parse(UcesnikId))).ToList();
                }
                else if (string.IsNullOrEmpty(UcesnikId))
                {
                    return (dm.esp_EventiUcesnici_SelectByEventUcesnik(Int32.Parse(EventId), null)).ToList();
                }
                else
                {
                    return (dm.esp_EventiUcesnici_SelectByEventUcesnik(Int32.Parse(EventId), Int32.Parse(UcesnikId))).ToList();
                }
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return new List<EventiUcesnici_SearchResult>();
        }

        [HttpPost]
        public IHttpActionResult PostEventiUcesnici(EventiUcesnici obj)
        {
            try
            {
                dm.esp_EventiUcesnici_Insert(obj.EventiId, obj.UcesnikId);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return Ok();
        }

        [ResponseType(typeof(void))]
        [Route("api/EventiUcesnici/{EventId}/{UcesnikId}")]
        public IHttpActionResult DeleteKorisnici(string EventId, string UcesnikId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                dm.esp_EventiUcesnici_Delete(Int32.Parse(EventId), Int32.Parse(UcesnikId));
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