//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Drawing;

//namespace WarAtSea.Utilities.Maps
//{
//    public class Math
//    {
//        // h = short Length (outside)
//        // r = long Length (outside)
//        // s = Length of a side of the hexagon; all 6 are equal

//        // h = sin (30 degrees) x side
//        // r = cos (30 degrees) x side

//        // point-to-point diameter = s + (2h)
//        // side-to-side diameter = 2r

//        //         h
//        //        ___
//        //   _____    |
//        //  /     \   |  r
//        // /    s  \  |
//        // \       /
//        //  \_____/
//        // 
//        // each interior angle = 120 degrees
//        // the angle of sr is 30 degrees
//        // the angle of rh is 90 degrees
//        // the angle of sh is 60 degrees

//        // Convert from double-precision floating-point number to single-precision floating point number
//        public static float CalculateH(float s)
//        {
//            return Convert.ToSingle(System.Math.Sin(DegreesToRadians(30)) * s);
//        }

//        // Convert from double-precision floating-point number to single-precision floating point number
//        public static float CalculateR(float s)
//        {
//            return Convert.ToSingle(System.Math.Cos(DegreesToRadians(30)) * s);
//        }

//        // Sin and Cos only take arguments in radians in System.Math, so helper methods are needed
//        public static double DegreesToRadians(double degrees)
//        {
//            return (degrees * System.Math.PI) / 180;
//        }

//        public static double RadiansToDegrees(double radians)
//        {
//            return (radians * 180) / System.Math.PI;
//        }

//        // Algorithm to check if a point is inside a polygon (Checks how many times a line 
//        // originating from a point will cross each side. An odd result means it is inside the polygon)
//        public static bool InsidePolygon(PointF[] polygon, int N, PointF p)
//        {
//            int counter = 0;
//            double xinters;
//            PointF p1, p2;

//            p1 = polygon[0];
//            for (int i = 1; i <= N; i++)
//            {
//                p2 = polygon[i % N];
//                if (p.Y <= System.Math.Min(p1.Y, p2.Y))
//                {
//                    if (p.Y <= System.Math.Max(p1.X, p2.X))
//                    {
//                        if (p.X <= System.Math.Max(p1.X, p2.X))
//                        {
//                            if (p1.Y != p2.Y)
//                            {
//                                xinters = (p.Y - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y) + p1.X;
//                                if (p1.X == p2.X || p.X <= xinters)
//                                {
//                                    counter++;
//                                }
//                            }
//                        }
//                    }
//                }
//                p1 = p2;
//            }

//            if (counter % 2 == 0)
//                return false;
//            else
//                return true;
//        }

//        //// In a regular hexagon the interior angles are 120 degrees. There are six "wedges," each an equilateral triangle with 
//        //// 60-degree angles inside. Corner 'i' is at (60deg * i) size units away from the center.
//        //public static PointF HexCorner(PointF center, float s, float unit)
//        //{
//        //    var angleDegrees = 60 * unit;
//        //    var angleRadians = Convert.ToSingle(System.Math.PI / (180 * angleDegrees));
//        //    var point = (center.X + s * System.Math.Cos(angleRadians), center.Y + s * System.Math.Sin(angleRadians));
            
//        //    return point;
//        //}

//    }
    
//}
