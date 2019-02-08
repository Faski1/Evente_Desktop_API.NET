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
    public class DrzavaController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        //api/Drzava
        [HttpGet]
        public List<Drzava> GetDrzava()
        {
            return dm.esp_Drzava_SelectAll().ToList();
        }
        public IHttpActionResult PostDrzava(Drzava obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Drzavas.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.DrzavaId }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Drzava vec postoji!");
                return NotFound();
            }
            
            
        }
        
    }
}