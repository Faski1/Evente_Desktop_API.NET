using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using Evente_API.Models;
using Evente_API.Util;

namespace Evente_API.Controllers
{
    public class PreporukeController : ApiController
    {
        [HttpGet]
        [Route("api/Preporuke/GetPreporuka/{KorisnikId}")]
        public List<Eventi_Preporuceni> GetPreporuka(int KorisnikId)
        {
            Recommender r = new Recommender();
            return r.RecommendedByTypeGrade(KorisnikId).ToList();
        }
       
        

    }
}