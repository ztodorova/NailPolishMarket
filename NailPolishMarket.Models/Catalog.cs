namespace NailPolishMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Catalog
    {
        private ICollection<NailPolish> nailPolishes;

        public Catalog()
        {
            this.nailPolishes = new HashSet<NailPolish>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<NailPolish> NailPolishes
        {
            get{ return this.nailPolishes; }
            set{ this.nailPolishes = value;}
        }
    }
}
