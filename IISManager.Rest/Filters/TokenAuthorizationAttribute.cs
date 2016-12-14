using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IISManager.Managers;

namespace IISManager.Filters
{
    public class TokenAuthorizationAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.FirstOrDefault(c => c.Key == "X-IIS-Access-Token");

            if (token.Key == null || token.Value.Count() != 1 || token.Value.FirstOrDefault() != ConfigurationManager.Token)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new { result = "Error", message = "Authentication error." });
            }
        }
    }
}