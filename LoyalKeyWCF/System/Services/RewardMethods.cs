using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoyalKeyWCF.System.Models;

namespace LoyalKeyWCF.System
{
    public class RewardMethods
    {
        public List<RewardDataContract> GetActiveRewardsFromCompany(int companyID)
        {
            DateTime now = DateTime.Now.Date;
            List<RewardDataContract> rewards = new List<RewardDataContract>();

            using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
            {
                var rewardsDB = loyalkeyDB.Rewards.Where(r => 
                                                         r.CompanyID == companyID &&
                                                         now >= r.StartDate &&
                                                         now < r.EndDate);
                foreach(LoyalKeyDB.Reward r in rewardsDB)
                {
                    RewardDataContract rdc = new RewardDataContract();
                    rdc.RewardID = r.RewardID;
                    rdc.CompanyID = r.CompanyID;
                    rdc.RewardTypeID = r.RewardTypeID;
                    rdc.StartDate = r.StartDate;
                    rdc.EndDate = r.EndDate;
                    rewards.Add(rdc);
                }
            }

            return rewards;
        }

        public List<RewardDescriptionDataContract> GetRewardDescriptionsFromReward(int rewardID)
        {
            DateTime now = DateTime.Now.Date;
            List<RewardDescriptionDataContract> descriptions = new List<RewardDescriptionDataContract>();

            using (var loyalkeyDB = new LoyalKeyDB.LoyalKeyDBEntities())
            {
                var query = loyalkeyDB.RewardDescriptions.Where(r =>
                                                         r.RewardID == rewardID);
                foreach (LoyalKeyDB.RewardDescription r in query)
                {
                    RewardDescriptionDataContract rdc = new RewardDescriptionDataContract();
                    rdc.RewardDescriptionID = r.RewardDescriptionID;
                    rdc.RewardID = r.RewardID;
                    rdc.Description = r.Description;
                    rdc.Value = r.Value;
                    rdc.StartDate = r.StartDate;
                    rdc.EndDate = r.EndDate;
                    descriptions.Add(rdc);
                }
            }

            return descriptions;
        }

    }
}