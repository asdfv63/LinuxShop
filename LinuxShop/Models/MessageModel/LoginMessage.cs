using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinuxShop.Models.MessageModel
{
    public class LoginMessage
    {
        public string SessionId { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string DspName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string ImgUrl { get; set; }
    }
}
