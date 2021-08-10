using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;
using Interfaces;

namespace MiddlewareHomework
{
    public class PublishMiddleware
    {
        private readonly RequestDelegate _next;

        public PublishMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ISaveInfoService saveInfo, IUploadArticleService uploadArticle)
        {
            saveInfo.SaveInfo();
            uploadArticle.UploadArticle();
            await context.Response.WriteAsync("Published Article");
            await _next.Invoke(context);
        }
    }
}
