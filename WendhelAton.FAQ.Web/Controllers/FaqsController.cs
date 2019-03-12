using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using CodeKicker.BBCode;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;
using WendhelAton.FAQ.Web.ViewModels.Faqs;

namespace WendhelAton.FAQ.Web.Controllers
{
    public class FaqsController : Controller
    {
        private readonly DefaultDbContext _context;

        public FaqsController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("faqs")]
        [HttpGet, Route("faqs/index")]
        public IActionResult Index()
        {
            return View(new IndexViewModel()
            {
                Faqs = Feed(1)
            });
        }



        [HttpGet, Route("faqs/feed")]
        public List<Faq> Feed(int pageIndex)
        {
            int skip = (int)(3 * (pageIndex - 1));
            return this._context.Faqs
                                .Where(p => p.IsPublished == true)
                                .OrderByDescending(p => p.Timestamp)
                                .Skip(skip)
                                .Take(10)
                                .ToList();
        }


        [HttpGet, Route("faqs/{faqId}")]
        public IActionResult Faq(Guid? faqId)
        {
            var faq = this._context.Faqs.FirstOrDefault(p => p.Id == faqId);

            if (faq != null)
            {
                return View(new FaqsViewModel()
                {
                    FaqId = faq.Id,
                    Question = faq.Question,
                    Answer = ParseBBCode(faq.Answer)
                });
            }

            return StatusCode(404);
        }
        


        public string ParseBBCode(string bbcode)
        {
            var parser = new BBCodeParser(new[]
                {
                    new BBTag("img", "<img src=\"${content}\" />", "", false, true),
                    new BBTag("b", "<strong>", "</strong>"),
                    new BBTag("color","<font  color=\"${color}\">","</font >", new BBAttribute("color", ""), new BBAttribute("color", "color")),
                    new BBTag("i", "<span style=\"font-style:italic;\">", "</span>"),
                    new BBTag("u", "<span style=\"text-decoration:underline;\">", "</span>"),
                    new BBTag("code", "<pre class=\"prettyprint\">", "</pre>"),
                    new BBTag("quote", "<blockquote>", "</blockquote>"),
                    new BBTag("list", "<ul>", "</ul>"),
                    new BBTag("*", "<li>", "</li>", true, false),
                    new BBTag("url", "<a href=\"${href}\">", "</a>", new BBAttribute("href", ""), new BBAttribute("href", "href")),
                    new BBTag("youtube", "<div class='video'><iframe width='550px' height='309px' src='//www.youtube.com/embed/${content}' allowFullScreen></iframe></div>","", false, true),
                });
            return parser.ToHtml(bbcode);
        }
    }
}