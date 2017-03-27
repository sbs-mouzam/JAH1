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
    public class MadarsaExtensionRequestBs : IMadarsaExtenstionRequest
    {
        private readonly IGenericPattern<MadarsaExtensionRequest> tbl_MadarsaExtensionRequest;
        public MadarsaExtensionRequestBs()
        {
            tbl_MadarsaExtensionRequest = new GenericPattern<MadarsaExtensionRequest>();
        }


        public List<MadarsaExtensionRequestModel> MadarsaExtensionRequestList()
        {
            List<MadarsaExtensionRequestModel> _varList = new List<MadarsaExtensionRequestModel>();
            var varData = tbl_MadarsaExtensionRequest.GetAll().ToList();
            _varList = (from item in varData
                        select new MadarsaExtensionRequestModel
                        {
                            Id = item.Id,
                            ShortDescription = item.ShortDescription,
                            Location = item.Location,
                            Area = item.Area,
                            ConstructionCost = item.ConstructionCost,
                            ExistingFloors = item.ExistingFloors,
                            AmountNeeded = item.AmountNeeded,
                            Engineer = item.Engineer,
                            Elevation = item.Elevation,
                            Paln = item.Paln,

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

        public MadarsaExtensionRequestModel GetById(int id)
        {
            MadarsaExtensionRequestModel varList = new MadarsaExtensionRequestModel();
            var item = tbl_MadarsaExtensionRequest.GetById(id);
            item = item ?? new MadarsaExtensionRequest();
            varList = new MadarsaExtensionRequestModel
            {

                Id = item.Id,
                ShortDescription = item.ShortDescription,
                Location = item.Location,
                Area = item.Area,
                ConstructionCost = item.ConstructionCost,
                ExistingFloors = item.ExistingFloors,
                AmountNeeded = item.AmountNeeded,
                Engineer = item.Engineer,
                Elevation = item.Elevation,
                Paln = item.Paln,

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

        public MadarsaExtensionRequestModel GetDetails(MadarsaExtensionRequestModel model)
        {
            model = model ?? new MadarsaExtensionRequestModel();
            if (model.Id != 0)
            {
                model.MadarsaExtensionRequestModelList = MadarsaExtensionRequestList();
                model.UserModelList = UserList();
                model.RequestSubmitModelList = RequestSubmitList();
                model.RequestTypeModelList = RequestTypeList();
            }
            model.MadarsaExtensionRequestModelList = MadarsaExtensionRequestList();

            return model;
        }

        public int Save(MadarsaExtensionRequestModel model)
        {
            MadarsaExtensionRequest _tblList = new MadarsaExtensionRequest(model);
            if (_tblList.Id != null && _tblList.Id != 0)
            {
                _tblList.CreatedDate = System.DateTime.Now;
                _tblList.CreatedBy = 1;
                tbl_MadarsaExtensionRequest.Update(_tblList);
            }
            else
            {
                _tblList.CreatedDate = System.DateTime.Now;
                _tblList.CreatedBy = 1;
                _tblList = tbl_MadarsaExtensionRequest.Insert(_tblList);
            }


            return _tblList.Id;
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
