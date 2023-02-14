namespace ConsoleObjectsSongsAnAnimals
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SongPorogram();
    }

    static void SongPorogram()
    {
      string[] strings = { "Gogo", "Guy", "Ziv", "Vienna", "Ten Times", "Aminem", "Mitgagea",
            "Suiii","James","Elain","Obema","Lazy","Lame","Tahel","Tal",
            "Nisim","Yariv","Jerry","Trump","Greg","Pingi","Nir",};

      Random rnd = new Random();
      Song[] songs = new Song[10];
      for (int i = 0; i < songs.Length; i++)
      {
        Song s = new Song(strings[rnd.Next(0, 21)], rnd.Next(50, 250), strings[rnd.Next(0, 21)]);
        songs[i] = s;
      }
      Console.WriteLine(AverageSongLength(songs));
    }

    static double AverageSongLength(Song[] sss)
    {
      double sum = 0;
      foreach (var s in sss)
        sum += s.GetLength();
      return sum / sss.Length;
    }
  }
}