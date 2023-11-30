using WebGoatCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebGoatCore.Data
{
    public class BlogEntryRepository
    {
        private readonly NorthwindContext _context;

        public BlogEntryRepository(NorthwindContext context)
        {
            _context = context;
        }

        public BlogEntry CreateBlogEntry(string title, string contents, string username)
        {
            BlogEntry entry = new BlogEntry
            (   
                new Title(title),
                new PostedDate(DateTime.Now),
                new Contents(contents),
                new Author(username)
                
            );

            entry = _context.BlogEntries.Add(entry).Entity;
            _context.SaveChanges();
            return entry;
        }

        public BlogEntry GetBlogEntry(int blogEntryId)
        {
            //return _context.BlogEntries.Single(b => b.Id == blogEntryId);
            return _context.BlogEntries.Where(Id => GetBlogEntry(blogEntryId)).Single(); // Første forsøg
        }

        public List<BlogEntry> GetTopBlogEntries()
        {
            return GetTopBlogEntries(4, 0);
        }

        public List<BlogEntry> GetTopBlogEntries(int numberOfEntries, int startPosition)
        {
            var blogEntries = _context.BlogEntries
                .OrderByDescending(b => b.PostedDate)
                .Skip(startPosition)
                .Take(numberOfEntries);
            return blogEntries.ToList();
        }
    }
}
