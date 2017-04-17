using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class RolePermission
    {
        public string RoleId { get; set; }
        public string PermissionId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> StatusTime { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// 字段验证
        /// </summary>
        /// <returns></returns>
        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(RoleId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "角色Id不能为空";
            }
            if (string.IsNullOrEmpty(PermissionId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "权限ID不能为空";
            }
            if (string.IsNullOrEmpty(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            if (string.IsNullOrEmpty(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            return errorMessage;
        }

    }
}
