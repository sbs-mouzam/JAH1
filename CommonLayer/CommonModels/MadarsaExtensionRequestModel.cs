using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
   public class MadarsaExtensionRequestModel
    {
        public int Id { get; set; }

       
        public string ShortDescription { get; set; }

        public int? UserId { get; set; }

      
        public string Location { get; set; }

       
        public string Area { get; set; }

        public int? MadarsaId { get; set; }

       
        public string ConstructionCost { get; set; }

      
        public string ExistingFloors { get; set; }

        public decimal? AmountNeeded { get; set; }

       
        public string Engineer { get; set; }

        
        public string Elevation { get; set; }

        
        public string Paln { get; set; }

       
        public string Doc1 { get; set; }

       
        public string Doc2 { get; set; }

      
        public string Doc3 { get; set; }

       
        public string Pic1 { get; set; }

       
        public string Pic2 { get; set; }

       
        public string Pic3 { get; set; }

        public int? RequestSubmitId { get; set; }

        public bool? Status { get; set; }

     
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? RequestTypeId { get; set; }

        public string UserName { get; set; }
        public string MadarsaName { get; set; }
        public string RequestTypeName { get; set; }

        public List<MadarsaExtensionRequestModel> MadarsaExtensionRequestModelList { get; set; }

        public List<MadarsaModel> MadarsaModelList { get; set; }

        public List<RequestSubmitModel> RequestSubmitModelList { get; set; }

        public List<RequestTypeModel> RequestTypeModelList { get; set; }

        public List<UserModel> UserModelList { get; set; }
    }
}
