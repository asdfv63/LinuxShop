using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinuxShop.Common;
using LinuxShop.Models;
using LinuxShop.Models.MessageModel;
using LinuxShop.Models.ViewModel;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LinuxShop.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        Mongodb.MongoDbHelper mongodb = new Mongodb.MongoDbHelper();
        private ILog log = LogManager.GetLogger(Startup.repository.Name, typeof(HomeController));
        [HttpPost]
        public JsonResult Login([FromBody]LoginModel login)
        {
            var aa = this.HttpContext.Request.Body;
            BaseMessage loginMessage = new BaseMessage(); 
            var userCollection = mongodb.GetMongodbCollection<SessionUsers>("Users");
            //MongoDB.Driver.ExpressionFilterDefinition<Users> mongodbQuery = new MongoDB.Driver.ExpressionFilterDefinition<Users>(entity => entity.UserName == login.loginName && entity.Activity == "1");
            //var userCursor = userCollection.FindSync<Users>(mongodbQuery);
            string guid = Guid.NewGuid().ToString();
            if (userCollection != null)
            {
                var userFluent = IMongoCollectionExtensions.Find<SessionUsers>(userCollection, entity => entity.UserName == login.username && entity.Password == login.password && entity.Activity == "1");
                if (userFluent.Count() > 0)
                {
                    var user = userFluent.First();
                    SessionUsers sessionUser = user;
                    sessionUser.ExpireTime = DateTime.Now.AddMinutes(20);
                    sessionUser.SessionId = guid;
                    SessionHelper.SessionUser.Add(sessionUser);
                    loginMessage.code = HttpStatus.Success;
                    loginMessage.data = new ExpandoObject();
                    loginMessage.data.SessionId = guid;
                    loginMessage.data.DspName = sessionUser.UserDspName;
                    loginMessage.data.ImgUrl = HttpContext.Request.Host.Value+new PathString("/UpLoadImg").Value + "/" + sessionUser.ImgUrl;

                    loginMessage.msg = "登陆成功！";
                }
                else
                {
                    log.Error("账户或密码错误");
                    loginMessage.msg = "账户或密码错误！";
                    loginMessage.code = HttpStatus.LoginFailed;
                    ErrorLoginHelper.AddErrorLoginCount(login.username);
                    if (ErrorLoginHelper.GetErrorLoginCount(login.username) >= 10)
                    {
                        log.Info("撞库攻击"+Common.ErrorLoginHelper.GetUserIp(this.HttpContext));
                    }
                }
            }
            else
            {
                loginMessage.msg = "服务端错误，请联系管理员！";
                log.Error("服务端错误，请联系管理员！");
                loginMessage.code = HttpStatus.LoginFailed;
            }

            //List<Users> myList = new List<Users>() { new Users() { CreateTime =DateTime.Now,UserId="1",Activity="1"},new Users() { CreateTime=DateTime.Now.AddDays(1),UserId="2",Activity="1",UserType=1} };
            //ParameterExpression parameter1 = Expression.Parameter(typeof(Users), "p");
            //ConstantExpression constant1 = Expression.Constant(DateTime.Now.AddMinutes(30));
            //ConstantExpression constant2 = Expression.Constant(DateTime.Now.AddDays(2));
            //MemberExpression member = Expression.PropertyOrField(parameter1, "CreateTime");
            //var query1 = Expression.GreaterThan(member, constant1);
            //var query2 = Expression.LessThan(Expression.PropertyOrField(parameter1, "CreateTime"), constant2);
            //var query = Expression.And(query1, query2);
            //var lambda1 = Expression.Lambda<Func<Users, Boolean>>(query, parameter1);
            //var list = myList.Where(lambda1.Compile());


            //return Json(guid);
            return Json(loginMessage);
        }

        public JsonResult Index()
        {
            return Json("测试OK");
        }
    }
}