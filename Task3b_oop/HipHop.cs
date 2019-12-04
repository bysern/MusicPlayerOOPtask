using System;

namespace Task3b_oop
{
    class HipHop : Song
    {
        private string _hipHopSounds;

        public HipHop(string newAuthor, string newTitle) : base(newAuthor, newTitle)
        {
            _hipHopSounds = "hip hoop hop ~~~~";
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(_hipHopSounds);
        }
    }
}
