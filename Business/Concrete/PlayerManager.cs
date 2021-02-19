using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IGamerDal _gamerDal;
        public PlayerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal;
        }
        public void Add(Gamer gamer)
        {
            IMernisService mernisCheck = new MernisCheck();
            if (mernisCheck.Validate(gamer))
            {
                _gamerDal.Add(gamer);
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri hata içerdiğinden dolayı kayıt yapılamadı!");
            }
        }

        public void BuyGame(Gamer gamer, Game game)
        {
            _gamerDal.BuyGame(gamer, game);
        }

        public void Delete(Gamer gamer)
        {
            _gamerDal.Delete(gamer);
        }

        public void Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
        }
    }
}
