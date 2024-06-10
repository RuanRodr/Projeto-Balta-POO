using Projeto.NotificationContext;

namespace Projeto.ContentContext
{

    public class Article : Content
    {
        public Article(string title, string url) 
            :base(title, url)
        {
            
        }
    }
}