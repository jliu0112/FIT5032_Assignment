using HungrySouls_demo1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HungrySouls_demo1.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are happy that you come to Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            //string path = "~/Content/Upload/" + Guid.NewGuid() + "/";
            if (ModelState.IsValid)
            {
               // var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                string[] receiver = model.ToEmail.Split(';');
                for (int i =0; i < receiver.Length; i++)
                {
                    if (receiver.Length > 0)
                    {
                        message.To.Add(new MailAddress(receiver[i])); //replace with valid value
                    }
                }
                message.Subject = "Your email subject";
                message.Body = string.Format( model.FromName, "hungry.souls@hungry.com", model.Message);
                message.IsBodyHtml = true;
                if (model.Bcc != null)
                {
                    message.Bcc.Add(model.Bcc);
                    if (model.Cc != null)
                    {
                        message.CC.Add(model.Cc);
                    }
                }

                if (model.Upload != null && model.Upload.Count > 0)
                {
                    for (int i = 0; i < model.Upload.Count; i++)
                    {
                        HttpPostedFileBase file = model.Upload[i];
                        message.Attachments.Add(new Attachment(file.InputStream, Path.GetFileName(file.FileName)));
                    }
                }


                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
        public ActionResult Sent()
        {
            return View();
        }



    }
}
    

