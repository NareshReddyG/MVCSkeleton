using Skeleton.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skeleton.App_Start
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception != null && !filterContext.ExceptionHandled)
            {
                Logger.Logger.GetLogger().LogError(filterContext.Exception);
                filterContext.ExceptionHandled = true;

                //If we need we can route to custom error page to the end user

                //UrlHelper _urlHelper = new UrlHelper(filterContext.RequestContext);
                //string _url = _urlHelper.Action("Index", "ApplicationSupport", new { area = ""});
                //filterContext.Result = new RedirectResult(_url);
                //filterContext.HttpContext.Response.Clear();
                //filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            }
            base.OnException(filterContext);
        }
    }
}