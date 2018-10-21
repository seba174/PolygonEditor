using System.Drawing;

namespace PolygonEditor
{
    public class Edge : IClickable
    {
        public static int ClickDistance { get; set; }

        public Vertice[] Endpoints { get; private set; }
        public EdgeType Type { get; set; }
        public int Length { get; set; }

        public Edge() => Endpoints = new Vertice[2]; 

        public Vertice GetSecondEndpoint(Vertice endpoint)
        {
            return endpoint == Endpoints[0] ? Endpoints[1] : Endpoints[0];
        }

        bool IClickable.IsClicked(Point position)
        {
            return PointUtilities.GetDistanceFromEdge(this, position) < ClickDistance;
        }
    }
}
