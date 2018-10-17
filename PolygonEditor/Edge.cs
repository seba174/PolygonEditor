using System.Drawing;

namespace PolygonEditor
{
    public class Edge : IClickable
    {
        public Vertice Endpoint1 { get; set; }
        public Vertice Endpoint2 { get; set; }
        public EdgeType Type { get; set; }
        public int Length { get; set; }

        public Edge(Vertice endpoint1, Vertice endpoint2)
        {
            this.Endpoint1 = endpoint1;
            this.Endpoint2 = endpoint2;
        }

        public Vertice GetSecondEndpoint(Vertice endpoint)
        {
            return endpoint == Endpoint1 ? Endpoint2 : Endpoint1;
        }

        bool IClickable.IsClicked(Point position)
        {
            return false;
        }
    }
}
