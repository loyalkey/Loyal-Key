using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LoyalKeyWCF.System;
using LoyalKeyWCF.System.Models;

namespace LoyalKeyWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserServices
    {
        public string AddUser(string identifier, string companyID)
        {
            UserMethods um = new UserMethods();
            try
            {
                int companyIDInt = Int32.Parse(companyID);
                return um.AddUser(identifier,companyIDInt);
            }
            catch (Exception e)
            {
                return "bad";
            }
        }

        public UserDataContract GetActiveUser(string userID)
        {
            UserMethods um = new UserMethods();
            try
            {
                int userIDInt = Int32.Parse(userID);
                return um.GetActiveUser(userIDInt);
            }
            catch (Exception e)
            {
                UserDataContract bad = new UserDataContract();
                return bad;
            }
        }

    }
}
