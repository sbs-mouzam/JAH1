using BusinessLayer.Interface;
using CommonLayer.CommonModels;
using DataAccessLayer.DataModel;
using DataAccessLayer.GenericPattern.Implementation;
using DataAccessLayer.GenericPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class HalqaBs : IHalqa
    {
        private readonly IGenericPattern<Halqa> _tbl_Halqa;
        private readonly HalqaModel _halqamodel;
        public HalqaBs()
        {
            _tbl_Halqa = new GenericPattern<Halqa>();
            _halqamodel = new HalqaModel();
        }


        public List<HalqaModel> HalqaList()
        {
            List<HalqaModel> _HalqaList = new List<HalqaModel>();
            var HalqaData = _tbl_Halqa.GetAll().ToList();
            _HalqaList = (from item in HalqaData
                          select new HalqaModel
                          {
                              Id = item.Id,
                              Name = item.Name,
                              Ameer = item.Ameer,
                              Nayab = item.Nayab,
                              CreatedDate = item.CreatedDate,
                          }).OrderByDescending(x => x.Id).ToList();
            return _HalqaList;
        }

        public HalqaModel GetDetails(HalqaModel model)
        {
            model = model ?? new HalqaModel();
            if (model.Id != 0)
            {
                model.HalqaLists = HalqaList();

            }
            model.HalqaLists = HalqaList();

            return model;

        }


        public int Save(HalqaModel model)
        {
            Halqa _tbl_halqa = new Halqa(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_Halqa.Update(_tbl_halqa);

            }
            else
            {
                _tbl_halqa.CreatedDate = System.DateTime.Now;
                _tbl_halqa = _tbl_Halqa.Insert(_tbl_halqa);
            }

            return _tbl_halqa.Id;
        }

        public HalqaModel GetById(int id)
        {
            HalqaModel _Halqa = new HalqaModel();
            var HalqabyId = _tbl_Halqa.GetById(id);
            HalqabyId = HalqabyId ?? new Halqa();
            _Halqa = new HalqaModel
            {
                Id = HalqabyId.Id,
                Name = HalqabyId.Name,
                Ameer = HalqabyId.Ameer,
                Nayab = HalqabyId.Nayab,
                CreatedDate = HalqabyId.CreatedDate,
            };
            return _Halqa;
        }
    }
}
