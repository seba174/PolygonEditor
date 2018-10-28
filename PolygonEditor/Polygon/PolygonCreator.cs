using System.Collections.Generic;
using System.Drawing;
using static PolygonEditor.EdgeType;

namespace PolygonEditor
{
    public static class PolygonCreator
    {
        public static Polygon CreatePolygon(List<Point> positionsOfVertices, List<EdgeType> edgeTypes)
        {
            List<Vertice> vertices = new List<Vertice>();
            List<Edge> edges = new List<Edge>();
            if (positionsOfVertices.Count != edgeTypes.Count)
            {
                return new Polygon(vertices, edges);
            }

            foreach (Point position in positionsOfVertices)
            {
                vertices.Add(new Vertice
                {
                    Position = position
                });
            }

            for (int i = 0; i < edgeTypes.Count; i++)
            {
                int leftVerticeIndex = i;
                int rightVerticeIndex = (i + 1) % edgeTypes.Count;

                Edge edge = new Edge
                {
                    Type = edgeTypes[i]
                };
                edge.Endpoints[0] = vertices[leftVerticeIndex];
                edge.Endpoints[1] = vertices[rightVerticeIndex];
                if (edge.Type == FixedLength)
                {
                    edge.Length = (int)PointUtilities.GetDistanceBetweenPoints(edge.Endpoints[0].Position, edge.Endpoints[1].Position);
                }

                vertices[leftVerticeIndex].Edges[1] = edge;
                vertices[rightVerticeIndex].Edges[0] = edge;
                edges.Add(edge);
            }

            return new Polygon(vertices, edges);
        }

        public static Polygon GetSampleTriangle()
        {
            List<Point> verticesPositions = new List<Point> { new Point(100, 100), new Point(200, 200), new Point(200, 100) };
            List<EdgeType> edgeTypes = new List<EdgeType> { Normal, Vertical, Horizontal };
            return CreatePolygon(verticesPositions, edgeTypes);
        }

        public static Polygon GetSampleRectangle()
        {
            List<Point> verticesPositions = new List<Point> { new Point(100, 100), new Point(100, 200), new Point(250, 200), new Point(250, 100) };
            List<EdgeType> edgeTypes = new List<EdgeType> { Vertical, Horizontal, Vertical, Horizontal };
            return CreatePolygon(verticesPositions, edgeTypes);
        }

        public static Polygon GetCustom()
        {
            List<Point> verticesPositions = new List<Point>
            {
                new Point(300, 100), new Point(300, 200), new Point(400, 200), new Point(400, 300), new Point(500, 300), new Point(450, 100)
            };
            List<EdgeType> edgeTypes = new List<EdgeType> { FixedLength, Normal, FixedLength, Horizontal, Normal, Horizontal };
            return CreatePolygon(verticesPositions, edgeTypes);
        }
    }
}
