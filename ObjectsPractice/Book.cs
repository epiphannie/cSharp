using System;
namespace Treehouse.MediaLibrary
{
    public class Book : MediaType
    {
        public readonly string Author;

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            if (OnLoan && Loanee != null)
            {
                return "Book: " + Title + " by " + Author + " (Currently on loan to " + Loanee + ").";
            }
            else if (OnLoan && Loanee == null)
            {
                return "Book: " + Title + " by " + Author + " (Currently on loan).";
            }
            else
            {
                return "Book: " + Title + " by " + Author + " (Not on loan).";
            }
        }

    }
}
