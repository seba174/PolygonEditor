using System.Drawing;

namespace PolygonEditor
{
    public class Edge : IClickable
    {
        public static int ClickDistance { get; set; }

        public Vertice Endpoint1 { get; set; }
        public Vertice Endpoint2 { get; set; }
        public EdgeType Type { get; set; }
        public int Length { get; set; }

        public Vertice GetSecondEndpoint(Vertice endpoint)
        {
            return endpoint == Endpoint1 ? Endpoint2 : Endpoint1;
        }

        bool IClickable.IsClicked(Point position)
        {
            return PointUtilities.GetDistanceFromEdge(this, position) < ClickDistance;
        }
    }
}
