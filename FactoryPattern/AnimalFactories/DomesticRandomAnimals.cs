using System.Collections.Generic;

namespace FactoryPattern.AnimalFactories
{
    public class DomesticRandomAnimalFactory : RandomAnimalFactory
    {
        public DomesticRandomAnimalFactory()
        {
            AnimalList = new List<string>
            {
                "Cat",
                "Dog",
                "Duck",
                "Sheep"
            };
        }
    }
}