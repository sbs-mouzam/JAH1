namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MadarsaExtensionRequest")]
    public partial class MadarsaExtensionRequest
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string ShortDescription { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        public int? MadarsaId { get; set; }

        [StringLength(50)]
        public string ConstructionCost { get; set; }

        [StringLength(50)]
        public string ExistingFloors { get; set; }

        public decimal? AmountNeeded { get; set; }

        [StringLength(50)]
        public string Engineer { get; set; }

        [StringLength(50)]
        public string Elevation { get; set; }

        [StringLength(50)]
        public string Paln { get; set; }

        [StringLength(100)]
        public string Doc1 { get; set; }

        [StringLength(100)]
        public string Doc2 { get; set; }

        [StringLength(100)]
        public string Doc3 { get; set; }

        [StringLength(100)]
        public string Pic1 { get; set; }

        [StringLength(100)]
        public string Pic2 { get; set; }

        [StringLength(100)]
        public string Pic3 { get; set; }

        public int? RequestSubmitId { get; set; }

        public bool? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public int? RequestTypeId { get; set; }

        public virtual Madarsa Madarsa { get; set; }

        public virtual RequestSubmit RequestSubmit { get; set; }

        public virtual RequestType RequestType { get; set; }

        public virtual User User { get; set; }
    }
}
