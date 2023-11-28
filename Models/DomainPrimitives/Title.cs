using System;
using System.Collections.Generic
using System.Text.RegularExpressions

namespace WebGoatCore.Models
{
    public class Title
    {
        private string _title;
        
        public Title(string Title)
        {
            ValidateTitle(Title);
            _title = Title;
        }

        public void ValidateTitle(string Title)
        {
            // Check length
            if (Title.length < 1 || Title.length >= 50)
            {
                throw new ArgumentOutOfRangeException("Title must be between 1 and 50");
            }
            // Check for null or empty
            if (string.IsNullOrEmpty(Title))
            {
                throw new ArgumentNullException("Title can not be null or empty");
            }
            // Regec validation
            string RegexString = @"[a-zA-Z]";
            bool Match = Regex.IsMatch(Title, RegexString);
            if (!Match)
            {
                throw new InvalidDataException("Invalid Title");
            }

            public string GetTitle()
            {
                return _title;
            }
        }
    }
}
