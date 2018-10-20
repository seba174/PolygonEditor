﻿using System.Drawing;

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
                    graphics.DrawLine(pen, edge.Endpoint1.Position, edge.Endpoint2.Position);
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
    }
}