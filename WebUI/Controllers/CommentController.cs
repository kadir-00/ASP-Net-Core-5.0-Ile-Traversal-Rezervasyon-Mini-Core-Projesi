using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = DateTime.Now.Date; // Safer than ToShortDateString parsing
            _commentService.Create(p);
            return RedirectToAction("DestinationDetail", "Destination", new { id = p.DestinationId });
        }
    }
}
