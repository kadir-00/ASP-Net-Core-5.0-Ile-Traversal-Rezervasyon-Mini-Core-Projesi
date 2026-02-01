using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebUI.Areas.Admin.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    // [Authorize(Roles = "Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult MailCreate()
        {
            ViewBag.mailActive = "active";
            return View();
        }

        [HttpPost]
        public IActionResult MailCreate(MailRequestModel mailRequestModel)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxSenderAddress = new MailboxAddress(mailRequestModel.SenderName, mailRequestModel.SenderMail);
            mimeMessage.From.Add(mailboxSenderAddress);

            MailboxAddress mailboxReceiverAddress = new MailboxAddress(mailRequestModel.ReceiverName, mailRequestModel.ReceiverMail);
            mimeMessage.To.Add(mailboxReceiverAddress);

            mimeMessage.Subject = mailRequestModel.Subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequestModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Connect(mailRequestModel.SenderMailHost, mailRequestModel.SenderMailPort, MailKit.Security.SecureSocketOptions.StartTls);

            smtpClient.Authenticate(mailRequestModel.SenderMail, mailRequestModel.SenderMailPassword);

            smtpClient.Send(mimeMessage);

            smtpClient.Disconnect(true);

            TempData["icon"] = "success";
            TempData["text"] = "Mail gönderildi.";
            return RedirectToAction("MailCreate", "Mail", new { Area = "Admin" });
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult SendTestMail()
        {
            try
            {
                MimeMessage mimeMessage = new MimeMessage();

                var senderMail = "traversalcore2@gmail.com";
                var senderPassword = "btjq vqde dftu irbf";
                var senderHost = "smtp.gmail.com";
                var senderPort = 587;


                MailboxAddress mailboxSenderAddress = new MailboxAddress("Antigravity Agent", senderMail);
                mimeMessage.From.Add(mailboxSenderAddress);

                MailboxAddress mailboxReceiverAddress = new MailboxAddress("Kadir", "ukadir231@gmail.com");
                mimeMessage.To.Add(mailboxReceiverAddress);

                mimeMessage.Subject = "Test Mail from Antigravity Agent";

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "This is a verification email sent at: " + DateTime.Now;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                SmtpClient smtpClient = new SmtpClient();

                smtpClient.Connect(senderHost, senderPort, MailKit.Security.SecureSocketOptions.StartTls);

                smtpClient.Authenticate(senderMail, senderPassword.Replace(" ", ""));

                smtpClient.Send(mimeMessage);

                smtpClient.Disconnect(true);

                return Content("Test mail sent successfully to ukadir231@gmail.com! Please check your inbox/spam folder.");
            }
            catch (Exception ex)
            {
                return Content($"Error sending mail: {ex.Message}. \nCheck that you updated the sender credentials in MailController.cs!");
            }
        }
    }
}