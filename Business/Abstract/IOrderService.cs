using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        void CreateOrder(Gamer gamer, Game game);
        void CreateCampaignOrder(Gamer gamer, Game game, Campaign campaign);
    }
}
