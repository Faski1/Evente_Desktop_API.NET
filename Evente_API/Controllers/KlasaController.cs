using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using Evente_API.Models;

namespace Evente_API.Controllers
{
    public class KlasaController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        //api/Gradovi
        [HttpGet]
        public List<Klasa> GetKlasa()
        {
            var Klase = dm.Klasas;
            return Klase.ToList();
        }
        public IHttpActionResult PostKlasa(Klasa obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Klasas.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.Naziv }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Klasa vec postoji!");
                return NotFound();
            }


        }

    }
}