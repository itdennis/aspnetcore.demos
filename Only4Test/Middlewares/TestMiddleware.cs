using Microsoft.AspNetCore.Http;
using Only4Test.Interface;
using System.Threading.Tasks;

namespace Only4Test.Middlewares
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;
        private static IParaInterface _parameter;


        public TestMiddleware(RequestDelegate next, IParaInterface parameter)
        {
            _next = next;
            _parameter = parameter;
        }

        public async Task Invoke(HttpContext context)
        {
            // Your code
            _parameter.someFunction();
            await _next.Invoke(context);
        }
    }
}
