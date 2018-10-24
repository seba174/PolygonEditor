using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PolygonEditor
{
    public class Polygon : IPolygon
    {
        public IEnumerable<Vertice> Vertices { get; private set; }
        public IEnumerable<Edge> Edges { get; private set; }
        public IEnumerable<IClickable> Clickables => Vertices.Concat(Edges.Cast<IClickable>());

        public Polygon(IEnumerable<Vertice> vertices, IEnumerable<Edge> edges)
        {
            this.Vertices = vertices;
            this.Edges = edges;
        }

        public bool HandleClickableMove(IClickable clickable, Point offset)
        {
            if (clickable is Vertice vertice)
            {
                return MoveVerticeSafely(vertice, offset);
            }
            return false;
        }

        public bool HandlePolygonMove(Point offset)
        {
            foreach (var vertice in Vertices)
            {
                vertice.Position = new Point(vertice.Position.X + offset.X, vertice.Position.Y + offset.Y);
            }

            return true;
        }

        public bool ChangeEdgeType(Edge edge, EdgeType edgeType, int lenght = -1)
        {
            EdgeType oldType = edge.Type;
            int oldLenght = edge.Length;

            edge.Type = edgeType;

            if (!ValidateEdgeTypes(edge))
            {
                edge.Type = oldType;
                return false;
            }

            edge.Length = lenght;

            if (MoveVerticeSafely(edge.Endpoints[0], new Point()) || MoveVerticeSafely(edge.Endpoints[1], new Point()))
            {
                return true;
            }

            edge.Type = oldType;
            edge.Length = oldLenght;
            return false;
        }

        public bool DeleteVertice(Vertice v)
        {
            List<Vertice> verticesList = Vertices.ToList();
            List<Edge> edgesList = Edges.ToList();
            if (verticesList.Count <= 3)
            {
                return false;
            }

            var neighbour1 = v.Edges[0].GetSecondEndpoint(v);
            var neighbour2 = v.Edges[1].GetSecondEndpoint(v);
            neighbour1.DisconnectEdge(v.Edges[0]);
            neighbour2.DisconnectEdge(v.Edges[1]);

            edgesList.RemoveAll(e => v.Edges.Contains(e));
            verticesList.Remove(v);

            Vertices = verticesList;
            Edges = edgesList;

            CreateEdgeBetweenVertices(neighbour1, neighbour2);
            return true;
        }

        public void SplitEdge(Edge e)
        {
            foreach (var vertice in e.Endpoints)
                vertice.DisconnectEdge(e);

            var middleOfEdge = PointUtilities.GetPointInTheMiddleOfSegment(e.Endpoints[0].Position, e.Endpoints[1].Position);
            Vertice v = new Vertice
            {
                Position = middleOfEdge
            };

            CreateEdgeBetweenVertices(v, e.Endpoints[0]);
            CreateEdgeBetweenVertices(v, e.Endpoints[1]);

            List<Vertice> verticesList = Vertices.ToList();
            List<Edge> edgesList = Edges.ToList();

            verticesList.Add(v);
            edgesList.Remove(e);

            Vertices = verticesList;
            Edges = edgesList;
        }

        private bool MoveVerticeSafely(Vertice original, Point offset)
        {
            List<Point> oldPositions = Vertices.Select(v => v.Position).ToList();
            Point newPosition = new Point(original.Position.X + offset.X, original.Position.Y + offset.Y);
            original.Position = newPosition;

            if (RepairEdges(original, original.Edges[0]))
            {
                return true;
            }

            foreach (var vertice in Vertices.Select((Value, Index) => new { Value, Index }))
            {
                vertice.Value.Position = oldPositions[vertice.Index];
            }

            original.Position = newPosition;
            if (RepairEdges(original, original.Edges[1]))
            {
                return true;
            }

            foreach (var vertice in Vertices.Select((Value, Index) => new { Value, Index }))
            {
                vertice.Value.Position = oldPositions[vertice.Index];
            }

            return false;
        }

        private bool RepairEdges(Vertice vertice, Edge edgeToStartFrom)
        {
            RepairEdgeRecursion(vertice, edgeToStartFrom, vertice);
            return RepairEdgeRecursion(vertice, vertice.GetSecondEdge(edgeToStartFrom), vertice);
        }

        private bool RepairEdgeRecursion(Vertice vertice, Edge edge, Vertice start)
        {
            var otherVertice = edge.GetSecondEndpoint(vertice);
            if (otherVertice == start)
            {
                return false;
            }

            if (edge.Type == EdgeType.Vertical)
            {
                if (Math.Abs(vertice.Position.X - otherVertice.Position.X) != 0)
                {
                    otherVertice.Position = new Point(vertice.Position.X, otherVertice.Position.Y);
                    return RepairEdgeRecursion(otherVertice, otherVertice.GetSecondEdge(edge), start);
                }
            }
            else if (edge.Type == EdgeType.Horizontal)
            {
                if (Math.Abs(vertice.Position.Y - otherVertice.Position.Y) != 0)
                {
                    otherVertice.Position = new Point(otherVertice.Position.X, vertice.Position.Y);
                    return RepairEdgeRecursion(otherVertice, otherVertice.GetSecondEdge(edge), start);
                }
            }
            else if (edge.Type == EdgeType.FixedLength)
            {
                otherVertice.Position = PointUtilities.GetPointOnLineWithSpecificDistanceFromStart(vertice.Position, otherVertice.Position, edge.Length);
                return RepairEdgeRecursion(otherVertice, otherVertice.GetSecondEdge(edge), start);
            }

            return true;
        }

        private void CreateEdgeBetweenVertices(Vertice v1, Vertice v2)
        {
            Edge edge = new Edge()
            {
                Type = EdgeType.Normal
            };
            edge.Endpoints[0] = v1;
            edge.Endpoints[1] = v2;

            v1.ConnectEdge(edge);
            v2.ConnectEdge(edge);

            var edgesList = Edges.ToList();
            edgesList.Add(edge);
            Edges = edgesList;
        }

        private bool ValidateEdgeTypes(Edge edge)
        {
            foreach (var vertice in edge.Endpoints)
            {
                if (vertice.Edges.Where(e => e.Type == EdgeType.Horizontal).Count() == 2
                    || vertice.Edges.Where(e => e.Type == EdgeType.Vertical).Count() == 2)
                    return false;
            }
            return true;
        }
    }
}
