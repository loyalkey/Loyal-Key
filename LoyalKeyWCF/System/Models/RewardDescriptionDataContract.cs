using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace LoyalKeyWCF.System.Models
{
    [DataContract]
    public class RewardDescriptionDataContract
    {
        [DataMember]
        public int RewardDescriptionID { get; set; }
        [DataMember]
        public int RewardID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal Value { get; set; }
    }
}