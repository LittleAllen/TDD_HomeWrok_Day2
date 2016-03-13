﻿using System;
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
    }
}
