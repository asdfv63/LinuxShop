using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinuxShop.Models.ErrorModel;
using Microsoft.AspNetCore.Http;

namespace LinuxShop.Common
{
    public class ErrorLoginHelper
    {
        public static List<ErrorLogin> ErrorLoginList = new List<ErrorLogin>();

        /// <summary>
        /// 删除过期的对象
        /// </summary>
        public static void RemoveExpireEntity()
        {
            ErrorLoginList = ErrorLoginList.Where(entity => entity.ExpireTime >= DateTime.Now).ToList<ErrorLogin>();
        }
        /// <summary>
        /// 删除登录名对象
        /// </summary>
        /// <param name="sessionId"></param>
        public static void RemoveByLoginName(string loginName)
        {
            ErrorLoginList = ErrorLoginList.Where(entity => entity.LoginName != loginName).ToList<ErrorLogin>();
        }

        /// <summary>
        /// 根据登录名获取实体
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public static ErrorLogin GetErrorLoginEntityByLoginName(string loginName)
        {
            var result = ErrorLoginList.Where(entity => entity.LoginName == loginName);
            if (result.Count() > 0)
            {
                return result.Single<ErrorLogin>();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 相应登录用户名增加错误登陆次数
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public static bool AddErrorLoginCount(string loginName)
        {
            var result = ErrorLoginList.Where(entity => entity.LoginName == loginName);
            if (result.Count() > 0)
            {
                result.Single<ErrorLogin>().ErrorCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取登陆用户名的错误登陆次数
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public static int GetErrorLoginCount(string loginName)
        {
            RemoveExpireEntity();//删除过期对象
            var result = ErrorLoginList.Where(entity => entity.LoginName == loginName);
            if (result.Count() > 0)
            {
                return result.Single<ErrorLogin>().ErrorCount;
            }
            else
            {
                //ErrorLogin errorLogin = new ErrorLogin();
                //errorLogin.LoginName = loginName;
                //errorLogin.ErrorCount = 1;
                //errorLogin.ExpireTime.AddMinutes(10);
                //ErrorLoginList.Add(errorLogin);
                //return 1;
                return 0;
            }
        }

        public static string GetUserIp( HttpContext context)
        {
            var ip = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(ip))
            {
                ip = context.Connection.RemoteIpAddress.ToString();
            }
            return ip;
        }
    }
}
