using AbstractFactory.Interface;

namespace AbstractFactory.ConcretProducts;

class ConcreteIphone1 : IAbstractIphone
{
    public string CreateIphone()
    {
        return "The result of the product Iphone1.";
    }

    public string CollaborationWithAndroid(IAbstractAndroid collaborator)
    {
        var result = collaborator.CreateAndroid();

        return $"The result of the Iphone1 collaborating with the ({result})";
    }
}