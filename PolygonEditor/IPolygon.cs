using System.Collections.Generic;
using System.Drawing;

namespace PolygonEditor
{
    public interface IPolygon
    {
        IEnumerable<IClickable> Clickables { get; }

        IEnumerable<Vertice> Vertices { get; }

        IEnumerable<Edge> Edges { get; }

        bool HandleClickableMove(IClickable clickableElement, Point offset);

        bool HandlePolygonMove(Point offset);

        bool DeleteVertice(Vertice v);

        void SplitEdge(Edge e);

        bool ChangeEdgeType(Edge edge, EdgeType edgeType, int lenght);
    }
}
