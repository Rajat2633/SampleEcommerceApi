using System;
using System.Collections.Generic;

#nullable disable

namespace SampleEcommerceApi.Models
{
    public partial class Storage
    {
        public Storage()
        {
            Products = new HashSet<Product>();
        }

        public int StorageId { get; set; }
        public string StorageName { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
