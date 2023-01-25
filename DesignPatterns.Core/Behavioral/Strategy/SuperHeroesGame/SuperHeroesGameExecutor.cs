using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.Heroes;
using DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame.SuperPowers;

namespace DesignPatterns.Core.Behavioral.Strategy.SuperHeroesGame;

public static class SuperHeroesGameExecutor
{
  public static void Execute()
  {
    var result = string.Empty;
    var batman = new Batman();
    result = batman.DoHeroStuff();
    Console.WriteLine(result);
    batman.ChangeSuperPower(new WeaveWeb());
    result = batman.DoHeroStuff();
    Console.WriteLine(result);
  }
}
