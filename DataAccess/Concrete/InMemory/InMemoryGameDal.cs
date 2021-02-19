using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGameDal : IGameDal
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun başarıyla sisteme eklendi!");
        }

        public void ApplyDiscount(Game game, Discount discount)
        {
            double result = game.UnitPrice - (game.UnitPrice * (discount.DiscountRate * 0.01));
            game.UnitPrice = result;
            Console.WriteLine(game.Name + " adlı oyunun fiyatı " + game.UnitPrice + " TL olarak güncellendi!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun başarıyla sistemden silindi!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun başarıyla güncellendi!");
        }
    }
}
