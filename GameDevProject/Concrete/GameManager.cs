using GameDevProject.Abstract;
using GameDevProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated.");
        }
    }
}
