using System.Collections.Generic;
using System.Drawing;

namespace PolygonEditor
{
    public interface IPolygon
    {
        IEnumerable<IClickable> Clickables { get; }

        List<Vertice> Vertices { get; }

        List<Edge> Edges { get; }

        bool HandleClickableMove(IClickable clickableElement, Point offset);

        bool HandlePolygonMove(Point offset);

        bool DeleteVertice(Vertice v);

        void SplitEdge(Edge e);

        void AddVertice(Vertice vertice, Vertice endpoint1, Vertice endpoint2);

        void CreateEdgeBetweenVertices(Vertice v1, Vertice v2);

        bool ChangeEdgeType(Edge edge, EdgeType edgeType, int lenght);
    }
}
