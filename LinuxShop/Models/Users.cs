using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MongoDB.Bson.Serialization.Attributes;

namespace LinuxShop.Models
{
    [BsonIgnoreExtraElements]
    public partial class Users
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserDspName { get; set; }
        public string Sex { get; set; }
        public System.DateTime BirthDay { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string Activity { get; set; }
        public Nullable<int> UserType { get; set; }
        public string CardId { get; set; }
        public string Style { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime StatusTime { get; set; }
        public string ImgUrl { get; set; }

        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(UserName))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�������Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                errorMessage.Success = false;
                errorMessage.Message = "���벻��Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(UserDspName))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��ʾ�ǳƲ���Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(MobilePhone))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�ֻ����벻��Ϊ��";
            }
            else if (!Regex.Match(MobilePhone, @"^(\d{3,4}-)?\d{6,8}$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�ֻ������ʽ����ȷ";
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Email����Ϊ��";
            }
            else if (!Regex.Match(Email, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "Email��ʽ����ȷ";
            }
            if (string.IsNullOrWhiteSpace(Sex))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�Ա���Ϊ��";
            }
            else if (Sex != "��" && Sex != "Ů")
            {
                errorMessage.Success = false;
                errorMessage.Message = "�Ա����ݲ���ȷ";
            }
            if (string.IsNullOrWhiteSpace(Activity))
            {
                errorMessage.Success = false;
                errorMessage.Message = "����״̬����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(CardId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "����֤���벻��Ϊ��";
            }
            else if (!Regex.Match(CardId, @"^\d{18}$)|(^\d{15}$", RegexOptions.IgnoreCase).Success)
            {
                errorMessage.Success = false;
                errorMessage.Message = "����֤�����ʽ����ȷ";
            }
            return errorMessage;
        }
    }
}