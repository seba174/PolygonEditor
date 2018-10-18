using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonEditor
{
    public partial class PolygonEditor : Form
    {
        InputHandler inputHandler;
        List<Polygon> polygons;

        public PolygonEditor()
        {
            InitializeComponent();
            polygons = new List<Polygon>();
            inputHandler = new InputHandler()
            {
                HandledPolygons = polygons
            };
        }

        private void DrawinAreaMouseUp(object sender, MouseEventArgs e)
        {

        }

        private void DrawingAreaMouseDown(object sender, MouseEventArgs e)
        {

        }

        private void DrawingAreaMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void DrawingAreaPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
