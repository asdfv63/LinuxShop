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
        /// �ֶ���֤
        /// </summary>
        /// <returns></returns>
        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(RoleId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��ɫId����Ϊ��";
            }
            if (string.IsNullOrEmpty(PermissionId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Ȩ��ID����Ϊ��";
            }
            if (string.IsNullOrEmpty(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrEmpty(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "״̬����Ϊ��";
            }
            return errorMessage;
        }

    }
}
