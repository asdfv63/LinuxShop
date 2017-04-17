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
            if (string.IsNullOrEmpty(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            if (string.IsNullOrEmpty(GoodsId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            if (string.IsNullOrEmpty(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            if (GoodsCount ==0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "物品数量不能为0";
            }
            if (GoodsTotalPrice == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "价格不能为0";
            }
            return errorMessage;
        }
    }
}
