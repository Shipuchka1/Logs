using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Log.Models;


namespace Log.Filtres
{
    public class LogAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;

            Log.Models.Log log = new Models.Log()
            {
                UserName = request.IsAuthenticated ? filterContext.HttpContext.User.Identity.Name : "Guest",
                UserIP = request.UserHostAddress,
                DateVisit = DateTime.Now,
                Page = request.Url.AbsoluteUri
            };

            using (Model1 db = new Model1())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }
    }
}