using AbstractFactory.ConcreteFactory;
using AbstractFactory.Interface;

namespace AbstractFactory;

class Client
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ConcreteFactory1());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ConcreteFactory2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateAndroid();
        var productB = factory.CreateIphone();

        Console.WriteLine(productB.CreateIphone());
        Console.WriteLine(productB.CollaborationWithAndroid(productA));
    }
}
