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
    public class UlogeController : ApiController
    {
        private EventeEntities dm = new EventeEntities();
        public List<Uloge> GetUloge()
        {
            return dm.esp_Uloge_SelectAll().ToList();
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