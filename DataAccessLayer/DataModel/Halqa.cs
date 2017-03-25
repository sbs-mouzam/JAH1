namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Halqa")]
    public partial class Halqa
    {
        public Halqa()
        {

        }
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Ameer { get; set; }

        public int? Nayab { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
    }
}
