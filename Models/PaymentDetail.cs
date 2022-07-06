using System;
using System.Collections.Generic;

#nullable disable

namespace SampleEcommerceApi.Models
{
    public partial class PaymentDetail
    {
        public long PaymentId { get; set; }
        public long OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Provider { get; set; }
        public bool PaymentStatus { get; set; }
        public bool IsPending { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Reason { get; set; }

        public virtual Order Order { get; set; }
    }
}
