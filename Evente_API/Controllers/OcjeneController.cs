using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using Evente_API.Models;

namespace Evente_API.Controllers
{
    public class OcjeneController : ApiController
    {
        private EventeEntities dm = new EventeEntities();

        [HttpGet]
        [Route("api/Ocjene/GetOcjena/{KorisnikId}/{EventId}")]
        public Ocjene GetOcjena(int KorisnikId, int EventId)
        {
            return dm.Ocjenes.Where(x => x.KorisnikId == KorisnikId && x.EventId==EventId).FirstOrDefault();
        }
        [HttpPost]
        public IHttpActionResult PostOcjene(Ocjene ocjene)
        {
            if(ocjene!=null)
            {
                dm.esp_Ocjena_Insert(ocjene.Ocjena, ocjene.EventId, ocjene.KorisnikId);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
            
        }
        [HttpGet]
        [Route("api/Ocjene/GetProsjecna/{EventId}")]
        public double GetProsjecna(int EventId)
        {
            return (dm.esp_Ocjene_Event_Prosjecna(EventId).FirstOrDefault().Value);
        }

        //[HttpPost]
        //[Route("api/Ocjene/UpdateOcjenaById/{Ocjena}")]
        //public void UpdateOcjenaById(Ocjene ocjena)
        //{
        //    return dm.Kategorijes.Where(x => x.KategorijaId == KategorijaId).FirstOrDefault().Naziv;
        //}

    }
}