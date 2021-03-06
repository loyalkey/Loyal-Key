﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LoyalKeyWCF.System;
using LoyalKeyWCF.System.Models;
namespace LoyalKeyWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CompanyService : ICompanyServices
    {
        public List<CompanyDataContract> GetAllCompanies()
        {
            try
            {
                CompanyMethods cm = new CompanyMethods();
                return cm.GetAllCompanies();
            }
            catch
            {
                List<CompanyDataContract> bad = new List<CompanyDataContract>();
                return bad;
            }
        }

        public CompanyDataContract GetCompanyDetail(string companyID)
        {
            CompanyMethods cm = new CompanyMethods();
            try
            {
                int companyIDInt = Int32.Parse(companyID);
                return cm.GetCompanyDetail(companyIDInt);
            }
            catch(Exception e)
            {
                CompanyDataContract bad = new CompanyDataContract();
                return bad;
            }
        }

    }
}
