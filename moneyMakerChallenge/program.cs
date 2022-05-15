using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Initialize variables which we need
      int gCoin = 10;
      int sCoin = 5;
      int bCoin = 1;
      decimal userGcoins = 0m;
      decimal userScoins = 0m;
      decimal userBcoins = 0m;
      decimal userCents = 0m;
      decimal restValue = 0m;

      // Welcome User and ask directly for cents input
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine();      
      Console.Write("Amount of cents to convert into coins: ");
      // Retrieve input and directly convert!
      userCents = Math.Floor(Convert.ToDecimal(Console.ReadLine()));
      Console.WriteLine($"{userCents} cents (rounded) is equal to...");

      // Let's start calculating!
      userGcoins = Math.Floor(userCents / gCoin);
      restValue = userCents % gCoin;
      if(restValue > 0) {
        userScoins = Math.Floor(restValue / sCoin);
        userBcoins = userScoins % gCoin;
        }
      Console.WriteLine($"{userGcoins} Gold coins\n{userScoins} Silver coins\n{userBcoins} Bronze coins\n");


    }
  }
}
