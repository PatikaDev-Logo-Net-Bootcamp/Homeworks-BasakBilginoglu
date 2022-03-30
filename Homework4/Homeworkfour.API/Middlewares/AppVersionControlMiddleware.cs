using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Homeworkfour.Middlewares
{
    public class AppVersionControlMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
