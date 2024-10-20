﻿using GofDesignPattern.TemplateMethod;

namespace GofDesignPattern.Tests.TemplateMethod
{
    public class StringDisplayTests
    {
        /// <summary>
        /// 抽象クラスの型に代入して、正しく動作するようにする（リスコフの置換原則）
        /// </summary>
        [Fact]
        public void OkDisplay()
        {
            // Arrange
            AbstractDisplay stringDisplay = new StringDisplay("Hello, world.");

            // Act
            stringDisplay.Display();

            /*
                +-------------+
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                +-------------+
            */
        }
    }
}
