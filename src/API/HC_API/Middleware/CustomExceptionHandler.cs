using HC_API.Utils.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HC_API.Middleware
{
	public class CustomExceptionHandler
	{
		private readonly RequestDelegate _next;
		private readonly ILoggerService _logger;

        public CustomExceptionHandler(RequestDelegate next, ILoggerService logger)
		{
			_next = next;
			_logger = logger;
		}

		public async Task Invoke(HttpContext httpContext)
		{
            //Bütün aksiyon burada yakalanıyor.
            var watch = Stopwatch.StartNew();
            try
            {
                string message = "[Request]  HTTP " + httpContext.Request.Method + " - " + httpContext.Request.Path;
                _logger.Log(message);

                await _next(httpContext);
                watch.Stop();//Request cevaplandığı için burada süreyi bitir!

                message = "[Response] HTTP " + httpContext.Request.Method + " - " + httpContext.Request.Path + " responded " + httpContext.Response.StatusCode + " in " + watch.Elapsed.TotalMilliseconds + " ms.";
                _logger.Log(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleException(httpContext, ex, watch);
            }
        }
        private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; //Hata durumunda 500 dönsün dedim ancak faklı middleware'ler yazılarak durumlara göre uygun kodlar döndürelebilir!

            string errorMessage = "[Error]    HTTP " + context.Request.Method + " - " + context.Response.StatusCode + " Error Message " + ex.Message + " in " + watch.Elapsed.TotalMilliseconds + " ms";
            _logger.Log(errorMessage);
            //Console.WriteLine(errorMessage);

            var result = JsonConvert.SerializeObject(new
            {
                error = ex.Message,
                Formatting.None
            });

            return context.Response.WriteAsync(result);
        }
        public static class CustomExceptionHandlerExtension
        {
           
        }

    }
}
