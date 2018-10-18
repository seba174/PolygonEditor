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

        bool HandleClickableMove(IClickable vertice, Point offset);

        bool HandlePolygonMove(Point offset);

        bool ChangeEdgeType(Edge edge, EdgeType edgeType, int lenght);
    }
}
