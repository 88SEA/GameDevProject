using GameDevProject.Abstract;
using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Add(Gamer gamer, Game game, Offer offer)
        {
            Console.WriteLine("Gamer Name : " + gamer.FirstName + gamer.LastName + "Product : " + game.Id + game.ProductName + "Special Offer : " + offer.Discount + "added.");
        }

        public void Delete(Gamer gamer, Game game, Offer offer)
        {
            Console.WriteLine("Gamer Name : " + gamer.FirstName + gamer.LastName + "Product : " + game.Id + game.ProductName + "Special Offer : " + offer.Discount + "deleted.");
        }

        public void Update(Gamer gamer, Game game, Offer offer)
        {
            Console.WriteLine("Gamer Name: " + gamer.FirstName + gamer.LastName + "Product: " + game.Id + game.ProductName + "Special Offer: " + offer.Discount + "updated.");
        }
    }
}
