using HomeworkTwo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace HomeworkTwo.Middlewares
{
    public class VersionControlMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public VersionControlMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _configuration = config;
        
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //get current version app-version
            string currentVersion = _configuration.GetValue<string>("app-version");
            //put request version's header app-version
           Version requestVersion = new Version(httpContext.Request.Headers["app-version"]);
            
            if ( httpContext.Request.Path == "/Login" || httpContext.Request.Path == "/Register")
            {
                await _next(httpContext);
            }
            //version comparing
            else if (requestVersion.CompareTo(currentVersion) >0 )
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            }
            else if(requestVersion.CompareTo(currentVersion) <= 0)
            {
                await _next(httpContext);
            }
           
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class VersionControlMiddlewareExtensions
    {
        public static IApplicationBuilder UseVersionControlMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<VersionControlMiddleware>();
        }
    }
}
