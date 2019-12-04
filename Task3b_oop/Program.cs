using System;
using System.Collections.Generic;

namespace Task3b_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOfQuestions();

            void LoopOfQuestions()
            {
                string Answer;

                Player player = new Player();

                do
                {
                    Console.WriteLine("Input genre of song");
                    string GenreOfSong = Console.ReadLine();

                    Console.WriteLine("Input author of song");
                    string Author = Console.ReadLine();

                    Console.WriteLine("Input title of song");
                    string Title = Console.ReadLine();

                    if (GenreOfSong == "hiphop") { Song h1 = new HipHop(Author, Title); player.AddSong(h1); }
                    else if (GenreOfSong == "rap") { Song r1 = new Rap(Author, Title); player.AddSong(r1); }
                    else if (GenreOfSong == "underground rap") { Song u1 = new UndergroundRap(Author, Title); player.AddSong(u1); }
                    else if (GenreOfSong == "gangsta rap") { Song g1 = new GangstaRap(Author, Title); player.AddSong(g1); }
                    else if (GenreOfSong == "rap rock") { Song rr1 = new RapRock(Author, Title); player.AddSong(rr1); }
                    else Console.WriteLine("try again");

                    Console.WriteLine("Do you want to add another song? \nType yes or no");
                    Answer = Console.ReadLine();

                    if (Answer == "no")
                    {
                        player.PlaylistSongs();
                        break;
                    }
                } while (true);
            }
        }
    }
}
