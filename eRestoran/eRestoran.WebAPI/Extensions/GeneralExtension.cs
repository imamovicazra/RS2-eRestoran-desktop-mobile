using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Extensions
{
    public static class GeneralExtensions
    {
        public static int? GetUserID(this HttpContext httpContext)
        {
            if (httpContext.User == null)
            {
                return null;
            }
            return Convert.ToInt32(httpContext.User.Claims.Single(x => x.Type == "id").Value);
        }
    }
}
