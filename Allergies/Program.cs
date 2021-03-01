using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Allergies
{
  public class Program
  {
    public static void Main(string[] args)
    {
     var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}

/*

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

*/