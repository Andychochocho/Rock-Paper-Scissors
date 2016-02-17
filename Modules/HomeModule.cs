using Nancy;
using RPS.Objects;
using System.Collections.Generic;

namespace RPS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ =>
      {
        string output;
        RPSGame newRPSGame = new RPSGame(Request.Form["player1"], Request.Form["player2"]);
        output = newRPSGame.RPSWinner();
        return View["output.cshtml", output];
      };
    }
  }
}
