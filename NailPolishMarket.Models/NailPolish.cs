namespace NailPolishMarket.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class NailPolish
    {
        private ICollection<Order> orders { get; set; }

        private ICollection<Catalog> catalogs { get; set; }

        public NailPolish()
        {
            this.orders = new HashSet<Order>();
            this.catalogs = new HashSet<Catalog>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Catalog> Catalogs
        {
            get { return this.catalogs; }
            set { this.catalogs = value; }
        }

        public virtual ICollection<Order> Orders
        {
            get { return this.orders; }
            set { this.orders = value; }
        }
    }
}
