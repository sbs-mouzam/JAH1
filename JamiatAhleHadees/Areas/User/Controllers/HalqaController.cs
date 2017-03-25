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
    public class HalqaController : Controller
    {
        // GET: User/Halqa
        private HalqaModel res;
        private readonly IHalqa _HalqaBs;

        public HalqaController()
        {
            res = new HalqaModel();
            _HalqaBs = new HalqaBs();
        }
        // GET: Admin/AddHalqa
        public ActionResult Index()
        {
            var res = _HalqaBs.HalqaList();
            return View(res);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var res = _HalqaBs.GetById(Convert.ToInt32(id));

                return View(res);
                //_AddHalqa.AddHalqaList = _AddHalqaBusiness.HalqaList().ToList();
            }
            else
            {
                res.HalqaLists = _HalqaBs.HalqaList().ToList();
                return View(res);

            }

        }
        [HttpPost]
        public ActionResult Create(HalqaModel model)
        {
            if (model != null)
            {
                _HalqaBs.Save(model);
            }
            return RedirectToAction("Index");
        }
        //public ActionResult Details(int id)
        //{
        //    if (id != null && id != 0)
        //    {
        //        _AddHalqa = _AddHalqaBusiness.GetById(id);
        //    }
        //    return View(_AddHalqa);
        //}

    }
}