using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.CommonModels;

namespace DataAccessLayer.DataModel
{
    class PartialClass
    {
    }
    public partial class NewMadarsaOperationsRequest
    {
        public NewMadarsaOperationsRequest()
        {
        }

        public NewMadarsaOperationsRequest(NewMadarsaOperationsRequestModel item)
        {
            Id = item.Id;
            ShortDescription = item.ShortDescription;
            Location = item.Location;
            Area = item.Area;
            ExpectedStudents = item.ExpectedStudents;
            Girls = item.Girls;
            Boys = item.Boys;
            Teachers = item.Teachers;
            IsResidential = item.IsResidential;
            MonthlyConst = item.MonthlyConst;
            CostPerStudent = item.CostPerStudent;
            RevenueSource = item.RevenueSource;
            TotalLandArea = item.TotalLandArea;
            ConstructedArea = item.ConstructedArea;
            IsRented = item.IsRented;
            ChargingStudent = item.ChargingStudent;
            Doc1 = item.Doc1;
            Doc2 = item.Doc2;
            Doc3 = item.Doc3;
            Pic1 = item.Pic1;
            Pic2 = item.Pic2;
            Pic3 = item.Pic3;
            Status = item.Status;
            CreatedDate = item.CreatedDate;
            CreatedBy = item.CreatedBy;

            UserId = item.UserId;


            MadarsaId = item.MadarsaId;

            RequestTypeId = item.RequestTypeId;

            RequestSubmitId = item.RequestSubmitId;
        }
    }
    public partial class ExistingMadarsaOperationsRequest
    {
        public ExistingMadarsaOperationsRequest()
        {

        }
        public ExistingMadarsaOperationsRequest(ExistingMadarsaOperationsRequestModel item)
        {

            Id = item.Id;
            ShortDescription = item.ShortDescription;
            Location = item.Location;
            Area = item.Area;
            ExpectedStudents = item.ExpectedStudents;
            Girls = item.Girls;
            Boys = item.Boys;
            Teachers = item.Teachers;
            IsResidential = item.IsResidential;
            MonthlyConst = item.MonthlyConst;
            CostPerStudent = item.CostPerStudent;
            RevenueSource = item.RevenueSource;
            TotalLandArea = item.TotalLandArea;
            ConstructedArea = item.ConstructedArea;
            IsRented = item.IsRented;
            ChargingStudent = item.ChargingStudent;
            Doc1 = item.Doc1;
            Doc2 = item.Doc2;
            Doc3 = item.Doc3;
            Pic1 = item.Pic1;
            Pic2 = item.Pic2;
            Pic3 = item.Pic3;
            Status = item.Status;
            CreatedDate = item.CreatedDate;
            CreatedBy = item.CreatedBy;

            UserId = item.UserId;


            MadarsaId = item.MadarsaId;

            RequestTypeId = item.RequestTypeId;

            RequestSubmitId = item.RequestSubmitId;
        }

       
    }
    public partial class Madarsa

    {
        public Madarsa(MadarsaModel item)
        {
            Id = item.Id;
            Name = item.Name;
            Location = item.Location;
            Mobile = item.Mobile;
            HeadUserId = item.HeadUserId;
            ZoneId = item.ZoneId;
            CreatedDate = item.CreatedDate;
            CreatedBy = item.CreatedBy;
        }


    }

    public partial class Halqa
    {
        public Halqa()
        {

        }

        public Halqa(HalqaModel _obj)
        {
            Id = _obj.Id;
            Name = _obj.Name;
            Ameer = _obj.Ameer;
            Nayab = _obj.Nayab;
            CreatedDate = _obj.CreatedDate;
        }
    }
    public partial class Masjid
    {
        public Masjid(MasjidModel _obj)
        {
            Id = _obj.Id;
            Name = _obj.Name;
            Location = _obj.Location;
            HeadUserId = _obj.HeadUserId;
            ZoneId = _obj.ZoneId;
            Mobile = _obj.Mobile;
            CreatedDate = _obj.CreatedDate;
            CreatedBy = _obj.CreatedBy;
        }
    }
}
