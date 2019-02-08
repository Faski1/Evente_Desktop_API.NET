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
    public class KategorijeController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [HttpGet]
        public List<Kategorije> GetKategorije()
        {
            return dm.esp_Kategorija_SelectAll().ToList();
        }
        [HttpGet]
        [Route("api/Kategorije/GetKategorijaById/{KategorijaId}")]
        public string GetKategorijaById(int KategorijaId)
        {
            return dm.Kategorijes.Where(x => x.KategorijaId == KategorijaId).FirstOrDefault().Naziv;
        }
        public IHttpActionResult PostKategorije(Kategorije obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Kategorijes.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.KategorijaId }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri dodavanju!");
                return NotFound();
            }


        }
        [HttpGet]
        [Route("api/Kategorije/GetOmiljena/{KorisnikId}")]
        public List<Kategorije_Omiljena> GetOmiljena(int KorisnikId)
        {
            return dm.esp_Kategorije_Omiljena(KorisnikId).ToList();
        }
    }
}