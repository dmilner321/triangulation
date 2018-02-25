using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    interface ITriangle
    {
        string GridLocation { get; set; }
        int v1x { get; set; }
        int v1y { get; set; }
        int v2x { get; set; }
        int v2y { get; set; }
        int v3x { get; set; }
        int v3y { get; set; }
        string orientation { get; set; }
    }
}
