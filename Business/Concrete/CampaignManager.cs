using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void ApplyCampaign(Game game, Campaign campaign)
        {
            game.UnitPrice = game.UnitPrice - (game.UnitPrice * (campaign.DiscountRate * 0.01));
        }
    }
}
