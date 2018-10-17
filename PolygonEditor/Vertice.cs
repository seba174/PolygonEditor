using System.Drawing;

namespace PolygonEditor
{
    public class Vertice : IClickable
    {
        public static int Radius { get; set; }
        public Point Position { get; set; }
        public Edge Edge1 { get; set; }
        public Edge Edge2 { get; set; }

        public Vertice() { }

        public Vertice(Edge edge1, Edge edge2)
        {
            this.Edge1 = edge1;
            this.Edge2 = edge2;
        }

        public Edge GetSecondEdge(Edge e)
        {
            return e == Edge1 ? Edge2 : Edge1;
        }

        bool IClickable.IsClicked(Point position)
        {
            int dx = this.Position.X - position.X;
            int dy = this.Position.Y - position.Y;
            return dx * dx + dy * dy <= Radius * Radius;
        }
    }
}
