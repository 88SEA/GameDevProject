using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Entities
{
    class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public long IdentityNumber { get; set; }
        public List<int> PurchasedGames { get; set; }
    }
}
