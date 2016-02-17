using System.Collections.Generic;
using System;

namespace RPS.Objects
{
  public class RPSGame
  {
    private string _choice1;
    private string _choice2;

    public RPSGame(string choice1, string choice2)
    {
      _choice1 = choice1;
      _choice2 = choice2;
    }

    public string GetChoice1()
    {
      return _choice1;
    }

    public string GetChoice2()
    {
      return _choice2;
    }

    public string RPSWinner()
    {
      if (this.GetChoice1() == this.GetChoice2())
      {
        return "draw";
      }
      else if( (this.GetChoice1() == "rock" && this.GetChoice2() == "scissors")
              || (this.GetChoice1() == "scissors" && this.GetChoice2() == "paper")
              || (this.GetChoice1() == "paper" && this.GetChoice2() == "rock")
              )
      {
        return "player 1";
      }
      else
      {
        return "player 2";
      }
    }
  }
}
