using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TaskController
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareTask
    {
        private readonly RequestDelegate _next;

        public MiddlewareTask(RequestDelegate next)
        {
            _next = next;
        }

        public  Task Invoke(HttpContext httpContext)
        {
            return httpContext.Response.WriteAsync("shifi you so good!!!😍");


        }

        private Task request(HttpContext httpContext)
        {
            throw new NotImplementedException();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareTaskExtensions
    {
        public static IApplicationBuilder UseMiddlewareTask(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareTask>();
        }
    }
}
