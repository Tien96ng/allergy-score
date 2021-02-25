using System;
using Allergies.Models;
using System.Collections.Generic;

namespace AllergyChecker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter your allergy score to find out what you are allergic to: ");
      string userInput = Console.ReadLine();
      int userScore = int.Parse(userInput);

      AllergyScore allergy = new AllergyScore();
      Console.WriteLine(allergy.GetAllergyScore(userScore));
      if (allergy.GetAllergyScore(userScore) == "error: please enter valid number less than 256.")
      {
        Main();
      }
    }
  }
}