using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoyalKeyWCF.System.Models;

namespace LoyalKeyWCF.System
{
    public class UserMethods
    {
        public string AddUser(string identifier, int? companyID)
        {
            try
            {
                using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
                {
                    LoyalKeyDB.User user = new LoyalKeyDB.User();
                    user.CompanyID = companyID;
                    user.Identifier = identifier;
                    user.IsActive = true;
                    //Create a random 5 digit number as a basscode
                    Random generator = new Random();
                    int r = generator.Next(10000, 100000);

                    user.BassCode = r;

                    loyalkeyDB.Users.Add(user);
                    loyalkeyDB.SaveChanges();
                }

                return "success";
            }
            catch(Exception e)
            {
                return "Failed to add user";
            }
        }

        public UserDataContract GetActiveUser(int userID)
        {
            UserDataContract user = new UserDataContract();

            using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
            {
                try
                {
                    LoyalKeyDB.User userDB = loyalkeyDB.Users.Where(u => u.UserID == userID && u.IsActive == true).FirstOrDefault();
                    user.UserID = userDB.UserID;
                    user.CompanyID = userDB.CompanyID == null ? -1 : userDB.CompanyID.Value;
                    user.BassCode = userDB.BassCode;
                    user.Identifier = userDB.Identifier;
                    user.IsActive = userDB.IsActive;
                }
                catch
                {
                    user.UserID = -1;
                    user.CompanyID = -1;
                    user.BassCode = -1;
                    user.Identifier = "";
                    user.IsActive = false;
                }
            }

            return user;
        }

    }
}