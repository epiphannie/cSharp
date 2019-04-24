using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                Book book = new Book("The Bible", "Prophets");
                Movie movie = new Movie("Terminator", 120);

                DetectMediaType(book);
                DetectMediaType(movie);

                Book testBook = new Book("", "Ann");

                //movie.Loan("Susan");

                //Console.WriteLine(movie.GetDisplayText());

                //book.Return();

                //Console.WriteLine(book.GetDisplayText());

                //book.Loan();

                //Console.WriteLine(book.GetDisplayText());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DetectMediaType(MediaType item)
        {
            if (item is Book)
            {
                Console.WriteLine(item.Title + " is a Book");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }

        }

    }
}
