using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Abstract
{
    interface IOfferService
    {
        void Add(Offer offer);
        void Update(Offer offer);
        void Delete(Offer offer);
    }
}
