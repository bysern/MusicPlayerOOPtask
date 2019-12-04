using System;

namespace Task3b_oop
{
    class RapRock : Rap
    {
        private string rapRockNewSounds;

        public RapRock(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.rapRockNewSounds = "Rapping ~~~ and rocking yeah  ~~";
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine(this.rapRockNewSounds);
        }
    }
}
