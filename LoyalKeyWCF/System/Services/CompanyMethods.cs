using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoyalKeyWCF.System.Models;

namespace LoyalKeyWCF.System
{
    public class CompanyMethods
    {
        public List<CompanyDataContract> GetAllCompanies()
        {
            List<CompanyDataContract> allCompanies = new List<CompanyDataContract>();

            using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
            {
                var companiesDB = loyalkeyDB.Companies.Where(c => c.Deleted == false);
                foreach(LoyalKeyDB.Company companyDB in companiesDB)
                {
                    CompanyDataContract cdc = new CompanyDataContract();
                    cdc.CompanyID = companyDB.CompanyID;
                    cdc.Name = companyDB.CompanyName;
                    cdc.Postcode = companyDB.PostCode;
                    cdc.Deleted = cdc.Deleted;
                    allCompanies.Add(cdc);
                }
            }

            return allCompanies;
        }

        public CompanyDataContract GetCompanyDetail(int companyID)
        {
            CompanyDataContract company = new CompanyDataContract();

            using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
            {
                try
                {
                    LoyalKeyDB.Company companyDB = loyalkeyDB.Companies.Find(companyID);
                    company.CompanyID = companyDB.CompanyID;
                    company.Name = companyDB.CompanyName;
                    company.Postcode = companyDB.PostCode;
                    company.Deleted = companyDB.Deleted;
                }
                catch
                {
                    company.CompanyID = -1;
                    company.Name = "";
                    company.Postcode = "";
                    company.Deleted = false;
                }
            }

            return company;
        }

    }
}