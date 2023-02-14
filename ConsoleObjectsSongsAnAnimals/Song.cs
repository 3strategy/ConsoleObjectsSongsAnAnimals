using ConsoleObjectsSongsAnAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjectsSongsAnAnimals
{
  public class Song
  {
    private string name;
    private string singer;
    private int length;

    public Song(string name, int length, string singer)
    {
      this.name = name;
      this.length = length;
      this.singer = singer;
    }

    public string GetName()
    {
      return name;
    }
    public void SetName(string value)
    {
      name = value;
    }


    public string GetSinger()
    {
      return singer;
    }
    public void SetSinger(string value)
    {
      singer = value;
    }

    public int GetLength()
    {
      return length;
    }
    public void SetLength(int value)
    {
      length = value;
    }
  }

}




