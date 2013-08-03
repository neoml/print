using System;
using System.Collections.Generic;

using System.Text;

namespace WindowsFormsApplication2
{
    [Serializable]
    public class OrderDetailDeliveryPrint
    {
      public int id {get;set;}
      public int MergerOrderId {get;set;}
      public string tid {get;set;}
      public string tid2 {get;set;}
      public string Stockcode {get;set;}
      public string StockName {get;set;}
      public int Amount {get;set;}
      public decimal Price {get;set;}
      public string Discountamount {get;set;}
      public string Color {get;set;}
      public string Size {get;set;}
      public string Remark {get;set;}
      public string BussinessType {get;set;}
      public string Buyer_nick {get;set;}
      public string Seller_nick {get;set;}
      public string ERPOrderNo {get;set;}
      public int IsClose {get;set;}
      public bool IsChange {get;set;}
      public int ActualDelivery {get;set;}
      public int DeliveryNum {get;set;}
      public string cPoscode {get;set;}
      public int InvCheck {get;set;}
      public string OrderNo {get;set;}
      public string UserName {get;set;}
      public string DeliveryType {get;set;}
      public string SingleOrder {get;set;}
      public string DeliveryNo {get;set;}
      public int IsFulfil {get;set;}
    }
}
