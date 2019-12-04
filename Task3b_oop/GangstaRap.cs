using System;

namespace Task3b_oop
{
    class GangstaRap : UndergroundRap
    {
        private string gangstaRapSounds;

        public GangstaRap(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.gangstaRapSounds = "this is gangsta paradise yo ";
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(this.gangstaRapSounds);
        }

    }
}
