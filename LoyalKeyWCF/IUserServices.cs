using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LoyalKeyWCF.System.Models;

namespace LoyalKeyWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserServices
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddUser/{Identifier}/{CompanyID}")]
        string AddUser(string identifier, string companyID);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetActiveUser/{UserID}")]
        UserDataContract GetActiveUser(string userID);
    }
}
