using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonEditor
{
    public static class PolygonCreator
    {
        public static Polygon CreatePolygon(List<Point> positionsOfVertices, List<EdgeType> edgeTypes)
        {
            List<Vertice> vertices = new List<Vertice>();
            List<Edge> edges = new List<Edge>();
            if (positionsOfVertices.Count != edgeTypes.Count)
                return new Polygon(vertices, edges);

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
                    Endpoint1 = vertices[leftVerticeIndex],
                    Endpoint2 = vertices[rightVerticeIndex],
                    Type = edgeTypes[i]
                };
                if (edge.Type == EdgeType.FixedLength)
                    edge.Length = (int)PointUtilities.DistanceBetweenPoints(edge.Endpoint1.Position, edge.Endpoint2.Position);

                vertices[leftVerticeIndex].Edge2 = edge;
                vertices[rightVerticeIndex].Edge1 = edge;
            }

            return new Polygon(vertices, edges);
        }
    }
}
