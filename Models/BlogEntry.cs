using System;
using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class BlogEntry
    {
        public Id Id { get; }
        public Title Title { get; }
        public PostedDate PostedDate { get; }
        public Contents Contents { get; }
        public Author Author { get; }

        public virtual IList<BlogResponse> Responses { get; set; }

        public BlogEntry(Id id, Title title, PostedDate postedDate, Contents contents, Author author)
        {
            ValidateBlogEntry(id, titlem postedDate, contents, author);
            Id = id;
            Title = title;
            PostedDate = postedDate;
            Contents = contents;
            Author = author;
        }
        
        private void ValidateBlogEntry(Id id, Title title, PostedDate postedDate, Contents contents, Author author)
        {
            if (id == null)
            {
                throw new NullReferenceException("id is Null");
            }
            if (title == null)
            {
                throw new NullReferenceException("postedDate is Null");
            }
            if (postedDate == null)
            {
                throw new NullReferenceException("postedDate is Null");
            }
            if (contents == null)
            {
                throw new NullReferenceException("contents is Null");
            }
            if (author == null)
            {
                throw new NullReferenceException("author is Null");
            }
        }
    }
}
