using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird penguin = new Bird();
            penguin.Legs = 2;
            penguin.Fur = false;
            penguin.BloodTemp = "warmblooded";
            penguin.Nocturnal = false;
            penguin.BeakType = "short";
            penguin.FeathersType = "tight and attached";
            penguin.Flight = false;
            penguin.Food = "fish";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile crocodile = new Reptile();
            crocodile.Legs = 4;
            crocodile.Fur = false;
            crocodile.BloodTemp = "coldblooded";
            crocodile.Nocturnal = false;
            crocodile.Camouflage = false;
            crocodile.Motion = "crawling";
            crocodile.Shell = false;
            crocodile.Poison = false;

            List<Animal> animals = new List<Animal> { penguin, crocodile };

            List<Bird> birds= new List<Bird> { penguin };
            List<Reptile> reptiles = new List<Reptile> { crocodile };

            foreach (var item in animals) {
                Console.WriteLine(item + " Legs: {0}, Fur: {1}, Blood Type: {2}, Nocturnal: {3}", item.Legs, item.Fur, item.BloodTemp, item.Fur, item.Nocturnal);
            }

            foreach (var item in birds)
            {
                Console.WriteLine(item + " Beak Type: {0}, Feather Type: {1}, Flight: {2}, Food: {3}", item.BeakType, item.FeathersType, item.Flight, item.Food);
            }

            foreach (var item in reptiles)
            {
                Console.WriteLine(item + " Camouflage: {0}, Motion: {1}, Shell: {2}, Poison: {3}", item.Camouflage, item.Motion, item.Shell, item.Poison);
            }

        }
    }
}
