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
    public class NarudzbeController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            narudzbe.NarudzbaId = Convert.ToInt32(dm.esp_Narudzbe_Insert(narudzbe.BrojNarudzbe,narudzbe.Datum, narudzbe.KorisnikId).FirstOrDefault());

            

            foreach (NarudzbaStavke item in narudzbe.NarudzbaStavke)
            {
                dm.esp_NarudzbeStavke_Insert(item.BrojKarata, item.KarteId, narudzbe.NarudzbaId);
            }



            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaId }, narudzbe.NarudzbaId);
        }
    }
}

