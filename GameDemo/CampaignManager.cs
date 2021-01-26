using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi : " + campaign.CampaignName + "- %" + campaign.DiscountPercentage + "indirim!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.CampaignName + "kampanyasında yeni indirim oranı %" + campaign.DiscountPercentage);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("%" + campaign.DiscountPercentage + " indirim oranlı " + campaign.CampaignName + "kampanyası bitmiştir.");
        }
    }
}
