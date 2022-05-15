using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.\n");

      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("Type YES or NO: ");
      string noiseChoise = Console.ReadLine();
      noiseChoise = noiseChoise.ToUpper();

      if(noiseChoise == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room\n\n--THE END--");
      } else if(noiseChoise == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
        Console.Write("Type OPEN or KNOCK: ");
        string doorChoise = Console.ReadLine();
        doorChoise = doorChoise.ToUpper();

        if(doorChoise == "KNOCK") {
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
          Console.Write("Your answer: ");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();
          if(riddleAnswer == "NOTHING") {
            Console.WriteLine($"The door opens and {riddleAnswer} is there.\nYou turn off the light and run back to your room and lock the door.\n\n--THE END--");
          } else {
            Console.WriteLine("You answered incorrectly. The door doesn't open.\n\n--THE END--");
          }
        } else if(doorChoise == "OPEN") {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.Write("Enter a Keynumber (e.g: 2): ");
          int keyChoise = Convert.ToInt32(Console.ReadLine());
          switch(keyChoise) {
            case 1:
            Console.WriteLine("You choose the first key. Lucky choise!");
            Console.WriteLine("The door opens and NOTHING is there. Strange....");
            Console.WriteLine("--THE END--");
            break;
            case 2:
            Console.WriteLine("You choose the secound key. The door doesn't open.");
            Console.WriteLine("--THE END--");
            break;
            case 3:
            Console.WriteLine("You choose the third key. The door doesn't open.");
            Console.WriteLine("--THE END--");
            break;
            default:
            Console.WriteLine("You choose the wrong or an invalid key. The door doesn't open.");
            Console.WriteLine("--THE END--");
            break;
          }
        }
      }

     
    }
  }
}