using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonEditor
{
    public class InputHandler
    {
        public IPolygon SelectedPolygon { get; private set; }

        public IClickable SelectedElement { get; private set; }

        private IEnumerable<IPolygon> handledPolygons;
        public IEnumerable<IPolygon> HandledPolygons
        {
            get => handledPolygons;
            set
            {
                ClearSelected();
                handledPolygons = value;
            }
        }

        public void HandleMouseMove(MouseEventArgs e)
        {

        }

        public void HandleMouseUp(MouseEventArgs e)
        {

        }

        public void HandleMouseDown(MouseEventArgs e)
        {

        }

        private void ClearSelected()
        {
            SelectedElement = null;
            SelectedPolygon = null;
        }
    }
}
