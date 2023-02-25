namespace EntityFrameworkpractice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string price { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }
    }
}
