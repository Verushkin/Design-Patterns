using Lab2.Abstraction;
using System;
using System.Threading;
namespace Lab2
{

    public class User
    {
        public string Username { get; }
        public bool IsRegistered { get; }
        public bool HasAccessToBooks { get; }

        public User(string username, bool isRegistered, bool hasAccessToBooks)
        {
            Username = username;
            IsRegistered = isRegistered;
            HasAccessToBooks = hasAccessToBooks;
        }
    }

    public interface IBook
    {
        string GetContent();
    }

    public class Book : IBook
    {
        private string _content;

        public Book()
        {
            Console.WriteLine("Загрузка книги из базы данных...");
            Thread.Sleep(2000);
            _content = "Это содержимое книги: 'Проектирование ПО с паттернами'.";
        }

        public string GetContent()
        {
            return _content;
        }
    }

    public class BookProxy : IBook
    {
        private readonly User _user;
        private Book? _realBook;

        public BookProxy(User user)
        {
            _user = user;
        }

        public string GetContent()
        {
            if (!_user.IsRegistered)
            {
                return "Доступ запрещён: пользователь не зарегистрирован.";
            }

            if (!_user.HasAccessToBooks)
            {
                return "Доступ запрещён: нет прав на доступ к книге.";
            }

            if (_realBook == null)
            {
                _realBook = new Book();
            }

            return _realBook.GetContent();
        }
    }

    public class Task3: IExamplePattern

    {
        public void Do()
        {
            var user1 = new User("admin", true, true);
            var user2 = new User("guest", true, false);
            var user3 = new User("anon", false, false);

            IBook book1 = new BookProxy(user1);
            IBook book2 = new BookProxy(user2);
            IBook book3 = new BookProxy(user3);

            Console.WriteLine($"\n{user1.Username} пытается открыть книгу:");
            Console.WriteLine(book1.GetContent());

            Console.WriteLine($"\n{user2.Username} пытается открыть книгу:");
            Console.WriteLine(book2.GetContent());

            Console.WriteLine($"\n{user3.Username} пытается открыть книгу:");
            Console.WriteLine(book3.GetContent());
        }
    }
}
