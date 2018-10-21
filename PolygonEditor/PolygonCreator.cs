using System.Collections.Generic;
using System.Drawing;

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
                if (edge.Type == EdgeType.FixedLength)
                {
                    edge.Length = (int)PointUtilities.GetDistanceBetweenPoints(edge.Endpoints[0].Position, edge.Endpoints[1].Position);
                }

                vertices[leftVerticeIndex].Edges[1] = edge;
                vertices[rightVerticeIndex].Edges[0] = edge;
                edges.Add(edge);
            }

            return new Polygon(vertices, edges);
        }
    }
}
