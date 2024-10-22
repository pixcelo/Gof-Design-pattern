using GofDesignPattern.AbstractFactory.Abstract;

namespace GofDesignPattern.AbstractFactory
{
    public class ListFactoryService
    {
        public void UseFactory()
        {
            var factory = Factory.GetFactory("GofDesignPattern.AbstractFactory.ListFactory.ListFactory");
            
            if (factory is null)
            {
                return;
            }

            // Blog
            Link blog1 = factory.CreateLink("Blog1", "http://blog1.com");
            Link blog2 = factory.CreateLink("Blog2", "http://blog2.com");
            Link blog3 = factory.CreateLink("Blog3", "http://blog3.com");

            Tray blogTray = factory.CreateTray("Blog Site");
            blogTray.Add(blog1);
            blogTray.Add(blog2);
            blogTray.Add(blog3);

            // News
            Link news1 = factory.CreateLink("News1", "http://news1.com");
            Link news2 = factory.CreateLink("News2", "http://news2.com");
            Tray news3 = factory.CreateTray("News3");
            news3.Add(factory.CreateLink("News3-1", "http://news3-1.com"));
            news3.Add(factory.CreateLink("News3-2", "http://news3-2.com"));

            Tray newsTray = factory.CreateTray("News Site");
            newsTray.Add(news1);
            newsTray.Add(news2);
            newsTray.Add(news3);

            // Page
            Page page = factory.CreatePage("Blog and News", "Tom");
            page.Add(blogTray);
            page.Add(newsTray);

            page.Output("Sample");
        }
    }
}
