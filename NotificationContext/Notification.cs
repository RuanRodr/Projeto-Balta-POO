namespace Projeto.NotificationContext;

public sealed class Notification
{
    public Notification(string property, string message)
    {
        Property = property;
        Message = message;
    }

    public Notification()
    {
        
    }
    
    public string Property { get; set; }

    public string Message { get; set; }

   
}