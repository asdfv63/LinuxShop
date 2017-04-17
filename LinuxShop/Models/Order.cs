using System;
using System.Collections.Generic;

namespace LinuxShop.Models
{
    public partial class Order
    {
        public string OrderNumber { get; set; }
        public string UserId { get; set; }
        public int GoodsCount { get; set; }
        public decimal GoodsTotalPrice { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime StatusTime { get; set; }
        public string Status { get; set; }

        public ErrorMessage Required()
        {
            ErrorMessage errorMessage = new ErrorMessage();
            if (string.IsNullOrWhiteSpace(OrderNumber))
            {
                errorMessage.Success = false;
                errorMessage.Message = "订单不能为空";
            }
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户Id不能为空";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            if (GoodsCount == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "商品数量不能为0";
            }
            if (GoodsTotalPrice == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "商品总价不能为0";
            }
            return errorMessage;
        }
    }
}
