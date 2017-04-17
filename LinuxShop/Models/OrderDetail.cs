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
                errorMessage.Message = "Id不能为空";
            }
            if (string.IsNullOrWhiteSpace(OrderNumber))
            {
                errorMessage.Success = false;
                errorMessage.Message = "订单不能为空";
            }
            if (string.IsNullOrWhiteSpace(GoodsId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "商品ID不能为空";
            }
            if (string.IsNullOrWhiteSpace(GoodsName))
            {
                errorMessage.Success = false;
                errorMessage.Message = "商品名称不能为空";
            }
            if (Price == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "价格不能为0";
            }
            if (string.IsNullOrWhiteSpace(LogisticsNumber))
            {
                errorMessage.Success = false;
                errorMessage.Message = "物流单号不能为空";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            return errorMessage;
        }
    }
}
