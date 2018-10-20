﻿using System;
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
            edge.Type = edgeType;
            edge.Length = lenght;
            if (MoveVerticeSafely(edge.Endpoint1, new Point()))
            {
                return true;
            }

            return MoveVerticeSafely(edge.Endpoint2, new Point());
        }

        private bool MoveVerticeSafely(Vertice original, Point offset)
        {
            List<Point> oldPositions = Vertices.Select(v => v.Position).ToList();
            Point newPosition = new Point(original.Position.X + offset.X, original.Position.Y + offset.Y);
            original.Position = newPosition;

            if (RepairEdges(original, original.Edge1))
            {
                return true;
            }

            foreach (var vertice in Vertices.Select((Value, Index) => new { Value, Index }))
            {
                vertice.Value.Position = oldPositions[vertice.Index];
            }

            original.Position = newPosition;
            if (RepairEdges(original, original.Edge2))
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
            Edge edge = new Edge
            {
                Endpoint1 = v1,
                Endpoint2 = v2,
            };
            v1.Edge2 = edge;
            v2.Edge1 = edge;

            var edgesList = Edges.ToList();
            edgesList.Add(edge);
            Edges = edgesList;
        }
    }
}
