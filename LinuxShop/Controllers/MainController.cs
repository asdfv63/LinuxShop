using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinuxShop.Models;
using LinuxShop.Mongodb;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LinuxShop.Controllers
{
    public class MainController : Controller
    {
        Mongodb.MongoDbHelper mongodb = new Mongodb.MongoDbHelper();
        public IActionResult Index()
        {
            var collection = mongodb.GetMongodbCollection<Users>("Users");
            MongoDB.Driver.ExpressionFilterDefinition<Users> a = new MongoDB.Driver.ExpressionFilterDefinition<Users>(entity => entity.UserId == "430b85c7-4d62-4082-b014-e23bb1e5657d");
            var ss = collection.FindSync<Users>(a).First<Users>();
            //using (var context = new DataContext())
            //{
            //    context.Database.EnsureCreated();
            //    var user = new Users {UserId = Guid.NewGuid().ToString(),UserName="测试" };
            //    context.Add(user);

            //    context.SaveChanges();
            //}

            //MongoDbHelper mongodb = new MongoDbHelper();
            //var collection = mongodb.GetMongodbCollection<Users>("Users");
            //Users user = new Users();
            //user.UserId = Guid.NewGuid().ToString();
            //user.UserDspName = "管理员";
            //user.Activity = "1";
            //user.BirthDay = DateTime.Now.AddHours(8);
            //user.CardId = "123344";
            //user.CreateTime = DateTime.Now.AddHours(8);
            //user.StatusTime = DateTime.Now.AddHours(8);
            //user.Email = "2831465789@qq.com";
            //user.EmployeeId = "1";
            //user.MobilePhone = "12345678911";
            //user.Password = "123";
            //user.Sex = "1";
            //user.Style = "1";
            //user.UserDspName = "管理员";
            //user.UserType = 1;
            //collection.InsertOne(user);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}