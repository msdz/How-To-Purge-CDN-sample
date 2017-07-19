using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CDN_Pruge_Tools.Businesses;
using Newtonsoft.Json;

namespace CDN_Pruge_Tools.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //Sample C# code used for purge ( from WebApplication )

        public ActionResult Contact()
        {
            GetAccessTokenAndMakePurgeCall();

            ViewBag.Result = "Done – Purged all.. ";

            return View();
        }

        [HttpPost]
        public void Purge()
        {
            //GetAccessTokenAndMakePurgeCall();
            GetAccessTokenAndMakePurgeCall();
        }

        private void GetAccessTokenAndMakePurgeCall()
        {
            var purge = new PurgeHelper.PurgeModel()
            {
                ClientId = "da6fb000-xxxx-xxxx-xxxx-cfb23552684e",
                ClientSecret = "r6Aou2pjPWrxxxxxxxxlZ0fxxxxxDwVKo=",
                Subscriptions = "1bbxxx62-xxxx-xxxx-xxxx-a5909d5a0795",
                ResourceGroup = "daxxxx",
                CdnProfile = "msxxxxs",
                CdnEndpoint = "msxxxxxa",
                ActiveDirectory = "mixxxxxt",
                PurgeList = new List<string>(){ "/123.png" }
            };
            PurgeHelper.GetAccessTokenAndMakePurgeCall(purge);
        }
        }
}