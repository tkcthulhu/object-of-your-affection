using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string firstName;
    private string lastName;
    private int age;
    private string city;
    private string state;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string firstName, string lastName, int age, string city, string state, string country, string pronouns = "they/them") 
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
      this.city = city;
      this.state = state;
      this.country = country;
      this.pronouns = pronouns;
      
    }    

    public string ViewProfile()
    {
      string hobbiesList = "My hobbies are ";

      foreach (string hobby in hobbies)
      {
        hobbiesList = $"{hobbiesList}\n{hobby}";
      }

      string profileInfo = $"{firstName} {lastName} {age}\n{city} {state} {country}\n{pronouns}\n{hobbiesList}";

      return profileInfo;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
