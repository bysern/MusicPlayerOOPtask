using System;

namespace Task3b_oop
{
    class UndergroundRap : Rap
    {
        private string UndergroundRapSounds;

        public UndergroundRap(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            UndergroundRapSounds = "This is coming from underground yo ";
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(this.UndergroundRapSounds);
        }
    }
}
