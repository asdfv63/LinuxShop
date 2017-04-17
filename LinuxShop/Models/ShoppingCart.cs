using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class ShoppingCart
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string GoodsId { get; set; }
        public int GoodsCount { get; set; }
        public decimal GoodsTotalPrice { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime StatusTime { get; set; }
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
            if (string.IsNullOrEmpty(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrEmpty(GoodsId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�û�ID����Ϊ��";
            }
            if (string.IsNullOrEmpty(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "״̬����Ϊ��";
            }
            if (GoodsCount ==0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "��Ʒ��������Ϊ0";
            }
            if (GoodsTotalPrice == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�۸���Ϊ0";
            }
            return errorMessage;
        }
    }
}
