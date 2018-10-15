using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace LoyalKeyWCF.System.Models
{
    [DataContract]
    public class UserDataContract
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int CompanyID { get; set; }
        [DataMember]
        public int BassCode { get; set; }
        [DataMember]
        public string Identifier { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}