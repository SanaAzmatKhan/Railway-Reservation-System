using Railway_Reservation_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Railway_Reservation_System.Controllers
{
    public class RRSController : Controller
    {
        // GET: RRS

        private DB_RRS_Context db = new DB_RRS_Context();


        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getData(string city)
        {
            //List<Route_Detail> listss = db.Route_Details.Where(m => m.Route_from == city).ToList();
            return Json(db.Route_Details.ToList().Where(m => m.Route_from == city).Select(r => r.Route_To.ToString()).ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult getTrain() {
            
            return Json(db.Train_Infoes.Select(m => new {Train_no= m.Train_no ,Train_name = m.Train_name}).ToList(), JsonRequestBehavior.AllowGet);
        }

       /* public JsonResult searchTrain() {
       return Json(db.Train_Infoes.Select(m => new { }));
       }
      */ 

        public JsonResult checkfair(string from, string to)
        {

            decimal num = db.Route_Details.ToList().Where(m => m.Route_from == from && m.Route_To == to).Select(m => m.Route_ID).FirstOrDefault();

            List<Train_Route> routes = db.Train_Routes.Where(m => m.Route_ID == num).ToList();
            
            return Json(routes.Select(m => m.Train_Info.Train_name), JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Form() {
            ViewBag.Train_no = new SelectList(db.Train_Infoes.ToList(), "Train_no", "Train_name");


            return PartialView("_form");
        }
        public ActionResult LoginPartial()
        {
            return PartialView("_LoginPartial");
        }

        public ActionResult eTicket()
        {
            return View();
        }
        public ActionResult checkRoute()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
       
        public ActionResult Train_timing()
        {

            return View();
        }
        public ActionResult ContactUs()
        {

            return View();
        }

        public ActionResult fare()
        {
           

            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult FeedBack()
        {
            return View();
        }
        
        public ActionResult terms_condition()
        {
            return View();
        }

        public ActionResult aboutUs()
        {
            return View();
        }

       
    }
}