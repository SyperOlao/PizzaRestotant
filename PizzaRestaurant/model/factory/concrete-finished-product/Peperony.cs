﻿using PizzaRestaurant.model.interfaces;
using PizzaRestaurant.model.entity;

namespace PizzaRestaurant.model.factory.concrete_finished_product
{
    internal class Peperony : IFinishedProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public Peperony(int price, int weight)
        {   
            Name = "Peperony";
            Description = "Pizza with sausages";
            Price = price;
            Weight = weight;
        }
    }
}
