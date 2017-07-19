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

        private static void GetAccessTokenAndMakePurgeCall1()
        {
            string clientId = "e32a947c-136e-xxxxxx-15eed998b592";
            string clientSecret = "Ga9y3/9wNklz3Ft/xxxxxxxxgqpNM5KZxxxXM";

            string uri = @"https://management.azure.com/subscriptions/xxxxxx-xxxxx/resourcegroups/emptybincdnrg/providers/Microsoft.Cdn/profiles/bluehousecdn/endpoints/bhep/purge?api-version=2015-06-01";
            
            var authenticationContext = new AuthenticationContext("https://login.microsoftonline.com/microsoft.onmicrosoft.com");
            ClientCredential clientCredential = new ClientCredential(clientId, clientSecret);
            Task<AuthenticationResult> resultstr = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientCredential);

            WebClient client = new WebClient();
            //authentication using the Azure AD application
            var token = resultstr.Result.AccessToken;
            client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " +token);
            client.Headers.Add("api - version:2015 - 06 - 01");
            client.Headers.Add("Content - Type", "application / json");

            var bodyText = string.Empty;

            //For individual files
            //dynamic content = new { ContentPaths = new List<string>() { "/1.jpg”, "/2.jpg” } };
            //bodyText = JsonConvert.SerializeObject(content);

            //For purge all (*.*)
            //bodyText = "{\”ContentPaths\”:[\”/*\”]}”;

            try
            {
                var result = client.UploadString(uri, bodyText);
            }
            catch (Exception ew)
            {
                //handle the exception here
            }
        }
        [HttpPost]
        public void Purge()
        {
            //GetAccessTokenAndMakePurgeCall();
            GetAccessTokenAndMakePurgeCall2();
            var jsonresult =new JsonResult()
            {
                Data = "Json字符串",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        private void GetAccessTokenAndMakePurgeCall2()
        {
            var purge = new PurgeHelper.PurgeModel()
            {
                ClientId = "da6fb000-5106-4278-aa72-cfb23552684e",
                ClientSecret = "r6Aou2pjPWrfiWsgfaiJju6V/AlZ0fUwgYDDBcDwVKo=",
                Subscriptions = "1bb2b862-f8fc-4d52-8a1d-a5909d5a0795",
                ResourceGroup = "david",
                CdnProfile = "mscss",
                CdnEndpoint = "mscsssa",
                ActiveDirectory = "microsoft",
                PurgeList = new List<string>(){ "/123.png" }
            };
            PurgeHelper.GetAccessTokenAndMakePurgeCall(purge);
        }

        private void GetAccessTokenAndMakePurgeCall()
        {
            var clientId = "da6fb000-5106-4278-aa72-cfb23552684e";
            var clientSecret = "r6Aou2pjPWrfiWsgfaiJju6V/AlZ0fUwgYDDBcDwVKo=";
            var subscriptions = Request.Form["Subscriptions"];//1bb2b862-f8fc-4d52-8a1d-a5909d5a0795
            var resourceGroup = Request.Form["ResourceGroup"];//david
            var cdnProfile = Request.Form["CDNProfile"];//mscss
            var cdnEndpoint = Request.Form["CDNEndpoint"];//mscsssa

            var uri = 
                @"https://management.azure.com/subscriptions/" + subscriptions +
                @"/resourcegroups/" + resourceGroup +
                @"/providers/Microsoft.Cdn/profiles/" + cdnProfile +
                @"/endpoints/" + cdnEndpoint + 
                @"/purge?api-version=2015-06-01";

            var authenticationContext = new AuthenticationContext("https://login.microsoftonline.com/microsoft.onmicrosoft.com");
            ClientCredential clientCredential = new ClientCredential(clientId, clientSecret);

            //var userCredential=new UserCredential("v-davzhe@microsoft.com");

            //var userpwdCredential=new UserPasswordCredential("v-davzhe@microsoft.com", "Zhy@4869");


            //Task<AuthenticationResult> result1 = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientId, userCredential);


            //Task<AuthenticationResult> result2 = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientId, userpwdCredential);


            //Task<AuthenticationResult> result3 = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientId, credential);

            Task<AuthenticationResult> resultstr = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientCredential);


            //var t1= result1.Result.AccessToken;
            //var t2= result2.Result.AccessToken;
            var t3= resultstr.Result.AccessToken;

            WebClient client = new WebClient();
            //authentication using the Azure AD application
            var token = resultstr.Result.AccessToken;
            client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            client.Headers.Add("api-version:2016-10-02");
            client.Headers.Add("Content-Type", "application/json");

            var bodyText = string.Empty;

            //For individual files
            //dynamic content = new { ContentPaths = new List<string>() { "/1.jpg”, "/2.jpg” } };
            //bodyText = JsonConvert.SerializeObject(content);

            var resource = Request.Form["Resource"];
            dynamic content = new { ContentPaths = new List<string>() { "/" + resource } };
            bodyText = JsonConvert.SerializeObject(content);


            //For purge all (*.*)
            //bodyText = "{\”ContentPaths\”:[\”/*\”]}”;

            try
            {
                var result = client.UploadString(uri, bodyText);
            }
            catch (Exception ew)
            {
                //handle the exception here
            }
        }


        
        private static void GetAccessTokenAndMakePurgeCallBack()
        {
            string clientId = "get it from portal"; //refer step#7 
            string clientSecret = "get it from portal"; //refer step#8 
            string uri = @"https://management.azure.com/subscriptions/update_subscription_id/resourcegroups/resource_group_name/providers/Microsoft.Cdn/profiles/update_profile_name/endpoints/update_endpoint_name/purge?api-version=2016-10-02";

            var authenticationContext = new AuthenticationContext("https://login.microsoftonline.com/update_active_directory_name.onmicrosoft.com"); //refer step #2 
            ClientCredential clientCredential = new ClientCredential(clientId, clientSecret);
            Task<AuthenticationResult> resultstr = authenticationContext.AcquireTokenAsync("https://management.core.windows.net/", clientCredential);

            WebClient client = new WebClient();
            //authentication using the Azure AD application 
            var token = resultstr.Result.AccessToken;
            client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            client.Headers.Add("api-version:2016-10-02");
            client.Headers.Add("Content-Type", "application/json");

            var bodyText = string.Empty;

            //For individual files 
            //dynamic content = new { ContentPaths = new List<string>() { "/1.jpg", "/2.jpg" } }; 
            //bodyText = JsonConvert.SerializeObject(content); 

            //For purge all (*.*) 
            bodyText = "{\"ContentPaths\":[\"/*\"]}";

            try
            {
                var result = client.UploadString(uri, bodyText);
            }
            catch (Exception)
            {
                //should not see any exception here. 
            }
        }
    }
}