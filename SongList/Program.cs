using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList
{
    class Song
    {
        public String TypeList { get; set; }
        public String Name { get; set; }
        public String Time { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i<numSongs; i++)
            {
                String[] data = Console.ReadLine().Split('_');

                String type = data[0];
                String name = data[1];
                String time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typelist = Console.ReadLine();
            Console.WriteLine("***********ĐÂY LÀ DANH SÁCH NHẠC***********");
            if(typelist == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typelist)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
