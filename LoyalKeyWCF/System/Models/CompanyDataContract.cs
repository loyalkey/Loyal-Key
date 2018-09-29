using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace LoyalKeyWCF.System.Models
{
    [DataContract]
    public class CompanyDataContract
    {
        [DataMember]
        public int CompanyID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Postcode { get; set; }

        [DataMember]
        public bool Deleted { get; set; }
    }
}