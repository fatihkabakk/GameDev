using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public double ApplyCampaign(Game game, Campaign campaign)
        {
            double _tempPrice = game.UnitPrice - (game.UnitPrice * (campaign.DiscountRate * 0.01));
            return _tempPrice;
        }
    }
}
