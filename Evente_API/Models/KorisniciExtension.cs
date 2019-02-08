using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Evente_API.Models
{
    public partial class Korisnici
    {
        public List<Uloge> Uloge { get; set; }
    }
}