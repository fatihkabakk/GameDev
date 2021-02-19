using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void ApplyDiscount(Game game, Discount discount)
        {
            _gameDal.ApplyDiscount(game, discount);
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
