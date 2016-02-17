using System.Collections.Generic;
using Xunit;
namespace RPS.Objects
{
  public class RPSTest
  {
   [Fact]
   public void testRPSWinner_RockRock_Draw()
   {
     RPSGame newRPSGame = new RPSGame("rock", "rock");
     Assert.Equal(newRPSGame.RPSWinner(), "draw");
   }
   [Fact]
   public void testRPSWinner_RockPaper_Player2()
   {
     RPSGame newRPSGame = new RPSGame("rock", "paper");
     Assert.Equal(newRPSGame.RPSWinner(), "player 2");
   }
   [Fact]
   public void testRPSWinner_RockPaper_Player1()
   {
     RPSGame newRPSGame = new RPSGame("rock", "scissors");
     Assert.Equal(newRPSGame.RPSWinner(), "player 1");
   }
 }

}
