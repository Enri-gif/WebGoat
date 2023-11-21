using System;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebGoatCore.Models 
{

    public class SupplierID
    {
        private string _SupplierID; // Dette bliver gjordt fordi man ønsker at inputet ikke man manipuleres dirkete.  

        public SupplierID(string SupplierID)
        {
            SupplierIDIsValid(SupplierID);
            _SupplierID = SupplierID; 
        }
        public string GetSupplierID()
        {
            return _SupplierID;
        }

        private void SupplierIDIsValid(string SupplierID)
        {
            if (SupplierID.Length < 3 || SupplierID.Length > 10)
            {
                return; // LAV en EXP HER!!!!!!

            }

            if (SupplierID == null || SupplierID == "") // Se CompanyName for en bedre validering af null og string! 
            {
                throw new ArgumentException("ID is NULL or Emtpy!");
            }

            string SupplierRegex = "^\\d+$";
            bool match = Regex.IsMatch(SupplierID, SupplierRegex);
            if (!match)
            {
                throw new ArgumentException("ID is Wrong!"); 
            }
    

        }
    }    
}