using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerDal _gamerDal;
        IValidationService _validationService;
        public GamerManager(IGamerDal gamerDal, IValidationService validationService)
        {
            _gamerDal = gamerDal;
            _validationService = validationService;
        }
        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer))
            {
                _gamerDal.Add(gamer);
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri hata içerdiğinden dolayı kayıt yapılamadı!");
            }
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
