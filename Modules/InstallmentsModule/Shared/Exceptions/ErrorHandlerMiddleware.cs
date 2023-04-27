using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace InstallmentsModule.Shared.Exceptions
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        private readonly ConcurrentDictionary<Type, string> _codes = new();



        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            //catch (DbUpdateException ex)
            //{
            //    var innerException = ex.InnerException as SqlException;
            //    if (innerException?.Number == 2601 || innerException?.Number == 2627)
            //    {
            //        var match = Regex.Match(innerException.Message, @"Duplicate entry '(.*?)' for key '(.+?)'");
            //        var errorMessage = string.Format("The value for {0} already exists in the database.", match.Groups[2].Value);
            //        throw new Exception(errorMessage, ex);
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            catch (Exception exception)
            {
                var statusCode = 500;
                var code = "error";
                var message = "There was an error.";

                if (exception is CustomException customException)
                {
                    statusCode = 400;
                    var exceptionType = customException.GetType();
                    if (!_codes.TryGetValue(exceptionType, out var errorCode))
                    {
                        code = customException.GetType().Name.Replace("_exception", string.Empty);
                        _codes.TryAdd(exceptionType, code);
                    }
                    else
                    {
                        code = errorCode;
                    }

                    message = customException.Message;
                }

                context.Response.StatusCode = statusCode;
                await context.Response.WriteAsync(message);
            }
        }
    }
}
