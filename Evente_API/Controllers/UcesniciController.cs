using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using Evente_API.Models;

namespace Evente_API.Controllers
{
    public class UcesniciController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [HttpGet]
        public List<Ucesnici> GetUcesnici()
        {
            return dm.esp_Ucesnici_SelectAll().ToList();
        }
        public IHttpActionResult PostUcesnici(Ucesnici obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Ucesnicis.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.UcesnikId }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri dodavanju!");
                return NotFound();
            }


        }
    }
}