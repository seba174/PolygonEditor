using System.Windows.Forms;

namespace PolygonEditor
{
    public interface InputHandler
    {
        IPolygon SelectedPolygon { get; }
        IClickable SelectedElement { get; }

        void HandleMouseMove(object sender, MouseEventArgs e);

        void HandleMouseUp(object sender, MouseEventArgs e);

        void HandleMouseDown(object sender, MouseEventArgs e);

        void ClearSelected();
    }
}
