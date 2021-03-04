using GameDevProject.Abstract;
using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Concrete
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit oldu.");
            }
            else
            {
                Console.WriteLine("Kayit basarisiz.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit guncellendi.");
        }
    }
}
