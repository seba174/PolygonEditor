using System;
using System.Drawing;
using System.Linq;

namespace PolygonEditor
{
    public class PolygonDrawer
    {
        public Color VerticeBorderColor { get; set; }
        public Color VerticeInsideColor { get; set; }
        public Color EdgeColor { get; set; }

        public int VerticeRadius { get; set; }
        public int VerticeBorderThickness { get; set; }
        public int EdgeThickness { get; set; }

        public void DrawPolygon(Graphics graphics, IPolygon polygon)
        {
            using (Pen pen = new Pen(EdgeColor, EdgeThickness))
            {
                foreach (Edge edge in polygon.Edges)
                {
                    graphics.DrawImage(BresenhamLine(edge.Endpoints[0].Position, edge.Endpoints[1].Position),
                        new Point(edge.Endpoints.Min(e => e.Position.X), edge.Endpoints.Min(e => e.Position.Y)));
                    //graphics.DrawLine(pen, edge.Endpoints[0].Position, edge.Endpoints[1].Position);
                }
            }

            using (Brush b = new SolidBrush(VerticeInsideColor))
            {
                using (Pen pen = new Pen(VerticeBorderColor, VerticeBorderThickness))
                {
                    foreach (Vertice vertice in polygon.Vertices)
                    {
                        Point leftUpperCorner = new Point(vertice.Position.X - VerticeRadius, vertice.Position.Y - VerticeRadius);
                        Rectangle rect = new Rectangle(leftUpperCorner.X, leftUpperCorner.Y, 2 * VerticeRadius, 2 * VerticeRadius);

                        graphics.FillEllipse(b, rect);
                        graphics.DrawEllipse(pen, rect);
                    }
                }
            }
        }

        public Bitmap BresenhamLine(Point p1, Point p2)
        {
            Bitmap bitmap = new Bitmap(Math.Abs(p1.X - p2.X) + 1, Math.Abs(p1.Y - p2.Y) + 1);
            int xShift = Math.Min(p1.X, p2.X);
            int yShift = Math.Min(p1.Y, p2.Y);
            int d, dx, dy, ai, bi, xi, yi;
            Point p = new Point(p1.X, p1.Y);
            if (p1.X < p2.X)
            {
                xi = 1;
                dx = p2.X - p1.X;
            }
            else
            {
                xi = -1;
                dx = p1.X - p2.X;
            }
            if (p1.Y < p2.Y)
            {
                yi = 1;
                dy = p2.Y - p1.Y;
            }
            else
            {
                yi = -1;
                dy = p1.Y - p2.Y;
            }
            bitmap.SetPixel(p.X - xShift, p.Y - yShift, EdgeColor);
            if (dx > dy)
            {
                ai = (dy - dx) * 2;
                bi = dy * 2;
                d = bi - dx;
                while (p.X != p2.X)
                {
                    if (d >= 0)
                    {
                        p.Offset(xi, yi);
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        p.X += xi;
                    }
                    bitmap.SetPixel(p.X - xShift, p.Y - yShift, EdgeColor);
                }
            }
            else
            {
                ai = (dx - dy) * 2;
                bi = dx * 2;
                d = bi - dy;
                while (p.Y != p2.Y)
                {
                    if (d >= 0)
                    {
                        p.Offset(xi, yi);
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        p.Y += yi;
                    }
                    bitmap.SetPixel(p.X - xShift, p.Y - yShift, EdgeColor);
                }
            }
            return bitmap;
        }
    }
}