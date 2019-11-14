using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";    //儲存字串
            ViewData["Age"] = 33;    //儲存整數
            ViewData["Single"] = true;     //儲存布林值

            return View();
        }
        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            // ViewBag ViewData不可以重名，key不分大小寫 (ex : Nickname)
            ViewData["nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;

            return View();
        }
        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路100號";
            // Model資料模型
            List<string> petsList = new List<string>();
            petsList.Add("狗");
            petsList.Add("貓");
            petsList.Add("魚");
            petsList.Add("鼠");
            petsList.Add("變色龍");

            ViewData.Model = petsList;
            return View();
            // return View(petsList);
        }
        public ActionResult PasstempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請聯絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }

        //public ActionResult PassViewModel()
        //{
    
        //    return RedirectToAction("ErrorMessage", "ErrorHandler");
        //}
    }
}