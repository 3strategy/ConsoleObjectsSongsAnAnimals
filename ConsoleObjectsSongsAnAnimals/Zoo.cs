using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjectsSongsAnAnimals
{
  internal class Zoo
  {
    private Animal[] animals;

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
    /// <summary>
    /// fills the zoo to 80% capacity. 
    /// Will replace existing animals...
    /// </summary>
    public void Fill()
    {
      for (int i = 0; i < animals.Length * 0.8; i++)
        animals[i] = Animal.CreateRandomAnimal();
    }
    /// <summary>
    /// searches for the first animal with a matching name and removes it. 
    /// move the remaining elements one index to cancel the hole
    /// </summary>
    /// <param name="name">The name of the animal you want to remove</param>
    /// <returns></returns>
    public bool RemoveAnimalByName(string name)
    {
      for (int i = 0; i < animals.Length; i++)
      {
        if (animals[i] is null) // returns on the first blank cell found.
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
    public bool RemoveAnimalByType(string type)
    {
      for (int i = 0; i < animals.Length; i++)
      {
        if (animals[i] is null) // returns on the first blank cell found.
          return false;
        if (animals[i].GetSpecimen() == type)
        {
          for (int j = i; j < animals.Length - 1; j++)
            animals[j] = animals[j + 1];
          animals[^1] = null; //empty the last element.
          return true;
        }
      }
      return false;
    }
    /// <summary>
    /// returns the first matching animal (same name)
    /// returns null if nothing was found
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Animal? GetAnimalByName(string name)
    {
      foreach (var a in animals)
        if (a is not null && a.GetName() == name)
          return a;
      return null;
    }

    public Animal? GetOrCreateByName(string name)
    {
      Animal a = GetAnimalByName(name);
      if (a is not null)
        return a;
      else
      {
        a = Animal.CreateRandomAnimal();
        a.SetName(name);
        if (AddAnimal(a))
          return a;
        else return null;
      }
    }
    /// <summary>
    /// counts the number of animals of the give specimen
    /// </summary>
    /// <param name="specimen"></param>
    /// <returns></returns>
    public int CountAnimals(string specimen)
    {
      int count = 0;
      foreach (var a in animals)
        if (a is not null && a.GetSpecimen() == specimen)
          count++;
      return count;
    }
    /// <summary>
    /// counts the free animals in the zoo
    /// </summary>
    /// <returns></returns>
    public int CountFreeAnimals()
    {
      int count = 0;
      foreach (var a in animals)
        if (a is not null && a.GetIsReleased())
          count++;
      return count;
    }
    /// <summary>
    /// will return the max age in the zoo
    /// if the zoo is empty, it will return int.MinValue;
    /// if the zoo has "holes" it will return max age till the first hole.
    /// </summary>
    /// <returns></returns>
    public int GetMaxAge()
    {
      int max = int.MinValue;
      foreach (var a in animals)
      {
        if (a is null) // טיפול חלקי בחורים
          return max;
        if (a.GetAge() > max) // here we know it's not null
          max = a.GetAge();
      }
      return max;
    }
    /// <summary>
    /// will return the minimal age in the zoo
    /// if the zoo is empty it will return int.MinValue
    /// can handle "holes" in the zoo.
    /// </summary>
    /// <returns></returns>
    public int GetMinAge()
    {
      int min = int.MaxValue;
      foreach (var a in animals)
        if (a is not null && a.GetAge() < min) // here we know it's not null
          min = a.GetAge();
      return min;
    }
    /// <summary>
    /// a unility to create a hole in the array for testing null ref exceptions
    /// </summary>
    public void Clear5() => animals[5] = null;

    /// <summary>
    /// returns average age in the zoo...
    /// </summary>
    /// <returns></returns>
    public double GetAverage()
    {
      double sum = 0;
      double count = 0;
      foreach (var a in animals)
        if (a is not null)
        {
          sum += a.GetAge();
          count++;
        }
      return sum / count;
    }
  }
}
