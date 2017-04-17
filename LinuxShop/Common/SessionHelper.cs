using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinuxShop.Models;

namespace LinuxShop.Common
{
    public static class SessionHelper
    {
        public static List<SessionUsers> SessionUser { get; set; }

        /// <summary>
        /// 删除过期的对象
        /// </summary>
        public static void RemoveExpireEntity()
        {
            SessionUser = SessionUser.Where(entity => entity.ExpireTime>=DateTime.Now).ToList<SessionUsers>();
        }
        /// <summary>
        /// 根据sessionId对象
        /// </summary>
        /// <param name="sessionId"></param>
        public static void RemoveBySessionId(string sessionId)
        {
            SessionUser = SessionUser.Where(entity => entity.SessionId != sessionId).ToList<SessionUsers>();
        }

        /// <summary>
        /// 根据sessionId获取实体
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public static SessionUsers GetSessionEntityBySessionId(string sessionId)
        {
            var result = SessionUser.Where(entity => entity.SessionId == sessionId);
            if (result.Count() >0)
            {
                return result.Single<SessionUsers>();
            }
            else
            {
                return null;
            }
        }

    }
}
