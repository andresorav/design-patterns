using System;

namespace FactoryPattern.AnimalFactories
{
    public class SimpleAnimalFactory : IAnimalFactory
    {
        public virtual IAnimal CreateAnimal(string animal = null)
        {
            return (IAnimal) Activator.CreateInstance(Type.GetType("FactoryPattern.Animals." + animal));
        }
    }
}