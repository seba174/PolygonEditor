using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PolygonEditor
{
    public static class ConvexHullOfPolygon
    {
        public static IPolygon GetConvexHull(IPolygon polygon)
        {
            List<Point> newVerticesPositons = new List<Point>();

            Point[] points = polygon.Vertices.Select(v => v.Position).ToArray();

            int ymin = points[0].Y, min = 0;
            for (int i = 1; i < points.Length; i++)
            {
                int y = points[i].Y;

                if ((y < ymin) || (ymin == y &&
                    points[i].X < points[min].X))
                {
                    ymin = points[i].Y;
                    min = i;
                }
            }

            Point temp = points[0];
            points[0] = points[min];
            points[min] = temp;

            Array.Sort(points, 1, points.Length - 1, new ConvexHullComparer(points[0]));

            int m = 1;
            for (int i = 1; i < points.Length; i++)
            {
                while (i < points.Length - 1 && Orientation(points[0], points[i], points[i + 1]) == 0)
                    i++;

                points[m] = points[i];
                m++;
            }

            if (m < 3)
                return null;

            Stack<Point> S = new Stack<Point>();
            S.Push(points[0]);
            S.Push(points[1]);
            S.Push(points[2]);

            for (int i = 3; i < m; i++)
            {
                while (Orientation(NextToTop(S), S.Peek(), points[i]) != 2)
                    S.Pop();

                S.Push(points[i]);
            }

            while (S.Count != 0)
            {
                newVerticesPositons.Add(S.Pop());
            }

            List<EdgeType> edgetypes = new List<EdgeType>();
            for (int i = 0; i < newVerticesPositons.Count; i++)
                edgetypes.Add(EdgeType.Normal);

            Polygon p = PolygonCreator.CreatePolygon(newVerticesPositons, edgetypes);
            foreach (var edge in polygon.Edges)
            {
                Edge ed = p.Edges.Find(e =>
                    (e.Endpoints[0].Position == edge.Endpoints[0].Position && e.Endpoints[1].Position == edge.Endpoints[1].Position)
                    || (e.Endpoints[1].Position == edge.Endpoints[0].Position && e.Endpoints[0].Position == edge.Endpoints[1].Position));
                if (ed != null)
                {
                    p.ChangeEdgeType(ed, edge.Type, edge.Length);
                }
            }

            return p;
        }


        public class ConvexHullComparer : IComparer<Point>
        {
            private readonly Point point;

            public ConvexHullComparer(Point point) => this.point = point;

            public int Compare(Point x, Point y)
            {
                int orientation = Orientation(point, x, y);
                if (orientation == 0)
                {
                    return (PointUtilities.SquaredDistanceBetweenPoints(point, y) >= PointUtilities.SquaredDistanceBetweenPoints(point, x)) ? -1 : 1;
                }
                return (orientation == 2) ? -1 : 1;
            }
        }

        private static int Orientation(Point p, Point q, Point r)
        {
            int val = (q.Y - p.Y) * (r.X - q.X) -
                      (q.X - p.X) * (r.Y - q.Y);

            if (val == 0)
                return 0;

            return (val > 0) ? 1 : 2;
        }

        private static Point NextToTop(Stack<Point> S)
        {
            Point p = S.Pop();
            Point res = S.Peek();
            S.Push(p);
            return res;
        }
    }
}
