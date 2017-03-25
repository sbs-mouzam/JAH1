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
    public class MasjidController : Controller
    {
        // GET: User/Masjid
        private MasjidModel res;
        private readonly IMasjid _MasjidBs;
        public MasjidController()
        {
            res = new MasjidModel();
            _MasjidBs = new MasjidBs();
        }
        // GET: Admin/AddMasjid
        public ActionResult Index()
        {
            var res = _MasjidBs.MasjidList();
            return View(res);
        }


        public ActionResult Create(int? id)

        {
            if (id != null)
            {
                var res = _MasjidBs.GetById(Convert.ToInt32(id));
               
                return View(res);
            }
            else
            {
                res.MasjidLists = _MasjidBs.MasjidList().ToList();
                res.UserLists = _MasjidBs.UserList().ToList();
               // ViewBag.HeadUserId = _MasjidBs.UserList().ToList();
                ViewBag.HeadUserId = new SelectList(_MasjidBs.UserList().ToList(), "Id", "Name");
                return View(res);

            }

        }
        [HttpPost]
        public ActionResult Create(MasjidModel model)
        {
            if (model != null)
            {
                _MasjidBs.Save(model);
            }
            return RedirectToAction("Index");
        }

    }
}