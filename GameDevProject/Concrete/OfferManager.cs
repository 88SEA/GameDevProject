using GameDevProject.Abstract;
using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Concrete
{
    class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Offer added.");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Offer deleted.");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Offer updated.");
        }
    }
}
