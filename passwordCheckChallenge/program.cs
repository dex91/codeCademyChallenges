using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      /*
      * Declare all needed variables for our password check
      */
      int minLength = 8;
      int score = 0;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTVWXYZ";
      string lowercase = "abcdefghijklmnopqrstvwxyz";
      string digits = "1234567890";
      string specialChars = "#?!_*.-";
      string userInput = "";

      /*
      * Inform user about the things we gonna do :D
      */
      Console.WriteLine("Welcome to the password-check!");      

      /*
      * Get user input
      */
      Console.Write("Specify a password: ");
      userInput = Console.ReadLine();

      /*
      * Check requirements....
      */
      if(userInput.Length >= minLength) {
        score++;
      }

      if(Tools.Contains(uppercase, userInput)) {
        score++;
      }

      if(Tools.Contains(lowercase, userInput)) {
        score++;
      }

      if(Tools.Contains(digits, userInput)) {
        score++;
      } 

      if(Tools.Contains(specialChars, userInput)) {
        score++;
      }

      /*
      * At least check if password matches some standarts
      * you shouldn't use at all!
      */
      if(userInput == "password" || userInput == "1234") {
        score = 0;
      } 

      /*
      * Output the securetylevel of the userInput password.
      * Each "score" has his strength!
      */
      switch(score) {
        case 1:
        Console.WriteLine("The given password is too weak!");
        break;
        case 2:
        Console.WriteLine("The given password has an medium strength.");
        break;
        case 3:
        Console.WriteLine("The given password has an strong strength!");
        break;
        case 4:
        case 5:
        Console.WriteLine("The given password has an extremly strong strength!");
        break;
        default:
        Console.WriteLine("The password doesn't meet the standart requirements!");
        break;                
      }

    }
  }
}