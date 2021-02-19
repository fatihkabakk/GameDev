using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        void Add(Gamer gamer);
        void BuyGame(Gamer gamer, Game game);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
