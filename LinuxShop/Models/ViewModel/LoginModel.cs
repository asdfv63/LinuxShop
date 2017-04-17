using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinuxShop.Models.ViewModel
{
    public class LoginModel
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string verificationCode { get; set; }
    }
}
