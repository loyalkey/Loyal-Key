using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace LoyalKeyWCF.System.Models
{
    [DataContract]
    public class RewardDataContract
    {
        [DataMember]
        public int RewardID { get; set; }
        [DataMember]
        public int CompanyID { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int RewardTypeID { get; set; }
    }
}