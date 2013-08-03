using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication1
{

    [Serializable]
    public class OrderDeliveryPrintState
    {
        public int id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string SalesType { get; set; }
        public string GuestCoding { get; set; }
        public string SalesDepartments { get; set; }
        public string Salesman { get; set; }
        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string ConsigneeTel { get; set; }
        public string ReceivingAddressCoding { get; set; }
        public string AlipayM { get; set; }
        public string AlipayNo { get; set; }
        public string Priority { get; set; }
        public string ShippingMethods { get; set; }
        public string Rate { get; set; }
        public string ReceivingAddress { get; set; }
        public string Remark { get; set; }
        public DateTime PreshipmentDate { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public string JHAudit { get; set; }
        public string JHGiveUp { get; set; }
        public string JHLockUser { get; set; }
        public DateTime dverifydate { get; set; }
        public string GuestName { get; set; }
        public string FlagStatus { get; set; }
        public string PostCard { get; set; }
        public bool Questionnaire { get; set; }
        public string QuestionContent { get; set; }
        public int IsClose { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal Freight { get; set; }
        public int IsPrint { get; set; }
        public int IsOrderUnits { get; set; }
        public decimal TotalPrice { get; set; }
        public string cSCName { get; set; }
        public string cSTName { get; set; }
        public int MergerOrderId { get; set; }
        public string cDCName { get; set; }
        public int ProductCount { get; set; }
        public string cmaker { get; set; }
        public string UserName { get; set; }
        public string DeliveryType { get; set; }
        public string SingleOrder { get; set; }
        public string DeliveryNo { get; set; }
        public int IsFulfil { get; set; }

    }
}