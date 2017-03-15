using BootstrapJqueryValidate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapJqueryValidate.Controllers
{
    public class DemoController : Controller
    {
        private DemoEntities db = new DemoEntities();

        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddExplanation()
        {
            return PartialView();
        }

        public ActionResult GetList()
        {
            DemoViewModels demoVMs = new DemoViewModels();
            demoVMs.GetList = new List<DemoModel>();
            foreach(var item in db.Demo.ToList())
            {
                demoVMs.GetList.Add( new DemoModel
                {
                    RecId = item.Id.ToString(),
                    Title = item.Title,
                    Content = item.Content,
                    CreateUser = item.CreateUser,
                    CreateDate = item.CreateDateTime,
                    EditUser = String.IsNullOrEmpty(item.EditUser) ? String.Empty : item.EditUser,
                    EditDate = item.EditDateTime
                });
            }

            return PartialView(demoVMs);
        }

        [HttpPost]
        public JsonResult Add(DemoModel data)
        {
            try
            {
                db.Demo.Add(new Demo
                {
                    Id = Guid.NewGuid(),
                    Title = data.Title,
                    Content = data.Content,
                    CreateUser = data.CreateUser,
                    CreateDateTime = DateTime.Now,
                    EditUser = data.CreateUser
                });

                db.SaveChanges();
                return Json("");
            }
            catch(Exception ex)
            {
                return Json("fail");
            }
        }
    }
}