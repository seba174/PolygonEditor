using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonEditor
{
    public static class PointUtilities
    {
        public static double DistanceBetweenPoints(Point point1, Point point2)
        {
            int centerDx = point1.X - point2.X;
            int centerDy = point1.Y - point2.Y;
            return Math.Sqrt(centerDx * centerDx + centerDy * centerDy);
        }

        public static Point GetPointOnLineWithSpecificDistanceFromStart(Point lineSegmentStart, Point lineSegmentEnd, double distance)
        {
            double lineSegmentLength = DistanceBetweenPoints(lineSegmentStart, lineSegmentEnd);
            double ratio = distance / lineSegmentLength;
            int x = (int)((1 - ratio) * lineSegmentStart.X + ratio * lineSegmentEnd.X);
            int y = (int)((1 - ratio) * lineSegmentStart.Y + ratio * lineSegmentEnd.Y);
            return new Point(x, y);
        }
    }
}
