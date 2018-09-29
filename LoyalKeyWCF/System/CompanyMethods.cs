using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoyalKeyWCF.System
{
    public class CompanyMethods
    {
        public string GetCompanyName(int companyID)
        {
            string companyName = "";
            try
            {
                using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
                {
                    LoyalKeyDB.Company company = loyalkeyDB.Companies.Find(companyID);
                    companyName = company.CompanyName;
                }
            }
            catch
            {
                companyName = "Error obtaining Company Name";
            }

            return companyName;
        }

        public string GetCompanyPostcode(int companyID)
        {
            string companyPostcode = "";
            try
            {
                using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
                {
                    LoyalKeyDB.Company company = loyalkeyDB.Companies.Find(companyID);
                    companyPostcode = company.PostCode;
                }
            }
            catch
            {
                companyPostcode = "Error obtaining Company Postcode";
            }

            return companyPostcode;
        }
    }
}