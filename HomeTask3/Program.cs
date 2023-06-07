namespace HomeTask3
{
    internal class Program
    {
        /*
         Завдання 3 

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
        Потрібно: Створити клас Book. Створити класи Title, Author та Content, кожен з яких повинен містити одне рядкове поле та метод void Show(). 
        Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.
         
         */

        class Book
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            public Book(string title, string author, string content)
            {
                this.title.TitleProp = title;
                this.author.AuthorProp = author;
                this.content.ContentProp = content;
            }

            public void Show()
            {
                Console.WriteLine("Book: ");
                title.Show();
                author.Show();
                content.Show();
            }
        }

        class Title
        {
            private string title = "";

            public string TitleProp
            {
                get { return title; }
                set { title = value; }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Title: " + title);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        class Author
        {
            private string author = "";

            public string AuthorProp
            {
                get { return author; }
                set { author = value; }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Author: " + author);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        class Content
        {
            private string content = "";

            public string ContentProp
            {
                get { return content; }
                set { content = value; }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Content: " + content);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input your book information: ");
            Console.Write("Book's title: ");
            string title = Console.ReadLine();
            Console.Write("Book's author: ");
            string author = Console.ReadLine();
            Console.Write("Book's content: ");
            string content = Console.ReadLine();
            Book book = new Book(title, author, content);
            book.Show();
        }
    }
}