using BusinessLayer.Interface;
using BusinessLogic.Implementation;
using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhleHadees.Areas.User.Controllers
{
    public class MadarsaController : Controller
    {
        private MadarsaModel _MadarsaModel;
        private readonly IMadarsa _MadarsaBs;

        public MadarsaController()
        {
            _MadarsaModel = new MadarsaModel();
            _MadarsaBs = new MadarsaBs();
        }
        public ActionResult Index()
        {
            var varial = _MadarsaBs.MadarsaList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {

                //_MadarsaModel.UserList = _MadarsaBs.UserList().ToList();

                var _MadarsaModel = _MadarsaBs.GetById(Convert.ToInt32(id));
                ViewBag.HeadUserId = new SelectList(_MadarsaBs.UserList().ToList(), "Id", "Name");
                ViewBag.ZoneId = new SelectList(_MadarsaBs.ZoneList().ToList(), "Id", "Name");
                return View(_MadarsaModel);

            }
            else
            {
                ViewBag.HeadUserId = new SelectList(_MadarsaBs.UserList().ToList(), "Id", "Name");
                ViewBag.ZoneId = new SelectList(_MadarsaBs.ZoneList().ToList(), "Id", "Name");
                _MadarsaModel.MadarsaList = _MadarsaBs.MadarsaList().ToList();

                return View(_MadarsaModel);

            }



        }
        [HttpPost]
        public ActionResult Create(MadarsaModel model)
        {
            if (model != null)
            {
                _MadarsaBs.Save(model);
            }
            return RedirectToAction("Index");
        }
    }
}