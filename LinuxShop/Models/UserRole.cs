using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class UserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> StatusTime { get; set; }
        public string CreateUsereId { get; set; }
        public string Status { get; set; }

        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            if (string.IsNullOrWhiteSpace(RoleId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "角色ID不能为空";
            }
            if (string.IsNullOrWhiteSpace(CreateUsereId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "创建人ID不能为空";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            return errorMessage;
        }
    }
}
