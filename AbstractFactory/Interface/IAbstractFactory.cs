namespace AbstractFactory.Interface;

public interface IAbstractFactory
{
    IAbstractAndroid CreateAndroid();

    IAbstractIphone CreateIphone();
}