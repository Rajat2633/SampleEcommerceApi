using System;
using System.Collections.Generic;

#nullable disable

namespace SampleEcommerceApi.Models
{
    public partial class Product
    {
        public Product()
        {
            Advertisements = new HashSet<Advertisement>();
            Carts = new HashSet<Cart>();
            Offers = new HashSet<Offer>();
            OrderItems = new HashSet<OrderItem>();
            Questions = new HashSet<Question>();
            Ratings = new HashSet<Rating>();
            WishLists = new HashSet<WishList>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? StorageId { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual Storage Storage { get; set; }
        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
