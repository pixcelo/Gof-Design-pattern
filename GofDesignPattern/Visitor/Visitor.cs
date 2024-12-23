﻿namespace GofDesignPattern.Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(File file);

        public abstract void Visit(Directory directory);
    }
}
