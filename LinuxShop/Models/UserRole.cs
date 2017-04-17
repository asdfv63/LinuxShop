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
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(RoleId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��ɫID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(CreateUsereId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "������ID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "״̬����Ϊ��";
            }
            return errorMessage;
        }
    }
}
