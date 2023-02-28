using Microsoft.AspNetCore.Builder;

namespace NotesWebAPI.Middleware
{
    public static class CustomExeptionHandlerMiddlewareExeptions
    {
        public static IApplicationBuilder UseCustomExeptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExeptionHandlerMiddleware>();
        }
    }
}
