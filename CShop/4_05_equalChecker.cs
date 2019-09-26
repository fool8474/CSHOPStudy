using System;

namespace equalChecker
{
    class Book
    {
        decimal isbn13;
        string title;
        string content;

        public Book(decimal isbn13, string title, string content)
        {
            this.isbn13 = isbn13;
            this.title = title;
            this.content = content;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Book book = obj as Book;

            if(book == null)
            {
                return false;
            }

            return this.isbn13 == book.isbn13;
        }
    }
}

namespace CShop
{
    class _4_05_equalChecker
    {
        public _4_05_equalChecker()
        {
            equalChecker.Book book1 = new equalChecker.Book(9788998139018, "리버스 엔지니어링 바이블", "....");
            equalChecker.Book book2 = new equalChecker.Book(9788998139018, "리버스 엔지니어링 바이블", "....");
            equalChecker.Book book3 = new equalChecker.Book(9788992939409, "파이썬 3.6 프로그래밍", "....");

            Console.WriteLine("book1 == book2: " + book1.Equals(book2));
            Console.WriteLine("book1 == book3: " + book1.Equals(book3));
            
        }
    }
}
