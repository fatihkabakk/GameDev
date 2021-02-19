using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { UserId = 1, Name = "Fatih", LastName = "Kabak", NationalityId = "12345678910", YearOfBirth = 1999 };
            Gamer gamer2 = new Gamer() { UserId = 2, Name = "Ekrem", LastName = "Sönmez", NationalityId = "11111111110", YearOfBirth = 1992 };
            Gamer gamer3 = new Gamer() { UserId = 3, Name = "A", LastName = "", NationalityId = "123", YearOfBirth = 2010 };

            Game gtav = new Game() { GameId = 1, Name = "GTA V", Developer = "Rockstar Games", ReleaseDate = "17 Eylül 2013", UnitPrice = 156 };
            Game pubg = new Game() { GameId = 2, Name = "PUBG", Developer = "KRAFTON, Inc.", ReleaseDate = "21 Aralık 2017", UnitPrice = 87 };

            PlayerManager playerManager = new PlayerManager(new InMemoryGamerDal());
            Console.WriteLine("*********************************************");
            playerManager.Add(gamer1);

            playerManager.Add(gamer2);
            playerManager.Add(gamer3);
            playerManager.Delete(gamer2);
            playerManager.BuyGame(gamer1, pubg);
            Console.WriteLine("*********************************************");
            GameManager gameManager = new GameManager(new InMemoryGameDal());

            gameManager.Add(gtav);
            gameManager.ApplyDiscount(gtav, new Discount() { Name = "Hot Sales!", DiscountRate = 25 });

            Console.WriteLine(gamer1.UserId + " " + gamer1.Name + " " + gamer1.LastName);
        }
    }
}
