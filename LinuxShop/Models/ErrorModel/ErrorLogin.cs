using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinuxShop.Models.ErrorModel
{
    public class ErrorLogin
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 错误次数
        /// </summary>
        public int ErrorCount { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpireTime { get; set; }
    }
}
