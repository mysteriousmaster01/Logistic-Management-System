namespace Logister.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("export")]
    public partial class export
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public int Pincode { get; set; }

        [Column("Transport Via")]
        [Required]
        [StringLength(50)]
        public string Transport_Via { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity { get; set; }
    }
}
