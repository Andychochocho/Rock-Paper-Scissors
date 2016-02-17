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

 }

}
