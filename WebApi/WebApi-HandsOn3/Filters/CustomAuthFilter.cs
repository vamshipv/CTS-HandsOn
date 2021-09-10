﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;

namespace WebApi_HandsOn3.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var barer = filterContext.HttpContext.Request.Headers[HeaderNames.Authorization];

                if (barer.ToString() != "")
                {
                    var token = filterContext.HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer", "");
                    if (token == "")
                    {
                        filterContext.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
                    }
                }
                else
                {
                    filterContext.Result = new BadRequestObjectResult("Invalid request - No Auth token.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
