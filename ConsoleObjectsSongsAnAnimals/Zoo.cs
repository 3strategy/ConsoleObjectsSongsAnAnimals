using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjectsSongsAnAnimals
{
  internal class Zoo
  {
    private Animal[] animals;
    private Random rnd = new Random();
    private string[] names = {"James","Leo","Jen","Boots","Klumi","Gofer","Bill","Trump","Obama"};
    private ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Black, ConsoleColor.White };
    private string[] types = { "Cat", "Dog", "Fish", "Giraph", 
      "Elephant", "Monkey", "Deer", "Parrot","Lion","Eagle",
      "Kangeroo","Bird","Gorilla","Dolphin","Pinguin","Bear","Horse","Otter","Snake","Turtle" };
    public Zoo(int numOfAnimals)
    {
      animals = new Animal[numOfAnimals];
    }

    public bool AddAnimal(Animal a)
    {
      for (int i = 0; i < animals.Length; i++)
        if (animals[i] is null)
        {
          animals[i] = a;
          return true;
        }

      return false;
    }

    public void Fill()
    {
      for (int i = 0; i < animals.Length*0.8; i++)
        animals[i] = new Animal(rnd.Next(30), types[rnd.Next(types.Length)],
          names[rnd.Next(names.Length)], colors[rnd.Next(colors.Length)], rnd.NextDouble() * 100, rnd.Next(1) == 1);
    }
    public bool RemoveAnimalByName(string name)
    {
      for (int i = 0; i < animals.Length; i++)
      {
        if (animals[i] is null)
          return false;
        if (animals[i].GetName() == name)
        {
          for (int j = i; j < animals.Length - 1; j++)
            animals[j] = animals[j + 1];
          animals[^1] = null; //empty the last element.
          return true;
        }
      }
      return false;
    }
  }
}
