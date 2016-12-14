using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using IISManager.Core.Exceptions;

namespace IISManager.Filters
{
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            context.Response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, new
            {
                result = "Error",
                message = context.Exception is BusinessException ? context.Exception.Message : context.Exception.ToString()
            });
        }
    }
}