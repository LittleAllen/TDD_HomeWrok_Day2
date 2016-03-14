using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStoreService
{
    public class HarryPotterService
    {
        public object CalculatePrice(List<HarryPortterBook> books)
        {
            var totalPrice = 0;

            var groupBooksList = this.GetDiscountGroup(books);

            //// 統計各組的金額
            foreach (var groupBooks in groupBooksList)
            {
                var groupTotalPrice = groupBooks.Sum(x => x.Price);
                var discount = this.GetDiscount(groupBooks.Count());
                totalPrice += (int)(groupTotalPrice * discount);
            }

            return totalPrice;
        }

        /// <summary>
        /// 取得折扣群組
        /// </summary>
        /// <param name="books">哈利波特購買清單</param>
        /// <returns>折扣群組</returns>
        private List<List<HarryPortterBook>> GetDiscountGroup(List<HarryPortterBook> books)
        {
            var groupBooksList = new List<List<HarryPortterBook>>();

            //// 將小說分組, 不同集數的為一組
            foreach (var book in books)
            {
                if (groupBooksList.Count == 0)
                {
                    groupBooksList.Add(new List<HarryPortterBook>());
                }

                //// 是否有分到組
                bool hasGroup = false;
                foreach (var item in groupBooksList)
                {
                    if (item.Exists(x => x.Name == book.Name) == false)
                    {
                        item.Add(book);
                        hasGroup = true;
                        break;
                    }
                }

                //// 無分到組的自行成立一組
                if (hasGroup == false)
                {
                    groupBooksList.Add(new List<HarryPortterBook> { book });
                }
            }

            return groupBooksList;
        }

        /// <summary>
        /// 取得折扣
        /// </summary>
        /// <param name="discountType">折扣類別</param>
        /// <returns>折扣</returns>
        private double GetDiscount(int discountType)
        {
            double discount = 1;

            switch (discountType)
            {
                case 2:
                    discount = 0.95;
                    break;

                case 3:
                    discount = 0.9;
                    break;

                case 4:
                    discount = 0.8;
                    break;

                case 5:
                    discount = 0.75;
                    break;
            }

            return discount;
        }
    }
}
