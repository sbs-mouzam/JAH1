using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.CommonModels;
using DataAccessLayer.DataModel;
using DataAccessLayer.GenericPattern.Interface;
using DataAccessLayer.GenericPattern.Implementation;

namespace BusinessLayer.Implementation
{
    public class NewMadarsaOperationsRequestBs : INewMadarsaOperationsRequest
    {
        private readonly IGenericPattern<NewMadarsaOperationsRequest> tbl_NewMadarsaOperationsRequestModel;
        public NewMadarsaOperationsRequestBs()
        {
            tbl_NewMadarsaOperationsRequestModel = new GenericPattern<NewMadarsaOperationsRequest>();
        }

        public List<NewMadarsaOperationsRequestModel> NewMadarsaOperationRequestLists()
        {
            List<NewMadarsaOperationsRequestModel> _varList = new List<NewMadarsaOperationsRequestModel>();
            var varData = tbl_NewMadarsaOperationsRequestModel.GetAll().ToList();
            _varList = (from item in varData
                        select new NewMadarsaOperationsRequestModel
                        {
                            Id = item.Id,
                            ShortDescription = item.ShortDescription,
                            Location = item.Location,
                            Area = item.Area,
                            ExpectedStudents = item.ExpectedStudents,
                            Girls = item.Girls,
                            Boys=item.Boys,
                            Teachers=item.Teachers,
                            IsResidential=item.IsResidential,
                            MonthlyConst=item.MonthlyConst,
                            CostPerStudent=item.CostPerStudent,
                            RevenueSource=item.RevenueSource,
                            TotalLandArea=item.TotalLandArea,
                            ConstructedArea=item.ConstructedArea,
                            IsRented=item.IsRented,
                            ChargingStudent=item.ChargingStudent,
                            Doc1=item.Doc1,
                            Doc2=item.Doc2,
                            Doc3=item.Doc3,
                            Pic1=item.Pic1,
                            Pic2=item.Pic2,
                            Pic3=item.Pic3,
                            Status=item.Status,
                            UserId=item.UserId,
                            UserName = (item.User != null) ? item.User.Name : string.Empty,
                           // RequestSubmitId = (item.RequestSubmit != null) ? item.RequestSubmit. : string.Empty,
                            ////ZoneName = (item.Zone != null) ? item.Zone.Name : string.Empty,
                            ////ZoneName = (item.Zone != null) ? item.Zone.Name : string.Empty,
                            ////ZoneName = (item.Zone != null) ? item.Zone.Name : string.Empty,


                        }).OrderByDescending(x => x.Id).ToList();
            return _varList;
        }

        public List<RequestSubmitModel> RequestSubmitLists()
        {
            throw new NotImplementedException();
        }

        public List<RequestTypeModel> RequestTypeLists()
        {
            throw new NotImplementedException();
        }

        public List<UserModel> UserLists()
        {
            throw new NotImplementedException();
        }

        public List<MadarsaModel> MadarsaLists()
        {
            throw new NotImplementedException();
        }


        public NewMadarsaOperationsRequestModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public NewMadarsaOperationsRequestModel GetDetails(NewMadarsaOperationsRequestModel model)
        {
            throw new NotImplementedException();
        }

        public int Save(NewMadarsaOperationsRequestModel model)
        {
            throw new NotImplementedException();
        }

    }
}
