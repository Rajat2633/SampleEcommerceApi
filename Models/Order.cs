using System;
using System.Collections.Generic;

#nullable disable

namespace SampleEcommerceApi.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            PaymentDetails = new HashSet<PaymentDetail>();
        }

        public long OrderId { get; set; }
        public int UserId { get; set; }
        public int DistinctItems { get; set; }
        public decimal TotalAmount { get; set; }
        public long PaymentId { get; set; }
        public int? OfferId { get; set; }
        public DateTime OrderedOn { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderStatus { get; set; }

        public virtual Offer Offer { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
