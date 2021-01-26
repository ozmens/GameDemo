using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(new Player { NationalityId = "12345678910", 
                FirstName = "Serkan", LastName = "Özmen", DateOfBirth = new DateTime(1984, 6, 16) });

            Product product1 = new Product();
            product1.GameName = "Football Manager 2021";
            product1.GameType = "Manager Simulation";

            Player player1 = new Player();
            player1.FirstName = "Hakan";
            player1.LastName = "Candan";

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(product1, player1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Yaza Merhaba Kampanyası";
            campaign1.DiscountPercentage = 25;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

           

        }
    }
}
