using System;


namespace Task3b_oop
{
    abstract class Song
    {
        protected string Author { get; private set; }
        protected string Title { get; private set; }

        public Song(string newAuthor, string newTitle)
        {
            this.Author = newAuthor;
            this.Title = newTitle;
        }

        public virtual void Play()
        {
            Console.WriteLine("The author of this song is "+ this.Author + " and title is " + this.Title );
        }
    }
}
