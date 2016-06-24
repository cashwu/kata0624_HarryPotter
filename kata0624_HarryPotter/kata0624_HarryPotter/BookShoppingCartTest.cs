using NUnit.Framework;
using System.Collections.Generic;

namespace kata0624_HarryPotter
{
    class BookShoppingCartTest
    {
        private BookShoppingCart _bookShoppingCart;
        private Dictionary<string, int> _books;

        [SetUp]
        public void SetUp()
        {
            _bookShoppingCart = new BookShoppingCart();
            _books = new Dictionary<string, int>();
        }

        [Test]
        public void Buy_vol1_1()
        {
            _books.Add("book1", 1);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(100, _bookShoppingCart.GetFee());
        }

        [Test]
        public void Buy_vol1_1_and_vol2_1()
        {
            _books.Add("book1", 1);
            _books.Add("book2", 1);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(190, _bookShoppingCart.GetFee());
        }

        [Test]
        public void Buy_vol1_2_and_vol2_2()
        {
            _books.Add("book1", 2);
            _books.Add("book2", 2);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(380, _bookShoppingCart.GetFee());
        }

        [Test]
        public void Buy_vol1_1_and_vol2_1_and_vol3_1()
        {
            _books.Add("book1", 1);
            _books.Add("book2", 1);
            _books.Add("book3", 1);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(270, _bookShoppingCart.GetFee());
        }

        [Test]
        public void Buy_vol1_2_and_vol2_2_and_vol3_2()
        {
            _books.Add("book1", 2);
            _books.Add("book2", 2);
            _books.Add("book3", 2);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(540, _bookShoppingCart.GetFee());
        }

        [Test]
        public void Buy_vol1_4_and_vol2_3_and_vol3_2()
        {
            _books.Add("book1", 4);
            _books.Add("book2", 3);
            _books.Add("book3", 2);

            _bookShoppingCart.AddBooks(_books);

            Assert.AreEqual(830, _bookShoppingCart.GetFee());
        }
    }
}
