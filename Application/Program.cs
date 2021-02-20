using Business.Abstract;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { UserId = 1, Name = "Fatih", LastName = "Kabak", NationalityId = "12345678910", YearOfBirth = 1999 };
            Gamer gamer2 = new Gamer { UserId = 2, Name = "Ekrem", LastName = "Sönmez", NationalityId = "11111111110", YearOfBirth = 1992 };
            Gamer gamer3 = new Gamer { UserId = 3, Name = "A", LastName = "", NationalityId = "123", YearOfBirth = 2010 };
            Gamer gamer4 = new Gamer { UserId = 4, Name = "Özgür", LastName = "Ağca", NationalityId = "13445367890", YearOfBirth = 2001 };

            Game gtav = new Game { GameId = 1, Name = "GTA-V", Developer = "Rockstar Games", ReleaseDate = "17 Eylül 2013", UnitPrice = 156 };
            Game pubg = new Game { GameId = 2, Name = "PUBG", Developer = "KRAFTON, Inc.", ReleaseDate = "21 Aralık 2017", UnitPrice = 87 };

            Console.WriteLine("*********************************************");
            IGamerDal gamerDal = new InMemoryGamerDal();
            IValidationService validationService = new MernisManager();
            
            GamerManager gamerManager = new GamerManager(gamerDal, validationService);
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);
            gamerManager.Add(gamer4);
            gamerManager.Delete(gamer2);
            Console.WriteLine("*********************************************");

            Console.WriteLine("\n*********************************************");
            IGameDal gameDal = new InMemoryGameDal();
            ICampaignService campaignService = new CampaignManager();

            GameManager gameManager = new GameManager(gameDal);
            gameManager.Add(gtav);
            gameManager.Add(pubg);

            OrderManager orderManager = new OrderManager(campaignService);
            orderManager.CreateCampaignOrder(gamer1, gtav, new Campaign { Name = "Hot Sales!", DiscountRate = 25 });
            orderManager.CreateCampaignOrder(gamer4, pubg, new Campaign { Name = "Winter Sales!", DiscountRate = 50 });
            orderManager.CreateOrder(gamer1, pubg);

            Console.WriteLine("*********************************************");
            Console.ReadKey();
        }
    }
}
