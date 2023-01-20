using AbstractFactory.ConcretProducts;
using AbstractFactory.Interface;

namespace AbstractFactory.ConcreteFactory;

class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractAndroid CreateAndroid()
    {
        return new ConcreteAndroid2();
    }

    public IAbstractIphone CreateIphone()
    {
        return new ConcreteIphone2();
    }
}