namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExistingMadarsaOperationsRequest")]
    public partial class ExistingMadarsaOperationsRequest
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
        public string Girls { get; set; }

        [StringLength(50)]
        public string Boys { get; set; }

        [StringLength(50)]
        public string Teachers { get; set; }

        public bool? IsResidential { get; set; }

        public decimal? MonthlyConst { get; set; }

        [StringLength(100)]
        public string CostPerStudent { get; set; }

        [StringLength(100)]
        public string RevenueSource { get; set; }

        [StringLength(100)]
        public string TotalLandArea { get; set; }

        [StringLength(100)]
        public string ConstructedArea { get; set; }

        [StringLength(100)]
        public string IsRented { get; set; }

        public bool? ChargingStudent { get; set; }

        [StringLength(100)]
        public string IfChargingHowmuch { get; set; }

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

        public int? RequestType { get; set; }

        public virtual Madarsa Madarsa { get; set; }

        public virtual RequestSubmit RequestSubmit { get; set; }

        public virtual RequestType RequestType1 { get; set; }

        public virtual User User { get; set; }
    }
}
