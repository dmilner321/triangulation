using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Models;
using Newtonsoft.Json;


namespace Triangle1API
{
    public static class Triangulation1
    {
        [FunctionName("Triangulation1")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // parse query parameter
            string gridLocation = req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "gridlocation", true) == 0)
                .Value;

            // Get request body
            dynamic data = await req.Content.ReadAsAsync<object>();

            // Set name to query string or body data
            gridLocation = gridLocation ?? data?.gridLocation;

            var tri1 = (gridLocation == null) ? null : Triangle.GetTriangle(gridLocation);

            string json = JsonConvert.SerializeObject(tri1, Formatting.Indented);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

    }
}
