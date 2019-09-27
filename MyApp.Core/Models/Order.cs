using System;

namespace MyApp.Core.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }
    }
}
