using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

namespace CDN_Pruge_Tools.Businesses
{
    public class PurgeHelper
    {
        public static void GetAccessTokenAndMakePurgeCall(PurgeModel purge)
        {
            var uri = @"https://management.azure.com/subscriptions/" + purge.Subscriptions +
                      @"/resourcegroups/" + purge.ResourceGroup +
                      @"/providers/Microsoft.Cdn/profiles/" + purge.CdnProfile +
                      @"/endpoints/" + purge.CdnEndpoint +
                      @"/purge?api-version=2015-06-01";

            var authenticationContext = new AuthenticationContext(@"https://login.microsoftonline.com/" + purge.ActiveDirectory + @".onmicrosoft.com");
            var clientCredential = new ClientCredential(purge.ClientId, purge.ClientSecret);
            var resultstr = authenticationContext.AcquireTokenAsync(@"https://management.core.windows.net/", clientCredential);
            var token = resultstr.Result.AccessToken;

            dynamic content = new { ContentPaths = purge.PurgeList };
            //For purge all (*.*)  bodyText = "{\”ContentPaths\”:[\”/*\”]}”;

            var responeCode = GetPurgeHttpStatusCode(uri, token, content);
            if (responeCode == HttpStatusCode.Accepted)
            {
                //Pruge Successful
            }
            else
            {
                //Pruge Failed
            }
        }

        /// <summary>
        /// AzurePurgeHttp
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="token"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static HttpStatusCode GetPurgeHttpStatusCode(string uri, string token, object content)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + token);
                var stringContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8);
                stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json") { CharSet = "utf-8" };

                stringContent.Headers.Add("api-version", "2016-10-02");
                var responseMsg = httpClient.PostAsync(uri, stringContent).Result;
                return responseMsg.StatusCode;
            }
        }


        public class PurgeModel
        {
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string Subscriptions { get; set; }
            public string ResourceGroup { get; set; }
            public string CdnProfile { get; set; }
            public string CdnEndpoint { get; set; }
            public string ActiveDirectory { get; set; }
            public List<string> PurgeList { get; set; }
        }

    }
}
