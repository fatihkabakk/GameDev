using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void CreateCampaignOrder(Gamer gamer, Game game, Campaign campaign)
        {
            _campaignService.ApplyCampaign(game, campaign);
            Console.WriteLine(gamer.Name + " adlı oyuncu " + game.Name + " adlı oyunu " + game.UnitPrice + " TL karşılığında " + campaign.Name + " kampanyası ile satın aldı");
        }

        public void CreateOrder(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu " + game.Name + " adlı oyunu " + game.UnitPrice + " TL karşılığında satın aldı");
        }
    }
}
