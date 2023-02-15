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
    private string type;
    private string name;
    private ConsoleColor color;
    private double weight;
    private bool isReleased;

    public Animal(int age, string type, string name, ConsoleColor color, double weight, bool isReleased)
    {
      this.age = age;
      this.type = type;
      this.name = name;
      this.color = color;
      this.weight = weight;
      this.isReleased = isReleased;
    }

    public int GetAge()
    {
      return age;
    }
    public void SetAge(int value)
    {
      age = value;
    }

    public string GetType()
    {
      return type;
    }
    public void SetType(string value)
    {
      type = value;
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
  }
}
