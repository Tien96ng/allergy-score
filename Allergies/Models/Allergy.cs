using System;
using System.Collections.Generic;


namespace Allergies.Models
{
  public class AllergyScore
  {


    public string GetAllergyScore(int score)
    {
      if (score < 1)
      {
        return string.Empty;
      }
      else if (score > 255)
      {
        return "error: please enter valid number less than 256.";
      }
      else if (score >= 128)
      {
        return "cats " + GetAllergyScore(score - 128);
      }
      else if (score >= 64)
      {
        return "pollen " + GetAllergyScore(score - 64);
      }
      else if (score >= 32)
      {
        return "chocolate " + GetAllergyScore(score - 32);
      }
      else if (score >= 16)
      {
        return "tomatoes " + GetAllergyScore(score - 16);
      }
      else if (score >= 8)
      {
        return "strawberries " + GetAllergyScore(score - 8);
      }
      else if (score >= 4)
      {
        return "shellfish " + GetAllergyScore(score - 4);
      }
      else if (score >= 2)
      {
        return "peanuts " + GetAllergyScore(score - 2);
      }
      else
      {
        return "eggs.";
      }
    }
  }
}