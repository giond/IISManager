using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using IISManager.Core.Managers;

namespace IISManager.Controllers
{
    public class SiteController : ControllerBase
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Recycle()
        {
            await AspManager.Recycle();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS pool successfully recycled"});
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Stop()
        {
            await AspManager.Stop();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS site successfully stoped" });
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Start()
        {
            await AspManager.Start();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS site successfully started" });
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Restart()
        {
            await AspManager.Restart();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS site successfully restarted" });
        }
    }
}