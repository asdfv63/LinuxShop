using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class ScreenResolution
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
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
            if (Id == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "Id不能为空";
            }
            if (string.IsNullOrEmpty(Description))
            {
                errorMessage.Success = false;
                errorMessage.Message = "描述不能为空";
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
