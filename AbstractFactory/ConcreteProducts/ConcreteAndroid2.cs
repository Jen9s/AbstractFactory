using AbstractFactory.Interface;

namespace AbstractFactory.ConcretProducts;

public class ConcreteAndroid2 : IAbstractAndroid
{
    public string CreateAndroid()
    {
        return "The result of the product Android2.";
    }
}