using System;

namespace FE_Hot_Diggety_Dog.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string Description { set; get; }
        public string Category { get; set; }
    }
}