using WebGoatCore.Models;
using WebGoatCore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebGoatCore.Controllers
{
    [Route("[controller]/[action]")]
    public class BlogController : Controller
    {
        private readonly BlogEntryRepository _blogEntryRepository;
        private readonly BlogResponseRepository _blogResponseRepository;

        public BlogController(BlogEntryRepository blogEntryRepository, BlogResponseRepository blogResponseRepository, NorthwindContext context)
        {
            _blogEntryRepository = blogEntryRepository;
            _blogResponseRepository = blogResponseRepository;
        }

        public IActionResult Index()
        {
            return View(_blogEntryRepository.GetTopBlogEntries());
        }

        [HttpGet("{entryId}")]
        public IActionResult Reply(int entryId)
        {
            return View(_blogEntryRepository.GetBlogEntry(entryId));
        }
        
        [HttpPost("{entryId}")]
        public IActionResult Reply(int entryId, string contents) // her skal dto ind
        {
            BlogResponsDTO blogResponsDTO = new BlogResponsDTO();
            blogResponsDTO.Author = User?.Identity?.Name ?? "Anonymous";
            blogResponsDTO.Contents = contents;
            blogResponsDTO.BlogEntryId = entryId;
            blogResponsDTO.ResponseDate = DateTime.Now;
            

            var response = new BlogResponse()
            {
                Author = blogResponsDTO.Author,
                Contents =  blogResponsDTO.Contents,
                BlogEntryId = blogResponsDTO.BlogEntryId,
                ResponseDate = blogResponsDTO.ResponseDate
            };
            _blogResponseRepository.CreateBlogResponse(response);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create() => View();

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(string title, string contents)
        {
            var blogEntry = _blogEntryRepository.CreateBlogEntry(title, contents, User!.Identity!.Name!);
            return View(blogEntry);
        }

    }
}