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

        public NewMadarsaOperationsRequestModel GetById(int id)
        {
            NewMadarsaOperationsRequestModel varList = new NewMadarsaOperationsRequestModel();
            var item = tbl_NewMadarsaOperationsRequestModel.GetById(id);
            item = item ?? new NewMadarsaOperationsRequest();
            varList = new NewMadarsaOperationsRequestModel
            {
                Id = item.Id,
                ShortDescription = item.ShortDescription,
                Location = item.Location,
                Area = item.Area,
                ExpectedStudents = item.ExpectedStudents,
                Girls = item.Girls,
                Boys = item.Boys,
                Teachers = item.Teachers,
                IsResidential = item.IsResidential,
                MonthlyConst = item.MonthlyConst,
                CostPerStudent = item.CostPerStudent,
                RevenueSource = item.RevenueSource,
                TotalLandArea = item.TotalLandArea,
                ConstructedArea = item.ConstructedArea,
                IsRented = item.IsRented,
                ChargingStudent = item.ChargingStudent,
                Doc1 = item.Doc1,
                Doc2 = item.Doc2,
                Doc3 = item.Doc3,
                Pic1 = item.Pic1,
                Pic2 = item.Pic2,
                Pic3 = item.Pic3,
                Status = item.Status,
                CreatedDate = item.CreatedDate,
                CreatedBy = item.CreatedBy,

                UserId = item.UserId,
                UserName = (item.User != null) ? item.User.Name : string.Empty,

                MadarsaId = item.MadarsaId,
                MadarsaName = (item.Madarsa != null) ? item.Madarsa.Name : string.Empty,

                RequestTypeId = item.RequestTypeId,
                RequestTypeName = (item.RequestType != null) ? item.RequestType.Name : string.Empty,

                RequestSubmitId = item.RequestSubmitId,
                //  RequestSubmitId
            };
            return varList;
        }

        public List<NewMadarsaOperationsRequestModel> NewMadarsaOperationRequestList()
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
                            Boys = item.Boys,
                            Teachers = item.Teachers,
                            IsResidential = item.IsResidential,
                            MonthlyConst = item.MonthlyConst,
                            CostPerStudent = item.CostPerStudent,
                            RevenueSource = item.RevenueSource,
                            TotalLandArea = item.TotalLandArea,
                            ConstructedArea = item.ConstructedArea,
                            IsRented = item.IsRented,
                            ChargingStudent = item.ChargingStudent,
                            Doc1 = item.Doc1,
                            Doc2 = item.Doc2,
                            Doc3 = item.Doc3,
                            Pic1 = item.Pic1,
                            Pic2 = item.Pic2,
                            Pic3 = item.Pic3,
                            Status = item.Status,
                            CreatedDate = item.CreatedDate,
                            CreatedBy = item.CreatedBy,

                            UserId = item.UserId,
                            UserName = (item.User != null) ? item.User.Name : string.Empty,

                            MadarsaId = item.MadarsaId,
                            MadarsaName = (item.Madarsa != null) ? item.Madarsa.Name : string.Empty,

                            RequestTypeId = item.RequestTypeId,
                            RequestTypeName = (item.RequestType != null) ? item.RequestType.Name : string.Empty,

                            RequestSubmitId = item.RequestSubmitId,
                            //  RequestSubmitId


                        }).OrderByDescending(x => x.Id).ToList();
            return _varList;
        }





        public NewMadarsaOperationsRequestModel GetDetails(NewMadarsaOperationsRequestModel model)
        {
            model = model ?? new NewMadarsaOperationsRequestModel();
            if (model.Id != 0)
            {
                model.NewMadarsaOperationRequestModelList = NewMadarsaOperationRequestList();
                model.UserModelList = UserList();
                model.RequestSubmitModelList = RequestSubmitList();
                model.RequestTypeModelList = RequestTypeList();
            }
            model.NewMadarsaOperationRequestModelList = NewMadarsaOperationRequestList();

            return model;
        }

        public List<MadarsaModel> MadarsaList()
        {
            GenericPattern<Madarsa> _tblList = new GenericPattern<Madarsa>();
            List<MadarsaModel> _ModelList = new List<MadarsaModel>();
            var varData = _tblList.GetAll().ToList();
            _ModelList = (from item in varData
                         select new MadarsaModel
                         {
                             Id = item.Id,
                             Name = item.Name,

                         }).OrderByDescending(x => x.Id).ToList();
            return _ModelList;
        }


        public List<RequestSubmitModel> RequestSubmitList()
        {
            GenericPattern<Interface.RequestSubmit> _tblList = new GenericPattern<Interface.RequestSubmit>();
            List<RequestSubmitModel> _ModelList = new List<RequestSubmitModel>();
            var varData = _tblList.GetAll().ToList();
            _ModelList = (from item in varData
                          select new RequestSubmitModel
                          {
                              //Id = item.Id,
                             // Name = item.Name,

                          }).OrderByDescending(x => x.Id).ToList();
            return _ModelList;
        }

        public List<RequestTypeModel> RequestTypeList()
        {
            GenericPattern<RequestType> _tblList = new GenericPattern<RequestType>();
            List<RequestTypeModel> _ModelList = new List<RequestTypeModel>();
            var varData = _tblList.GetAll().ToList();
            _ModelList = (from item in varData
                          select new RequestTypeModel
                          {
                              Id = item.Id,
                              Name = item.Name,

                          }).OrderByDescending(x => x.Id).ToList();
            return _ModelList;
        }

        public int Save(NewMadarsaOperationsRequestModel model)
        {
            NewMadarsaOperationsRequest _tblList = new NewMadarsaOperationsRequest(model);
            if (_tblList.Id != null && _tblList.Id != 0)
            {
                _tblList.CreatedDate = System.DateTime.Now;
                _tblList.CreatedBy = 1;
                tbl_NewMadarsaOperationsRequestModel.Update(_tblList);
            }
            else
            {
                _tblList.CreatedDate = System.DateTime.Now;
                _tblList.CreatedBy = 1;
                _tblList = tbl_NewMadarsaOperationsRequestModel.Insert(_tblList);
            }


            return _tblList.Id;
        }

        public List<UserModel> UserList()
        {
            GenericPattern<User> _tblList = new GenericPattern<User>();
            List<UserModel> _ModelList = new List<UserModel>();
            var varData = _tblList.GetAll().ToList();
            _ModelList = (from item in varData
                          select new UserModel
                          {
                              Id = item.Id,
                              Name = item.Name,

                          }).OrderByDescending(x => x.Id).ToList();
            return _ModelList;
        }
    }
}

