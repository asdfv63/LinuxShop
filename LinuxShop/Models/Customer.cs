using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinuxShop.Models
{
    public partial class Customer
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserDspName { get; set; }
        public string Sex { get; set; }
        public System.DateTime BirthDay { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Activity { get; set; }
        public int UserType { get; set; }
        public string CardId { get; set; }
        public string Style { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime StatusTime { get; set; }
        public string UserId { get; set; }

        /// <summary>
        /// 字段验证
        /// </summary>
        /// <returns></returns>
        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(Id))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Id不能为空";
            }
            if (string.IsNullOrWhiteSpace(UserName))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户名不能为空";
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                errorMessage.Success = false;
                errorMessage.Message = "密码不能为空";
            }
            if (string.IsNullOrWhiteSpace(MobilePhone))
            {
                errorMessage.Success = false;
                errorMessage.Message = "手机号码不能为空";
            }
            else if (!Regex.Match(MobilePhone, @"^(\d{3,4}-)?\d{6,8}$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "手机号码格式不正确";
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Email不能为空";
            }
            else if(!Regex.Match(Email, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "Email格式不正确";
            }
            if (string.IsNullOrWhiteSpace(Sex))
            {
                errorMessage.Success = false;
                errorMessage.Message = "性别不能为空";
            }
            else if (Sex != "男" && Sex != "女")
            {
                errorMessage.Success = false;
                errorMessage.Message = "性别内容不正确";
            }
            if (string.IsNullOrWhiteSpace(Activity))
            {
                errorMessage.Success = false;
                errorMessage.Message = "激活状态不能为空";
            }
            if (string.IsNullOrWhiteSpace(CardId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "身份证号码不能为空";
            }
            else if (!Regex.Match(CardId, @"^\d{18}$)|(^\d{15}$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "身份证号码格式不正确";
            }
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            return errorMessage;
        }
    }
}
