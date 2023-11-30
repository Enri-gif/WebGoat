using System;
using System.Collections.Generic;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace WebGoatCore.Models
{
    public class BlogEntry
    {
        public int  Id {set; get;}
        public string Title{set; get;}
        public DateTime PostedDate{set; get;}
        public string Contents{set; get;}
        public string Author{set; get;}

        public virtual IList<BlogResponse> Responses { get; set; }
    }
}

//         public BlogEntry(Id id, Title title, PostedDate postedDate, Contents contents, Author author) // Med ID!!! 
//         {
//             ValidateBlogEntry(id, title, postedDate, contents, author);
//             Id = id;
//             Title = title;
//             PostedDate = postedDate;
//             Contents = contents;
//             Author = author;
//         }
//         public BlogEntry(Title title, PostedDate postedDate, Contents contents, Author author) // Uden ID!!!
//         {
//             ValidateBlogEntry(title, postedDate, contents, author);
//             Title = title;
//             PostedDate = postedDate;
//             Contents = contents;
//             Author = author;
//         }

        
//         private void ValidateBlogEntry(Id id, Title title, PostedDate postedDate, Contents contents, Author author) // MED ID!!!!!
//         {
//             if (id == null)
//             {
//                 throw new NullReferenceException("id is Null");
//             }
//             if (title == null)
//             {
//                 throw new NullReferenceException("postedDate is Null");
//             }
//             if (postedDate == null)
//             {
//                 throw new NullReferenceException("postedDate is Null");
//             }
//             if (contents == null)
//             {
//                 throw new NullReferenceException("contents is Null");
//             }
//             if (author == null)
//             {
//                 throw new NullReferenceException("author is Null");
//             }
//         }
        
//         private void ValidateBlogEntry(Title title, PostedDate postedDate, Contents contents, Author author) // Uden ID!!!
//         {
//             if (title == null)
//             {
//                 throw new NullReferenceException("postedDate is Null");
//             }
//             if (postedDate == null)
//             {
//                 throw new NullReferenceException("postedDate is Null");
//             }
//             if (contents == null)
//             {
//                 throw new NullReferenceException("contents is Null");
//             }
//             if (author == null)
//             {
//                 throw new NullReferenceException("author is Null");
//             }
//         }
//         public int GetId()
//         {
//             return Id.GetId();
//         }
//         public string GetTitle()
//         {
//             return Title.GetTitle();
//         }
//         public DateTime GetPostedDate()
//         {
//             return PostedDate.GetPostedDate();
//         }
//         public string GetContents()
//         {
//             return Contents.GetContents();
//         }
//     }
// }
