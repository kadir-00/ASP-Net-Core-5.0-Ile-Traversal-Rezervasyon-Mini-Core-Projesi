using Business.Abstract.AbstractUOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AccountUOfWorkController : Controller
    {
        private readonly IAccountUOfWorkService _accountUOfWorkService;
        private readonly UserManager<AppUser> _userManager;

        public AccountUOfWorkController(IAccountUOfWorkService accountUOfWorkService, UserManager<AppUser> userManager)
        {
            _accountUOfWorkService = accountUOfWorkService;
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.accountUOfWorkActive = "active";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AccountUOfWorkModel model)
        {
            ViewBag.accountUOfWorkActive = "active";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var valueSender = _accountUOfWorkService.GetById(user.Id);
            var valueReceiver = _accountUOfWorkService.GetById(model.ReceiverId);

            if (valueSender == null || valueReceiver == null)
            {
                ViewBag.error = "Alıcı veya gönderici hesap bulunamadı.";
                return View();
            }

            if (valueSender.AccountUOfWorkBalance < model.Amount)
            {
                ViewBag.error = "Yetersiz bakiye.";
                return View();
            }

            valueSender.AccountUOfWorkBalance -= model.Amount;
            valueReceiver.AccountUOfWorkBalance += model.Amount;

            var accounts = new List<AccountUOfWork>()
            {
                valueSender,
                valueReceiver
            };

            _accountUOfWorkService.MultiUpdate(accounts);

            TempData["icon"] = "success";
            TempData["text"] = "Bakiye gönderildi.";
            return RedirectToAction("Index", "AccountUOfWork");
        }
    }
}