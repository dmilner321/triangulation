using System;
using Newtonsoft.Json;

namespace Models
{
    public class Triangle : ITriangle
    {
        public string GridLocation { get; set; }
        public int v1x { get; set; }
        public int v1y { get; set; }
        public int v2x { get; set; }
        public int v2y { get; set; }
        public int v3x { get; set; }
        public int v3y { get; set; }
        public string orientation { get; set; }


        public static Triangle GetTriangle(string gridLocation)
        {
            var tri = new Triangle();   //vertices (0,0) are at F1 triangle base
            tri.GridLocation = gridLocation;
            bool even = false;

            var row = gridLocation.Substring(0, 1).ToUpper();
            int column = int.Parse(gridLocation.Substring(1));
            if (column % 2 == 0)
            {
                even = true;  //triangle 'upside down'
                tri.orientation = "up";
            }
            else { tri.orientation = "down"; }

            switch (row)
            {
                case "A":
                    tri.v1y = 60;
                    tri.v2y = even ? 60 : 50;
                    tri.v3y = 50;
                    break;
                case "B":
                    tri.v1y = 50;
                    tri.v2y = even ? 50 : 40;
                    tri.v3y = 40;
                    break;
                case "C":
                    tri.v1y = 40;
                    tri.v2y = even ? 40 : 30;
                    tri.v3y = 30;
                    break;
                case "D":
                    tri.v1y = 30;
                    tri.v2y = even ? 30 : 20;
                    tri.v3y = 20;
                    break;
                case "E":
                    tri.v1y = 20;
                    tri.v2y = even ? 20 : 10;
                    tri.v3y = 10;
                    break;
                case "F":
                    tri.v1y = 10;
                    tri.v2y = even ? 10 : 0;
                    tri.v3y = 0;
                    break;
                default:
                    tri.v1y = 10;
                    tri.v2y = 0;
                    tri.v3y = 0;
                    break;
            }

            switch (column)
            {
                case 1:
                    tri.v1x = 0;
                    tri.v2x = 0;
                    tri.v3x = 10;
                    break;
                case 2:
                    tri.v1x = 0;
                    tri.v2x = 10;
                    tri.v3x = 10;
                    break;
                case 3:
                    tri.v1x = 10;
                    tri.v2x = 10;
                    tri.v3x = 20;
                    break;
                case 4:
                    tri.v1x = 10;
                    tri.v2x = 20;
                    tri.v3x = 20;
                    break;
                case 5:
                    tri.v1x = 20;
                    tri.v2x = 20;
                    tri.v3x = 30;
                    break;
                case 6:
                    tri.v1x = 20;
                    tri.v2x = 30;
                    tri.v3x = 30;
                    break;
                case 7:
                    tri.v1x = 30;
                    tri.v2x = 30;
                    tri.v3x = 40;
                    break;
                case 8:
                    tri.v1x = 30;
                    tri.v2x = 40;
                    tri.v3x = 40;
                    break;
                case 9:
                    tri.v1x = 40;
                    tri.v2x = 40;
                    tri.v3x = 50;
                    break;
                case 10:
                    tri.v1x = 40;
                    tri.v2x = 50;
                    tri.v3x = 50;
                    break;
                case 11:
                    tri.v1x = 50;
                    tri.v2x = 50;
                    tri.v3x = 60;
                    break;
                case 12:
                    tri.v1x = 50;
                    tri.v2x = 60;
                    tri.v3x = 60;
                    break;
                default:
                    tri.v1x = 0;
                    tri.v2x = 0;
                    tri.v3x = 10;
                    break;
            }

            return tri;
        }
    }
}
