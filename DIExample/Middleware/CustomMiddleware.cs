using DIExample.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DIExample.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
           _next = next;

        }
        public async Task InvokeAsync(HttpContext context, WelcomeMessageForMiddleWare message )
        {
            context.Items.Add("Welcome", message);
            await _next(context);
        }
    }
}
