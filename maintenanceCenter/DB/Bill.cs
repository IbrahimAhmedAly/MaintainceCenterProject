//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace maintenanceCenter.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string DeviceName { get; set; }
        public string Problem { get; set; }
        public decimal Paid { get; set; }
        public decimal TheRest { get; set; }
        public string Notes { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int TechnicalId { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> NetProfit { get; set; }
        public Nullable<int> Received { get; set; }
    
        public virtual Technical Technical { get; set; }
        public virtual Technical Technical1 { get; set; }
    }
}
