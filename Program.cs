using System;

public class Book:IComparable<Book> // Класс Book с закрытыми полями для автора, названия, количества страниц и года издания.
{
    private string author;
    private string title;
    private int pages;
    private int year;
    
    public void SetBook(string author, string title, int pages, int year) //SetBook устанавливает значения полей
    {
        this.author = author;
        this.title = title;
        this.pages = pages;
        this.year = year;
    }

    public void Show() // Выводит информацию о книге на консоль
    {
        Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
    }

    public int CompareTo(Book other) //  Реализация IComparable<Book>
    {
        if (other == null) return 1; // Текущая книга "больше" null
        return this.year.CompareTo(other.year); // Использую встроенное сравнение для int
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Book[] books = new Book[3];

        books[0] = new Book();
        books[0].SetBook("Толстой Л.Н.", "Война и мир", 1225, 1869);

        books[1] = new Book();
        books[1].SetBook("Достоевский Ф.М.", "Преступление и наказание", 600, 1866);

        books[2] = new Book();
        books[2].SetBook("Пушкн А.С", "Евгений Онегин", 400, 1833);

        Array.Sort(books);

        Console.WriteLine("Отсортированный список книг:");
        foreach (Book book in books)
        {
            book.Show();
        }

    }
}