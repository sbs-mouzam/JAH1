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
    public class MadarsaExtenstionRequestController : Controller
    {
        private MadarsaExtensionRequestModel _MadarsaExtensionRequestModel;
        private readonly IMadarsaExtenstionRequest _MadarsaExtensionRequestBs;
        public MadarsaExtenstionRequestController()
        {
            _MadarsaExtensionRequestModel = new MadarsaExtensionRequestModel();
            _MadarsaExtensionRequestBs = new MadarsaExtensionRequestBs();
        }
        public ActionResult Index()
        {
            var varial = _MadarsaExtensionRequestBs.MadarsaExtensionRequestList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {



                var _MadarsaModel = _MadarsaExtensionRequestBs.GetById(Convert.ToInt32(id));
                ViewBag.HeadUserId = new SelectList(_MadarsaExtensionRequestBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_MadarsaExtensionRequestBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new SelectList(_MadarsaExtensionRequestBs.RequestTypeList().ToList(), "Id", "Name");
                return View(_MadarsaModel);

            }
            else
            {
                ViewBag.HeadUserId = new SelectList(_MadarsaExtensionRequestBs.UserList().ToList(), "Id", "Name");
                ViewBag.MadarsaId = new SelectList(_MadarsaExtensionRequestBs.MadarsaList().ToList(), "Id", "Name");
                ViewBag.RequestTypeId = new SelectList(_MadarsaExtensionRequestBs.RequestTypeList().ToList(), "Id", "Name");
                _MadarsaExtensionRequestModel.MadarsaExtensionRequestModelList = _MadarsaExtensionRequestBs.MadarsaExtensionRequestList().ToList();



                return View(_MadarsaExtensionRequestModel);

            }



        }
        [HttpPost]
        public ActionResult Create(MadarsaExtensionRequestModel model)
        {
            if (model != null)
            {
                _MadarsaExtensionRequestBs.Save(model);
            }
            return RedirectToAction("Index");
        }
    }
}