using Evente_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Evente_UI.Util
{
    class WebAPIHelper
    {
        public HttpClient client { get; set; }

        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }


        //api/Korisnici/{username}
        public HttpResponseMessage GetResponse(string parametar = "")
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parametar = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse2(string action, string parametar = "", string parametar2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar+"/"+parametar2).Result;
        }
        public HttpResponseMessage GetActionReportDate(string action, string danOd, string mjesecOd, string godinaOd, string danDo, string mjesecDo, string godinaDo)
        {
            return client.GetAsync(route + "/" + action + "/" + danOd + "/" + mjesecOd + "/" + godinaOd + "/" + danDo + "/" + mjesecDo + "/" + godinaDo).Result;
        }
        public HttpResponseMessage PostResponse(Object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }
        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/"+ id, existingObject).Result;
        }
        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }
        public HttpResponseMessage DeleteResponse2(int id, int id2)
        {
            return client.DeleteAsync(route + "/" + id + "/" + id2).Result;
        }
    }
}
