using BusinessLayer.Implementation;
using BusinessLayer.Interface;
using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhleHadees.Areas.User.Controllers
{
    public class NewMadarsaOperationRequestController : Controller
    {
        private NewMadarsaOperationsRequestModel _NewMadarsaOperationsRequestModel;
        private readonly INewMadarsaOperationsRequest _NewMadarsaOperationsRequestModelBs;

        public NewMadarsaOperationRequestController()
        {
            _NewMadarsaOperationsRequestModel = new NewMadarsaOperationsRequestModel();
            _NewMadarsaOperationsRequestModelBs = new NewMadarsaOperationsRequestBs();
        }

        public ActionResult Index()
        {
            var varial = _NewMadarsaOperationsRequestModelBs.NewMadarsaOperationRequestList();
            return View(varial);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {



                var varData = _NewMadarsaOperationsRequestModelBs.GetById(Convert.ToInt32(id));
                ViewBag.HeadUserId = new SelectList(_NewMadarsaOperationsRequestModelBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_NewMadarsaOperationsRequestModelBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new MultiSelectList(_NewMadarsaOperationsRequestModelBs.RequestTypeList().ToList(), "Id", "Name");
                return View(varData);

            }
            else
            {
                ViewBag.HeadUserId = new SelectList(_NewMadarsaOperationsRequestModelBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_NewMadarsaOperationsRequestModelBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new MultiSelectList(_NewMadarsaOperationsRequestModelBs.RequestTypeList().ToList(), "Id", "Name");
                _NewMadarsaOperationsRequestModel.NewMadarsaOperationRequestModelList = _NewMadarsaOperationsRequestModelBs.NewMadarsaOperationRequestList().ToList();



                return View(_NewMadarsaOperationsRequestModel);

            }



        }
        [HttpPost]
        public ActionResult Create(NewMadarsaOperationsRequestModel model)
        {
            if (model != null)
            {
                _NewMadarsaOperationsRequestModelBs.Save(model);
            }
            return RedirectToAction("Index");
        }

    }
}