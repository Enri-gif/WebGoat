using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models 
{
    public class CompanyName  // Hele dette stykke kan man ens som Encupsulering minus validerings delen. 
    {
        private string _CompanyName;
         
        public CompanyName(string CompanyName)
        {
            IsnameValid(CompanyName);
            _CompanyName = CompanyName;

        } 
        public string GetComapanyName()
        {
            return _CompanyName;

        }

        private void IsnameValid(string CompanyName)
        {
            if (CompanyName.Length < 1 || CompanyName.Length > 100)
            {   

            }
            
            if (String.IsNullOrEmpty(CompanyName))
            {
                throw new ArgumentException("CompanyName is Empty");
            }
            string RegexString = "^[a-zA-Z]+$";
            bool match = Regex.IsMatch(CompanyName, RegexString);
            if(!match)
            {
                throw new ArgumentException("Please type a Valid Company name.");

            }
        }
        
    }





}