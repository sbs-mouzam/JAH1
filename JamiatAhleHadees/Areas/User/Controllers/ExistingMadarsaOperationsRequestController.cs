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
    public class ExistingMadarsaOperationsRequestController : Controller
    {

        private ExistingMadarsaOperationsRequestModel _ExistingMadarsaModel;
        private readonly IExistingMadarsaOperationsRequest _ExistingMadarsaOperationsRequestModelBs;

        public ExistingMadarsaOperationsRequestController()
        {
            _ExistingMadarsaModel = new ExistingMadarsaOperationsRequestModel();
            _ExistingMadarsaOperationsRequestModelBs = new ExistingMadarsaOperationsRequestBs();
        }

        public ActionResult Index()
        {
            var varial = _ExistingMadarsaOperationsRequestModelBs.ExistingMadarsaOperationRequestList();
            return View(varial);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {



                var _MadarsaModel = _ExistingMadarsaOperationsRequestModelBs.GetById(Convert.ToInt32(id));
                ViewBag.HeadUserId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.RequestTypeList().ToList(), "Id", "Name");
                return View(_MadarsaModel);

            }
            else
            {
                ViewBag.HeadUserId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new SelectList(_ExistingMadarsaOperationsRequestModelBs.RequestTypeList().ToList(), "Id", "Name");
                _ExistingMadarsaModel.ExistingMadarsaOperationRequestModelList = _ExistingMadarsaOperationsRequestModelBs.ExistingMadarsaOperationRequestList().ToList();



                return View(_ExistingMadarsaModel);

            }



        }
        [HttpPost]
        public ActionResult Create(ExistingMadarsaOperationsRequestModel model)
        {
            if (model != null)
            {
                _ExistingMadarsaOperationsRequestModelBs.Save(model);
            }
            return RedirectToAction("Index");
        }
    }
}