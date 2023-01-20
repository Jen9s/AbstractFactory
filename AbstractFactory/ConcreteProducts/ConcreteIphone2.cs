using AbstractFactory.Interface;

namespace AbstractFactory.ConcretProducts;

class ConcreteIphone2 : IAbstractIphone
{
    public string CreateIphone()
    {
        return "The result of the product Iphone2.";
    }

    public string CollaborationWithAndroid(IAbstractAndroid collaborator)
    {
        var result = collaborator.CreateAndroid();

        return $"The result of the Iphone2 collaborating with the ({result})";
    }
}