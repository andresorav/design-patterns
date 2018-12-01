namespace FactoryPattern
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string animal = null);
    }
}