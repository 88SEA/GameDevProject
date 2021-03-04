using System;
using System.Collections.Generic;
using System.Text;

namespace GameDevProject.Entities
{
    class Sale
    {
        public int Id { get; set; }
        public List<int> GameId { get; set; }
        public string GamerId { get; set; }
        public int OfferId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
