using System;

namespace Task3b_oop
{
    class Rap : HipHop
    {
        private string _rapSounds;

        public Rap(string newAuthor, string newTitle) 
            : base(newAuthor, newTitle)
        {
            _rapSounds = "Yoyoyo this is rap ~~";
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(this._rapSounds);

        }
    }
}
