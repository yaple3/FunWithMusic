namespace music
{
    class Program
    {
        enum Genre
        {
            Pop,//action = pop
            Country,//horror = country
            Rock,//scifi = rock
            Classical,//romcom = classical
            Jazz//drama = jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite music?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("A - pop\nH - country\nS - rock\nR - classical\nD - jazz");
            Genre tempGenre = Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'A':
                    tempGenre = Genre.Pop;
                    break;
                case 'H':
                    tempGenre = Genre.Country;
                    break;
                case 'S':
                    tempGenre = Genre.Rock;
                    break;
                case 'R':
                    tempGenre = Genre.Classical;
                    break;
                case 'D':
                    tempGenre = Genre.Jazz;
                    break;
            }
            //creating the first music structure variable:
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");

            //copying the structure variable:
            Music moreMusic = music;

            //changing values in the new structure variable:
            moreMusic.setTitle("Prop Me Up Beside the Jukebox (If I Die)");
            moreMusic.setLength("3:46");

            //printing the new music info:
            Console.WriteLine("Here is the info for music #2");
            Console.WriteLine($"{moreMusic.Display()}");
            Console.WriteLine();

            //printing the original music info:
            Console.WriteLine("Here is the info for music #1");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine();

        }
    }
}

