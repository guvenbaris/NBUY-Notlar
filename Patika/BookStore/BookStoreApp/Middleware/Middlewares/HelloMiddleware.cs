using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Middleware.Middlewares
{
    public class HelloMiddleware
    { 
        private readonly RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Hello World");
            await _next.Invoke(context);
            Console.WriteLine("Bye World");
        }
    }

    public static class HelloMiddlewareExtension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder builder)
        { 
            return builder.UseMiddleware<HelloMiddleware>();
        }
    }
}
