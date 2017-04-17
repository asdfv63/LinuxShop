using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class MobilePhoneGood
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int BrandType { get; set; }
        public int Color { get; set; }
        public int System { get; set; }
        public int ScreenResolution { get; set; }
        public int Memory { get; set; }
        public int PhoneModel { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> StatusTime { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// �ֶ���֤
        /// </summary>
        /// <returns></returns>
        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(Id))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Id����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(Name))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��Ʒ���Ʋ���Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "״̬����Ϊ��";
            }
            if (Price == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�۸���Ϊ0";
            }
            if (BrandType == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "Ʒ�����Ͳ���Ϊ��";
            }
            if (Color == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "��ɫ����Ϊ��";
            }
            if (System == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "����ϵͳ����Ϊ��";
            }
            if (ScreenResolution == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�ֱ��ʲ���Ϊ��";
            }
            if (Memory == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�ڴ治��Ϊ��";
            }
            if (PhoneModel == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�ֻ��ͺŲ���Ϊ��";
            }
            return errorMessage;
        }
    }
}
