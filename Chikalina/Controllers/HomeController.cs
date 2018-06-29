using Chikalina.Models;
using Facebook;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Chikalina.Controllers
{
    public class HomeController : Controller
    {
        public List<Fotos> Fotos { get; set; }

        public ActionResult Index()
        {
            Fotos = new List<Models.Fotos>();
            var appid = keys.appid;
            var appsecret = keys.appsecret;
            string appAccessToken = string.Concat(appid, "|", appsecret);
            var fb = new FacebookClient(appAccessToken);
            dynamic result = fb.Get("1219310658089410?fields=albums.fields(photos.fields(source))");
            dynamic fotos = result["albums"]["data"][0]["photos"][0];

            foreach (var item in fotos)
            {
                if (Fotos.Count < 24)
                {
                    Fotos.Add(new Models.Fotos { Url = item.source });
                }
            }

            return View(Fotos);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Privacidade()
        {
            return View();
        }
    }
}