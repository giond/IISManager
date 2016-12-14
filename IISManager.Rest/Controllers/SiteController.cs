using System.Net;
using System.Net.Http;
using System.Web.Http;
using IISManager.Managers;
using System.Threading.Tasks;

namespace IISManager.Controllers
{
    public class SiteController : ControllerBase
    {
        [HttpPost]
        public HttpResponseMessage Recycle()
        {
            AspManager.Recycle();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS pool successfully recycled"});
        }

        [HttpPost]
        public HttpResponseMessage Stop()
        {
            AspManager.Stop();

            return Request.CreateResponse(HttpStatusCode.OK, new { result = "Success", message = "IIS site successfully stoped" });
        }

        [HttpPost]
        public HttpResponseMessage Start()
        {
            AspManager.Start();

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