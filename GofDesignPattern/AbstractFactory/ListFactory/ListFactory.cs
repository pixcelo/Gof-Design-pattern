﻿using GofDesignPattern.AbstractFactory.Abstract;

namespace GofDesignPattern.AbstractFactory.ListFactory
{
    public class ListFactory : Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Tray CreateTray(string caption)
        {
            return new ListTray(caption);
        }

        public override Page CreatePage(string title, string author)
        {
            return new ListPage(title, author);
        }
    }
}
