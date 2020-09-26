namespace v2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kinderInfoSet")]
    public partial class kinderInfoSet
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [StringLength(4)]
        public string PostCode { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Location { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
