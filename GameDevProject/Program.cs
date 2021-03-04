using GameDevProject.Adapters;
using GameDevProject.Concrete;
using GameDevProject.Entities;
using System;

namespace GameDevProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = new DateTime(1988),
                FirstName = "ETHEM ANIL",
                LastName = "SANDALCI",
                IdentityNumber = 12345                
            });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game
            {
                Id = 3,
                ProductName = "Diablo III",
                ProductPrice = 19
            });

            OfferManager offerManager = new OfferManager();
            offerManager.Add(new Offer
            {
                Id = 5,
                OfferName = "Legend Of Summer",
                Discount = 30
            });

            SaleManager salesManager = new SaleManager();
            salesManager.Add(new Gamer { FirstName = "ETHEM ANIL, " }, new Game { ProductName = "Diablo, " }, new Offer { OfferName = "Legend Of Summer" });



        }
    }
}
