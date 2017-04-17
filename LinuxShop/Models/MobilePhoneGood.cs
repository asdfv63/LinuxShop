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
            if (string.IsNullOrWhiteSpace(Name))
            {
                errorMessage.Success = false;
                errorMessage.Message = "商品名称不能为空";
            }
            if (string.IsNullOrWhiteSpace(UserId))
            {
                errorMessage.Success = false;
                errorMessage.Message = "用户ID不能为空";
            }
            if (string.IsNullOrWhiteSpace(Status))
            {
                errorMessage.Success = false;
                errorMessage.Message = "状态不能为空";
            }
            if (Price == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "价格不能为0";
            }
            if (BrandType == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "品牌类型不能为空";
            }
            if (Color == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "颜色不能为空";
            }
            if (System == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "操作系统不能为空";
            }
            if (ScreenResolution == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "分辨率不能为空";
            }
            if (Memory == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "内存不能为空";
            }
            if (PhoneModel == 0)
            {
                errorMessage.Success = false;
                errorMessage.Message = "手机型号不能为空";
            }
            return errorMessage;
        }
    }
}
