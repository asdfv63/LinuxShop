using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class Role
    {
        public string RoleId { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime StatusTime { get; set; }
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
                errorMessage.Message = "Id����Ϊ��";
            }
            if (string.IsNullOrEmpty(Description))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��������Ϊ��";
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
