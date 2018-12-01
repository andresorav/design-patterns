using System;
using System.Collections.Generic;
using FactoryPattern.AnimalFactories;

namespace FactoryPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            PrintAllAnimalsRandomly();
            PrintWildAnimalsRandomly();
            PrintDomesticAnimalsRandomly();
            PrintSimpleAnimals();
        }

        private static void PrintAllAnimalsRandomly()
        {
            var randomAnimalFactory = new RandomAnimalFactory();
            var randomAnimals = CreateAnimals(randomAnimalFactory, 3);

            PrintAnimals("Random animals", randomAnimals);
        }
        
        private static void PrintWildAnimalsRandomly()
        {
            var wildAnimalFactory = new WildRandomAnimalFactory();
            var wildAnimals = CreateAnimals(wildAnimalFactory, 3);

            PrintAnimals("Wild animals", wildAnimals);
        }
        
        private static void PrintDomesticAnimalsRandomly()
        {
            var domesticRandomAnimalFactory = new DomesticRandomAnimalFactory();
            var domesticAnimals = CreateAnimals(domesticRandomAnimalFactory, 3);

            PrintAnimals("Domestic animals", domesticAnimals);
        }

        private static void PrintSimpleAnimals()
        {
            var simpleAnimalFactory = new SimpleAnimalFactory();
            var simpleDog = simpleAnimalFactory.CreateAnimal("Dog");
            var simpleSnake = simpleAnimalFactory.CreateAnimal("Snake");
            
            PrintAnimals("Simple animals", new List<IAnimal>{simpleDog, simpleSnake});
        }

        private static void PrintAnimals(string title, IEnumerable<IAnimal> animals)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("{0}:", title);
            Console.WriteLine("---------------");
            foreach (var animal in animals)
            {
                AnimalSays(animal);
            }
        }

        private static void AnimalSays(IAnimal animal)
        {
            Console.WriteLine("{0} says {1}", animal.GetType().Name, animal.Says());
        }

        private static IEnumerable<IAnimal> CreateAnimals(IAnimalFactory animalFactory, int numberOfAnimalsToCreate)
        {
            var animals = new List<IAnimal>();
            
            for (var i = 0; i < numberOfAnimalsToCreate; i++)
            {
                animals.Add(animalFactory.CreateAnimal());
            }

            return animals;
        }
    }
}