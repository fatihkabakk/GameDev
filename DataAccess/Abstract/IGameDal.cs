using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGameDal
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
        void ApplyDiscount(Game game, Campaign discount);
    }
}
