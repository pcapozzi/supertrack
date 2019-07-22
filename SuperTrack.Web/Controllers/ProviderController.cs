using SuperTrack.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SuperTrack.Web.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Index()
        {
            ViewBag.Message = "";
            if (TempData.ContainsKey("message"))
                ViewBag.Message = TempData["message"].ToString();

            //location selected dropdown
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem
            {
                Text = "- Select One -",
                Value = "0",
                Selected = true
            });

            items.Add(new SelectListItem
            { Text = "Lakeway Drive, Bellingham, WA", Value = "1" });

            items.Add(new SelectListItem
            { Text = "36th Street, Bellingham, WA", Value = "2" });

            items.Add(new SelectListItem
            { Text = "Point Roberts, Point Roberts, WA", Value = "3" });      

            ViewBag.SelectLocation = items;

            //doctor selected dorpdown
            List<SelectListItem> drDropdown= new List<SelectListItem>();

            drDropdown.Add(new SelectListItem
            {
                Text = "- Select One -",
                Value = "0",
                Selected = true
            });

            drDropdown.Add(new SelectListItem
            { Text = "Sean Bozorgzadeh, MD", Value = "1" });

            drDropdown.Add(new SelectListItem
            { Text = "Mae Lary, MD", Value = "2" });

            drDropdown.Add(new SelectListItem
            { Text = "Timothy Manzo, DO", Value = "3" });

            drDropdown.Add(new SelectListItem
            { Text = "Jeremy Quinn, PA", Value = "4" });

            ViewBag.SelectDoctor = drDropdown;
            return View();
        }

        // Post: Provider
        [HttpPost]
        public ActionResult Index(SendEmailViewModel sendEmailViewModel)          
        {        
            if (ModelState.IsValid) { 
                var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("sunilsalaria1993@gmail.com", "ty7@Email!!"),
                EnableSsl = true
            };
            var messageBody = "Hi, <br><br>" + "Location: " + sendEmailViewModel.Location + "<br><br> Doctor: " + sendEmailViewModel.Doctor + "<br><br> Name: " + sendEmailViewModel.Name +
                "<br><br> Email Address: " + sendEmailViewModel.EmailAddress + "<br><br> Phone Number: " + sendEmailViewModel.PhoneNumber + "<br><br> Comments: " + sendEmailViewModel.Comments;

            client.Send("sunilsalaria1993@gmail.com", "Bunty@yopmail.com", "Patient Detail", messageBody);
                //email send success method
                TempData["message"] = "Email Send Successfully.";
            }        
            return RedirectToAction("Index");            
        }

        // GET: SeanBozorgzadehMd
        public ActionResult SeanBozorgzadehMd()
        {
            return View();
        }

        // GET: MaeLaryMd
        public ActionResult MaeLaryMd()
        {
            return View();
        }

        // GET: TimothyManzoDo
        public ActionResult TimothyManzoDo()
        {
            return View();
        }

        // GET: JeremyQuinnPa
        public ActionResult JeremyQuinnPa()
        {
            return View();
        }

        
    }
}