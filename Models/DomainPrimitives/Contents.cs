using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{
    public class Contents
    {
        private string _contents;

        public Contents(string Contents)
        {
            ValidateContents(Contents);
            _contents = Contents;
        }

        public void ValidateContents(string Contents)
        {
            if (Contents.Length < 1 || Contents.Length > 2400)
            {
                throw new ArgumentOutOfRangeException("Blog content must be between 1 and 2400 characters");
            }

            if (string.IsNullOrEmpty(Contents))
            {
                throw new ArgumentNullException("Blog content can not be null or empty");
            }
            // Allow charcters, numbers and following special characters :~@#$^&*()-_+=[]{}|\,.?:'"%
            string RegexString = @"/^(?=[a-zA-Z0-9~@#$^*()_+=[\]{}|\\,.?: -]*$)(?!.*[<>\/;`])";
            bool Match = Regex.IsMatch(Contents, RegexString);
            if (!Match)
            {
                throw new ArgumentException("Invalid characters in blog content");
            }
        }
        public string GetContents()
        {
            return _contents;
        }
    }
}
