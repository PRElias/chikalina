using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using chikalina.Models;
using Chikalina.Models;
using Facebook;
using Microsoft.Extensions.Options;

namespace chikalina.Controllers
{
    public class HomeController : Controller
    {
        public List<Fotos> Fotos { get; set; }
        private readonly IOptions<Keys> _config;

        public HomeController(IOptions<Keys> config)
        {
            _config = config;
        }


        public ActionResult Index()
        {
            Fotos = new List<Fotos>();
            var appid = _config.Value.FacebookAppId;
            var appsecret = _config.Value.FacebookAppSecret;
            string appAccessToken = string.Concat(appid, "|", appsecret);
            var fb = new FacebookClient(appAccessToken);
            dynamic result = fb.Get("1219310658089410?fields=albums.fields(photos.fields(source))");
            dynamic fotos = result["albums"]["data"][0]["photos"][0];

            foreach (var item in fotos)
            {
                if (Fotos.Count < 24)
                {
                    Fotos.Add(new Fotos { Url = item.source });
                }
            }

            ViewBag.FacebookAppId = appid;
            return View(Fotos);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
