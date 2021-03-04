using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Abstract
{
    interface ISaleService
    {
        void Add(Gamer gamer, Game game, Offer offer);
        void Update(Gamer gamer, Game game, Offer offer);
        void Delete(Gamer gamer, Game game, Offer offer);
    }
}
