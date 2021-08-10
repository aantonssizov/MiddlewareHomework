using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareHomework
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder applicationBuilder, string path)
        {
            return applicationBuilder.Map(path, b => b.UseMiddleware<PublishMiddleware>());
        }
    }
}
