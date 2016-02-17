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

        return View["output.cshtml"];
      };
    }
  }
}
