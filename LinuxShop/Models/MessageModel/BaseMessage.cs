using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinuxShop.Common;

namespace LinuxShop.Models.MessageModel
{
    public class BaseMessage
    {
        /// <summary>
        /// 返回编码
        /// </summary>
        public HttpStatus code { get; set; }
        /// <summary>
        /// 信息
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 成功标志
        /// </summary>
        public dynamic data { get; set; }
    }
}
