using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreService;

namespace BookStoreServiceTests
{
    [TestClass()]
    public class HarryPotterServiceTests
    {
        [TestMethod()]
        public void 購買哈利波特第一集_價格應該為100()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });

            var target = new HarryPotterService();

            var expected = 100;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 購買哈利波特第一集與第二集各一本_價格應該為190()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });

            var target = new HarryPotterService();

            var expected = 190;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本_價格應該為270()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });

            var target = new HarryPotterService();

            var expected = 270;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四集各買了一本_價格應為320()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第四集", Episode = 4, Price = 100 });

            var target = new HarryPotterService();

            var expected = 320;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四五集各買了一本_價格應為375()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第四集", Episode = 4, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第五集", Episode = 5, Price = 100 });

            var target = new HarryPotterService();

            var expected = 375;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });
            
            var target = new HarryPotterService();

            var expected = 370;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //// Arrange
            var books = new List<HarryPortterBook>();
            books.Add(new HarryPortterBook { Name = "哈利波特第一集", Episode = 1, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第二集", Episode = 2, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });
            books.Add(new HarryPortterBook { Name = "哈利波特第三集", Episode = 3, Price = 100 });

            var target = new HarryPotterService();

            var expected = 460;

            //// Act
            var actual = target.CalculatePrice(books);

            //// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
