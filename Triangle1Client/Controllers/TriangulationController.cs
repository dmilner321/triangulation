using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Triangle1Client.Controllers
{
    [Produces("application/json")]
    [Route("api/Triangulation")]
    public class TriangulationController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Triangle> GetTriangle(string gridlocation)
        {
            Triangle tri1 = (gridlocation == null) ? null : Triangle.GetTriangle(gridlocation);
            yield return tri1;
        }
    }
}