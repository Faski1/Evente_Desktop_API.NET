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
    public class GradController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        //api/Gradovi
        [HttpGet]
        public List<Grad_Result> GetGrad()
        {
            return dm.esp_Grad_SelectAll().ToList();
        }
        public IHttpActionResult PostGrad(Grad obj)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            dm.Grads.Add(obj);
            try
            {
                dm.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = obj.GradId }, obj);
            }
            catch (Exception)
            {
                MessageBox.Show("Grad vec postoji!");
                return NotFound();
            }
           
            
        }

    }
}