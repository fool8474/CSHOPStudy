using System;
namespace CShop
{
    class Book
    {
        string title;
        decimal isbn13;
        string author;
        static int count;

        public Book(string title, decimal isbn13, string author)
        {
            this.title = title;
            this.isbn13 = isbn13;
            this.author = author;
            Increment();
            Open();
        }

        public Book(string title) : this(title, 0)
        {

        }

        public Book(string title, decimal isbn13) : this(title, isbn13, string.Empty)
        {

        }

        public Book() : this(string.Empty, 0, string.Empty)
        {

        }

        // this를 통해 또 다른 생성자를 호출

        public void Close()
        {
            Console.WriteLine(title + " 책을 덮는다.");
        }
        void Open()
        {
            Console.WriteLine(title);
            Console.WriteLine(count);
        }


        static void Increment()
        {
            count++; // 정적 필드 사용 가능
                     // 정적 메서드에는 thist가 없으므로 인스턴스 맴버 사용 불가능
        }
    }

    class _4_04_useThis
    {
        public _4_04_useThis()
        {
            Book book = new Book("");
            book.Close();

            Book book_2 = new Book("hello World");
            book_2.Close();
        }

    }
}
