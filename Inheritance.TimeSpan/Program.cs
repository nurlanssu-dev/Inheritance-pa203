namespace Inheritance.TimeSpan;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Neçə kitab daxil edəcəksiniz: ");
        int count = int.Parse(Console.ReadLine());
        Book[] books = new Book[count];
        for (int i = 0; i < books.Length; i++)
        {
            Console.Write("Kitabin adi: ");
            string name = Console.ReadLine();

            Console.Write("Kitabin qiymeti: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Kitabın sayı: ");
            int bookCount = int.Parse(Console.ReadLine());

            Console.Write("Kitabin janri: ");
            string genre = Console.ReadLine();

            Book book = new Book(name, price, genre);
            book.Count = bookCount;
            books[i] = book;
        }
        while (true)
        {
            Console.WriteLine("1. Kitabları qiymətə görə filterlə");
            Console.WriteLine("2. Bütün kitabları göstər");
            Console.WriteLine("0. Proqramı bağla");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Qiymət aralığını daxil edin (məsələn: 10-50): ");
                    string[] range = Console.ReadLine().Split('-');
                    decimal minPrice = decimal.Parse(range[0]);
                    decimal maxPrice = decimal.Parse(range[1]);
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].Price >= minPrice && books[i].Price <= maxPrice)
                        {
                            Console.WriteLine($"Ad: {books[i].Name}, Qiymət: {books[i].Price}, Janr: {books[i].Genre}, Say: {books[i].Count}");
                        }
                    }
                    break;
                case 2:
                    foreach (var book in books)
                    {
                        Console.WriteLine($"Ad: {book.Name}, Qiymət: {book.Price}, Janr: {book.Genre}, Say: {book.Count}");
                    }
                    break;
                case 0:
                    return;
            }
        }
    }
}