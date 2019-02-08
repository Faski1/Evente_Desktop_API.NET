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
    public class OrganizatoriController : ApiController
    {
        private EventeEntities dm = new EventeEntities();
        

        [HttpGet]
        [Route("api/Organizatori/GetBasicOrganizatori")]
        public List<Organizatori_Result> GetBasicOrganizatori()
        {
            return dm.esp_Organizatori_BasicSelect().ToList();
        }
        [HttpGet]
        public List<Organizatori> GetOrganizatori()
        {
            return dm.esp_Organizatori_SelectAll().ToList();
        }
        public IHttpActionResult PostOrganizatori(Organizatori obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Organizatoris.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.OrganizatorId }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri dodavanju!");
                return NotFound();
            }


        }
    }
}