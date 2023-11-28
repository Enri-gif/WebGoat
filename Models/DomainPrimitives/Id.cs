using System;
using System.Collections.Generic
using System.Text.RegularExpressions


namespace WebGoatCore.Models
{
    public class Id
    {
        private int _id;

        public Id(int Id)
        {
            ValidateId(Id);
            _id = Id;
        }
        
        public void ValidateId(int Id)
        {
            //Check length
            //Max limit is maximum number for a 32 bit integer
            if (Id < 0 || Id > 2147483646)
            {
                throw new ArgumentOutOfRangeException("Id is out of range");
            }
            //Check for null or empty
            if (Id == null)
            {
                throw new ArgumentNullException("Id cannot be null");
            }
            //Regex validation
            string RegexString = @"\d+";
            bool Match = Regex.IsMatch(Id, RegexString);
            if (!Match)
            {
                throw new InvalidDataException("Id is invalid");
            }
            public string GetId()
            {
                return _id;
            }
        }

    }
}
