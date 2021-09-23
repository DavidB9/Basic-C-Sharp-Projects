using SampleApp.Models;
using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signUps = db.SignUps.Where(x => x.Removed == null).ToList();

                var signUps = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();

                var signUpVMs = new List<SignUpVM>();

                foreach (var signUp in signUps)
                {
                    var signUpVM = new SignUpVM();
                    signUpVM.Id = signUp.Id;
                    signUpVM.FirstName = signUp.FirstName;
                    signUpVM.LastName = signUp.LastName;
                    signUpVM.EmailAddress = signUp.EmailAddress;
                    signUpVMs.Add(signUpVM);
                }

                return View(signUpVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }

}