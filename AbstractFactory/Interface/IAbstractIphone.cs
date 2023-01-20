namespace AbstractFactory.Interface;

public interface IAbstractIphone
{
    string CreateIphone();
        
    string CollaborationWithAndroid(IAbstractAndroid collaborator);
    
}