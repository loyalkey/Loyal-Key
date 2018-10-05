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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RewardService : IRewardServices
    {
        public List<RewardDataContract> GetActiveRewardsFromCompany(string companyID)
        {
            RewardMethods rm = new RewardMethods();
            try
            {
                int companyIDInt = Int32.Parse(companyID);
                return rm.GetActiveRewardsFromCompany(companyIDInt);
            }
            catch(Exception e)
            {
                List<RewardDataContract> bad = new List<RewardDataContract>();
                return bad;
            }
        }
        public List<RewardDescriptionDataContract> GetRewardDescriptionsFromReward(string rewardID)
        {
            RewardMethods rm = new RewardMethods();
            try
            {
                int rewardIDInt = Int32.Parse(rewardID);
                return rm.GetRewardDescriptionsFromReward(rewardIDInt);
            }
            catch(Exception e)
            {
                List <RewardDescriptionDataContract> bad = new List<RewardDescriptionDataContract>();
                return bad;
            }
        }
    }
}
