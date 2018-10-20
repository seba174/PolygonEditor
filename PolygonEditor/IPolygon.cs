using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonEditor
{
    public interface IPolygon
    {
        IEnumerable<IClickable> Clickables { get; }

        IEnumerable<Vertice> Vertices { get; }

        IEnumerable<Edge> Edges { get; }

        bool HandleClickableMove(IClickable clickableElement, Point offset);

        bool HandlePolygonMove(Point offset);

        bool ChangeEdgeType(Edge edge, EdgeType edgeType, int lenght);
    }
}
