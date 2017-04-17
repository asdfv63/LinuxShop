using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinuxShop.Common;
using LinuxShop.Models;
using LinuxShop.Models.MessageModel;
using log4net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LinuxShop.Filter
{
    public class AuthenticationExtend : IAuthorizationFilter
    {
        private ILog log = LogManager.GetLogger(Startup.repository.Name, typeof(AuthenticationExtend));
        void IAuthorizationFilter.OnAuthorization(AuthorizationFilterContext context)
        {
            var control = context.RouteData.Values["controller"].ToString().ToLower();
            var action = context.RouteData.Values["action"].ToString().ToLower();
            if (control != "permission" && action != "login")
            {
                //var sessionId = context.RouteData.Values["sessionId"].ToString();
                var sessionId = context.HttpContext.Request.Headers["sessionId"].ToString();
                SessionUsers sessionUsers = SessionHelper.GetSessionEntityBySessionId(sessionId);
                if (sessionUsers != null)
                {
                    if (sessionUsers.UserId != "1")
                    {
                        if (sessionUsers.Permission.Where(entity => entity.Description == action).Count() == 0)
                        {
                            //context.Result = new Microsoft.AspNetCore.Mvc.RedirectResult("/Home/Login");
                            //context.Result = new Microsoft.AspNetCore.Mvc.StatusCodeResult(403);
                            log.Error("登陆失败");
                            context.Result = new Microsoft.AspNetCore.Mvc.JsonResult(new BaseMessage() { code = HttpStatus.PermissionDeny, msg = "权限错误" });
                        }
                    }
                }
                else
                {
                    //context.Result = new Microsoft.AspNetCore.Mvc.RedirectResult("/Home/Login");
                    //context.Result = new Microsoft.AspNetCore.Mvc.StatusCodeResult(403);
                    log.Error("登陆失败");
                    context.Result = new Microsoft.AspNetCore.Mvc.JsonResult(new BaseMessage (){ code= HttpStatus.PermissionDeny, msg="权限错误"});
                }
            }
        }
    }
}
