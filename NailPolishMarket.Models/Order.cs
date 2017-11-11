namespace NailPolishMarket.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Order
    {
        private ICollection<NailPolish> nailPolishes;

        public Order()
        {
            this.nailPolishes = new HashSet<NailPolish>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<NailPolish> NailPolishes
        {
            get { return this.nailPolishes; }
            set { this.nailPolishes = value; }
        }
    }
}
