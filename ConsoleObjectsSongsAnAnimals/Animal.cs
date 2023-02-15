using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjectsSongsAnAnimals
{
  internal class Animal
  {
    private int age;
    private string specimen;
    private string name;
    private ConsoleColor color;
    private double weight;
    private bool isReleased;

    private static Random rnd = new Random();
    private static string[] names = { "James", "Leo", "Jen", "Boots", "Klumi", "Gofer", "Bill", "Trump", "Obama" };
    private static ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Black, ConsoleColor.White };
    private static string[] sugim = { "Cat", "Dog", "Fish", "Giraph",
      "Elephant", "Monkey", "Deer", "Parrot","Lion","Eagle",
      "Kangeroo","Bird","Gorilla","Dolphin","Pinguin","Bear","Horse","Otter","Snake","Turtle" };
    public Animal(int age, string specimen, string name, ConsoleColor color, double weight, bool isReleased)
    {
      this.age = age;
      this.specimen = specimen;
      this.name = name;
      this.color = color;
      this.weight = weight;
      this.isReleased = isReleased;
    }

    /// <summary>
    /// פעולה בונה מעתיקה
    /// באמצעות קריאה לבנאי הקיים והעברת ערכי הערכים
    /// </summary>
    /// <param name="other"></param>
    public Animal(Animal other) : this(other.age, other.specimen, other.name, other.color, other.weight, other.isReleased)
    {

    }

    public int GetAge()
    {
      return age;
    }
    public void SetAge(int value)
    {
      age = value;
    }

    public string GetSpecimen()
    {
      return specimen;
    }
    public void SetType(string value)
    {
      specimen = value;
    }

    public string GetName()
    {
      return name;
    }
    public void SetName(string value)
    {
      name = value;
    }

    public ConsoleColor GetColor()
    {
      return color;
    }
    public void SetColor(ConsoleColor value)
    {
      color = value;
    }

    public double GetWeight()
    {
      return weight;
    }
    public void SetWeight(double value)
    {
      weight = value;
    }

    public bool GetIsReleased()
    {
      return isReleased;
    }
    public void SetIsReleased(bool value)
    {
      isReleased = value;
    }
    /// <summary>
    /// generate a random animal ouf of a selection of names, types, and colors.
    /// </summary>
    /// <returns></returns>
    static public Animal CreateRandomAnimal()
    {
      return new Animal(rnd.Next(30), sugim[rnd.Next(sugim.Length)],
          names[rnd.Next(names.Length)], colors[rnd.Next(colors.Length)], Math.Round(rnd.NextDouble() * 100, 1), rnd.Next(2) == 1);
    }

    
  }
}
