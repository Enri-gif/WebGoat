using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{
    public class PostedDate
    {
        private DateTime _postedDate;

        public PostedDate(DateTime PostedDate)
        {
            ValidatePostedDate(PostedDate);
            _postedDate = PostedDate;
        }

        public void ValidatePostedDate(DateTime PostedDate)
        {
            DateTime CompanyFoundingDate = new DateTime(2010,10,25);
            if (PostedDate < CompanyFoundingDate || PostedDate > DateTime.Now.AddHours(1))
            {
                throw new ArgumentException("Invalid DateTime");
            }
        }
        public DateTime GetPostedDate()
        {
            return _postedDate;
        }
    }
}
