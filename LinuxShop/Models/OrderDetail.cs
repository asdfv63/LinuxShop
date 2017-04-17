using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public string OrderNumber { get; set; }
        public string GoodsId { get; set; }
        public string GoodsName { get; set; }
        public decimal Price { get; set; }
        public decimal LogisticsPrice { get; set; }
        public string LogisticsNumber { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> StatusTime { get; set; }
        public string Status { get; set; }

        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(Id))
            {
                errorMessage.Success = false;
                errorMessage.Message = "Id����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(OrderNumber))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��������Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(GoodsId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��ƷID����Ϊ��";
            }
            if (string.IsNullOrWhiteSpace(GoodsName))
            {
                errorMessage.Success = false;
                errorMessage.Message = "��Ʒ���Ʋ���Ϊ��";
            }
            if (Price == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "�۸���Ϊ0";
            }
            if (string.IsNullOrWhiteSpace(LogisticsNumber))
            {
                errorMessage.Success = false;
                errorMessage.Message = "�������Ų���Ϊ��";
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
