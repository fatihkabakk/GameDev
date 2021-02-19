using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGamerDal : IGamerDal
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu sisteme başarıyla kaydedildi!");
        }

        public void BuyGame(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu " + game.Name + " adlı oyunu " + game.UnitPrice + " TL karşılığında satın aldı!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu sistemden başarıyla silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu başarıyla güncellendi!");
        }
    }
}
