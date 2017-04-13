using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public string Buyer { get; set; }
        public int SellerId { get; set; }
        public string Seller { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string Shipping { get; set; }
        public int SalesPersonId { get; set; }
        public string SalesPerson { get; set; }
        public decimal TotalCharges{get; set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
    }
}