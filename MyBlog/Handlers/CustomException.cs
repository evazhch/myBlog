using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Common.Model;

namespace MyBlog.Handlers
{
    public class CustomExceptionHandler(ILogger<CustomException> logger, IWebHostEnvironment environment) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is not CustomException customException) return false;
            logger.LogError(
                  exception, "Exception occurred: {Message} {StackTrace} {Source}", exception.Message, exception.StackTrace, exception.Source);

            var problemDetails = new ProblemDetails
            {
                Status = customException.Code,
                Title = customException.Message,
            };
            if (environment.IsDevelopment())
            {
                problemDetails.Detail = $"Exception occurred: {customException.Message} {customException.StackTrace} {customException.Source}";
            }
            httpContext.Response.StatusCode = problemDetails.Status.Value;
            await httpContext.Response
                .WriteAsJsonAsync(problemDetails, cancellationToken);
            return true;
        }
    }
}
