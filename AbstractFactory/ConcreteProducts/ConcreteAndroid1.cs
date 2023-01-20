using AbstractFactory.Interface;

namespace AbstractFactory.ConcretProducts;

class ConcreteAndroid1 : IAbstractAndroid
{
    public string CreateAndroid()
    {
        return "The result of the product Android1.";
    }
}