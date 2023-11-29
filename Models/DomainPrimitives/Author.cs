using System;
using System.Collections.Generic
using System.Text.RegularExpressions

namespace WebGoatCore.Models
{
    public class Author
    {
        private string _author;

        Author(string Author)
        {
            ValidateAuthor(Author);
            _author = Author;       
        }
        public void ValidateAuthor(string Author)
        {
            // Check length
            if(Author.length < 1 || Author.length >= 50)
            {
                throw new ArgumentOutOfRangeException("Author must be between 1 and 50");
            }
            // Check for null or empty
            if(string.IsNullOrEmpty(Author))
            {
                throw new ArgumentNullException("Author can ot be null or empty");
            }
            // Regex validation
            // only letters
            string RegexString = @"[a-zA-Z]";
            bool Match = Regex.IsMatch(Author, RegexString);
            if (!Match)
            {
                throw new InvalidDataException("Invalid author");
            }
        }

        public string GetAuthor()
        {
            return _author;
        }
    }
}