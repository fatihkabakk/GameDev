using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICampaignService
    {
        double ApplyCampaign(Game game, Campaign campaign);
    }
}
