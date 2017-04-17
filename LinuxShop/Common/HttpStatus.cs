using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinuxShop.Common
{
    public enum HttpStatus
    {
        /// <summary>
        /// 权限拒绝
        /// </summary>
        PermissionDeny=101,
        /// <summary>
        /// 登陆账户或密码错误
        /// </summary>
        LoginFailed = 102,
        /// <summary>
        /// 验证码错误
        /// </summary>
        VerificationCodeError = 103,
        /// <summary>
        /// 正常请求
        /// </summary>
        Success =200
    }
}
