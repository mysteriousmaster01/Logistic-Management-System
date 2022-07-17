namespace Logister.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("import")]
    public partial class import
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string Sender { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Column("Transport Via")]
        [Required]
        [StringLength(50)]
        public string Transport_Via { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity { get; set; }
    }
}
