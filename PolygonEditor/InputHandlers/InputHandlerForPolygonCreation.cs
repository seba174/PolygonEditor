using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolygonEditor
{
    public class InputHandlerForPolygonCreation : InputHandler
    {
        private Point lastMousePosition;

        public Action OnVerticeAdd { get; set; }
        public Action OnFinishedDrawing { get; set; }
        public Action OnSuccessfullElementMove { get; set; }

        public IPolygon PolygonUnderCreation { get; set; }
        public IPolygon SelectedPolygon => null;
        public IClickable SelectedElement => null;

        public void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (PolygonUnderCreation.Vertices.Count > 0)
            {
                Point offset = new Point(e.X - lastMousePosition.X, e.Y - lastMousePosition.Y);
                if (PolygonUnderCreation.HandleClickableMove(PolygonUnderCreation.Vertices[PolygonUnderCreation.Vertices.Count - 1], offset))
                {
                    OnSuccessfullElementMove?.Invoke();
                }
            }
            lastMousePosition = e.Location;
        }

        public void HandleMouseUp(object sender, MouseEventArgs e) { }

        public void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Vertice vertice = new Vertice
                {
                    Position = e.Location
                };

                PolygonUnderCreation.AddVertice(vertice, PolygonUnderCreation.Vertices.Last(), null);
                OnVerticeAdd?.Invoke();
            }
            else if (e.Button == MouseButtons.Right)
            {
                OnFinishedDrawing?.Invoke();
            }
        }

        public void ClearSelected() { }
    }
}
