using System.Collections.Generic;

namespace FactoryPattern.AnimalFactories
{
    public class WildRandomAnimalFactory : RandomAnimalFactory
    {
        public WildRandomAnimalFactory()
        {
            AnimalList = new List<string>
            {
                "Bear",
                "Lion",
                "Snake",
                "Elephant"
            };
        }
    }
}