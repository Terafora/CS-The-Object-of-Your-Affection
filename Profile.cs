using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
    }

    public string ViewProfile()
    {
      string info = $"name = {name}\nage = {age}\ncity = {city}\ncountry = {country}\npronouns = {pronouns}";
        info += $"\nhobbies = ";
        foreach (string hobby in hobbies)
        {
          info += $"{hobby}";
        }
      
      if (age >= 18)
      {
        return info;
      }
      else
      {
        return "This information is not available.";
      }
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }

  }
}
