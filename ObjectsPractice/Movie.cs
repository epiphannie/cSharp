using System;
namespace Treehouse.MediaLibrary
{
    public class Movie : MediaType
    {
        public readonly int Length;

        public Movie(string title, int length) : base(title)
        {
            Length = length;
        }

        public string GetDisplayText()
        {
            if (OnLoan && Loanee != null)
            {
                return "Movie: " + Title + ", length of " + Length + " minutes, (Currently on loan to " + Loanee + ").";
            }
            else if (OnLoan && Loanee == null)
            {
                return "Movie: " + Title + " length of " + Length + " minutes, (Currently on loan).";
            }
            else
            {
                return "Movie: " + Title + " length of " + Length + " minutes (Not on loan).";
            }
        }
    }
}
