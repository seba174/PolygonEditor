using System.Drawing;

namespace PolygonEditor
{
    public class Vertice : IClickable
    {
        public static int ClickRadius { get; set; }

        public Point Position { get; set; }
        public Edge[] Edges { get; private set; }

        public Vertice() => Edges = new Edge[2];

        public Vertice(Edge edge1, Edge edge2) => Edges = new Edge[] { edge1, edge2 };

        public Edge GetSecondEdge(Edge e)
        {
            return e == Edges[0] ? Edges[1] : Edges[0];
        }

        public void DisconnectEdge(Edge e)
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                if (Edges[i] == e)
                {
                    Edges[i] = null;
                }
            }
        }

        public void ConnectEdge(Edge e)
        {
            for (int i = 0; i < Edges.Length; i++)
            {
                if (Edges[i] == null)
                {
                    Edges[i] = e;
                    return;
                }
            }
        }

        bool IClickable.IsClicked(Point position)
        {
            int dx = this.Position.X - position.X;
            int dy = this.Position.Y - position.Y;
            return dx * dx + dy * dy <= ClickRadius * ClickRadius;
        }
    }
}
