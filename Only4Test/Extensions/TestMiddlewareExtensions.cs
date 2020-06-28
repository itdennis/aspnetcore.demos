using Microsoft.AspNetCore.Builder;
using Only4Test.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Only4Test.Extensions
{
    public static class TestMiddlewareExtensions
    {
        public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TestMiddleware>();
        }
    }
}
