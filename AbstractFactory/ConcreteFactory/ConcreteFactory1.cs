using AbstractFactory.ConcretProducts;
using AbstractFactory.Interface;

namespace AbstractFactory.ConcreteFactory;

class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractAndroid CreateAndroid()
    {
        return new ConcreteAndroid1();
    }

    public IAbstractIphone CreateIphone()
    {
        return new ConcreteIphone1();
    }
}