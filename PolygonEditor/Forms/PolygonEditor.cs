using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolygonEditor
{
    public partial class PolygonEditor : Form
    {
        private DrawingAreaInputHandler inputHandler;
        private PolygonDrawer standardPolygonDrawer;
        private PolygonDrawer selectedElementDrawer;
        private List<IPolygon> polygons;

        public PolygonEditor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            polygons = new List<IPolygon> { PolygonCreator.GetCustom() };
            Vertice.ClickRadius = 10;
            Edge.ClickDistance = 5;

            inputHandler = new DrawingAreaInputHandler()
            {
                HandledPolygons = polygons,
                OnSuccessfullElementMove = drawingArea.Refresh,
                OnElementSelection = OnElementSelection,
                OnElementUnselection = OnElementUnselection
            };

            standardPolygonDrawer = new PolygonDrawer
            {
                EdgeColor = Color.LightGray,
                EdgeThickness = 2,
                VerticeBorderColor = Color.LightGray,
                VerticeInsideColor = Color.FromArgb(28, 28, 28),
                VerticeBorderThickness = 1,
                VerticeRadius = 10,
                IconLineThickness = 1,
                IconRadius = 12,
                IconColor = Color.Yellow,
                IconFontName = "Arial",
                IconFontSize = 12
            };

            selectedElementDrawer = new PolygonDrawer
            {
                EdgeColor = Color.Red,
                EdgeThickness = standardPolygonDrawer.EdgeThickness,
                VerticeBorderColor = Color.Red,
                VerticeInsideColor = standardPolygonDrawer.VerticeInsideColor,
                VerticeBorderThickness = standardPolygonDrawer.VerticeBorderThickness,
                VerticeRadius = standardPolygonDrawer.VerticeRadius,
                IconLineThickness = standardPolygonDrawer.IconLineThickness,
                IconRadius = standardPolygonDrawer.IconRadius,
                IconColor = standardPolygonDrawer.IconColor,
                IconFontName = standardPolygonDrawer.IconFontName,
                IconFontSize = standardPolygonDrawer.IconFontSize
            };

            #region Events pinning

            drawingArea.Paint += Draw;
            drawingArea.MouseDown += inputHandler.HandleMouseDown;
            drawingArea.MouseUp += inputHandler.HandleMouseUp;
            drawingArea.MouseMove += inputHandler.HandleMouseMove;

            MakeVerticalButton.Click += ChangeSelectedEdgeToVertical;
            MakeHorizontalButton.Click += ChangeSelectedEdgeToHorizontal;
            MakeFixedLengthButton.Click += ChangeSelectedEdgeToFixedLength;
            ChangeLengthButton.Click += ChangeSelectedEdgeLength;
            RemoveConstraintsButton.Click += RemoveConstraintsFromSelectedEdge;
            DeleteVerticeButton.Click += DeleteSelectedVertice;
            SplitButton.Click += SplitSelectedEdge;

            CreateTriangleButton.Click += CreateTriangle;
            CreateRectangleButton.Click += CreateRectangle;
            CreateCustomButton.Click += CreateCustomPolygon;
            DeletePolygonButton.Click += DeleteSelectedPolygon;

            #endregion

            UpdateButtons();
        }

        private void OnElementUnselection()
        {
            UpdateButtons();
            drawingArea.Refresh();
        }

        private void OnElementSelection()
        {
            UpdateButtons();
            drawingArea.Refresh();
        }

        private void ChangeSelectedEdgeToVertical(object sender, EventArgs e)
        {
            HandleSimpleEdgeTypeChange(EdgeType.Vertical, -1, string.Format(ErrorMessages.CanNotChangeEdgeType, EdgeType.Vertical.Name));
            FakeButton.Focus();
        }

        private void ChangeSelectedEdgeToHorizontal(object sender, EventArgs e)
        {
            HandleSimpleEdgeTypeChange(EdgeType.Horizontal, -1, string.Format(ErrorMessages.CanNotChangeEdgeType, EdgeType.Horizontal.Name));
            FakeButton.Focus();
        }

        private void ChangeSelectedEdgeToFixedLength(object sender, EventArgs e)
        {
            HandleChangingEdgeLengthOrTypeToFixedLenght(string.Format(ErrorMessages.CanNotChangeEdgeType, EdgeType.FixedLength.Name));
            FakeButton.Focus();
        }

        private void RemoveConstraintsFromSelectedEdge(object sender, EventArgs e)
        {
            HandleSimpleEdgeTypeChange(EdgeType.Normal, -1, string.Format(ErrorMessages.CanNotChangeEdgeType, EdgeType.Normal.Name));
            FakeButton.Focus();
        }

        private void ChangeSelectedEdgeLength(object sender, EventArgs e)
        {
            HandleChangingEdgeLengthOrTypeToFixedLenght(string.Format(ErrorMessages.CanNotChangeEdgeLenght, EdgeType.FixedLength.Name));
            FakeButton.Focus();
        }

        private void DeleteSelectedVertice(object sender, EventArgs e)
        {
            if (inputHandler.SelectedElement is Vertice v)
            {
                if (inputHandler.SelectedPolygon.DeleteVertice(v))
                {
                    inputHandler.ClearSelected();
                    drawingArea.Refresh();
                }
                else
                {
                    InformationDialog.Show(ErrorMessages.CanNotDeleteVertice);
                }
            }
            FakeButton.Focus();
        }

        private void SplitSelectedEdge(object sender, EventArgs e)
        {
            if (inputHandler.SelectedElement is Edge selectedEdge)
            {
                inputHandler.SelectedPolygon.SplitEdge(selectedEdge);
                inputHandler.ClearSelected();
                drawingArea.Refresh();
            }
            FakeButton.Focus();
        }

        private void CreateTriangle(object sender, EventArgs e)
        {
            polygons.Add(PolygonCreator.GetSampleTriangle());
            FakeButton.Focus();
            drawingArea.Refresh();
        }

        private void CreateRectangle(object sender, EventArgs e)
        {
            polygons.Add(PolygonCreator.GetSampleRectangle());
            FakeButton.Focus();
            drawingArea.Refresh();
        }

        private void CreateCustomPolygon(object sender, EventArgs e)
        {
            polygons.Add(PolygonCreator.GetCustom());
            FakeButton.Focus();
            drawingArea.Refresh();
        }

        private void DeleteSelectedPolygon(object sender, EventArgs e)
        {
            if (inputHandler.SelectedPolygon != null)
            {
                polygons.Remove(inputHandler.SelectedPolygon);
                inputHandler.ClearSelected();
                FakeButton.Focus();
                drawingArea.Refresh();
            }
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            if (inputHandler.SelectedElement is Edge selectedEdge)
            {
                Polygon polygonWithOnlySelectedEdge = new Polygon(new Vertice[0], new Edge[] { selectedEdge });
                selectedElementDrawer.DrawPolygon(e.Graphics, polygonWithOnlySelectedEdge);
            }

            foreach (var polygon in polygons)
            {
                IEnumerable<Vertice> vertices = polygon.Vertices.Where(v => v != inputHandler.SelectedElement);
                IEnumerable<Edge> edges = polygon.Edges.Where(edge => edge != inputHandler.SelectedElement);
                Polygon polygonWithoutSelectedElement = new Polygon(vertices, edges);
                standardPolygonDrawer.DrawPolygon(e.Graphics, polygonWithoutSelectedElement);
            }

            if (inputHandler.SelectedElement is Vertice selectedVertice)
            {
                Polygon polygonWithOnlySelectedVertice = new Polygon(new Vertice[] { selectedVertice }, new Edge[0]);
                selectedElementDrawer.DrawPolygon(e.Graphics, polygonWithOnlySelectedVertice);
            }
        }

        private void HandleSimpleEdgeTypeChange(EdgeType edgeType, int lenght, string errorMessage)
        {
            if (inputHandler.SelectedElement is Edge selectedEdge)
            {
                if (inputHandler.SelectedPolygon.ChangeEdgeType(selectedEdge, edgeType, lenght))
                {
                    UpdateButtons();
                    drawingArea.Refresh();
                }
                else
                {
                    InformationDialog.Show(errorMessage);
                }
            }
        }

        private void HandleChangingEdgeLengthOrTypeToFixedLenght(string errorMessage)
        {
            if (inputHandler.SelectedElement is Edge selectedEdge)
            {
                EdgeLenghtPicker dialog = GetEdgeLenghtPickerDialog();
                dialog.Lenght = selectedEdge.Length;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    HandleSimpleEdgeTypeChange(EdgeType.FixedLength, dialog.Lenght, errorMessage);
                }
            }
        }

        private EdgeLenghtPicker GetEdgeLenghtPickerDialog()
        {
            return new EdgeLenghtPicker
            {
                StartPosition = FormStartPosition.CenterParent
            };
        }

        private void UpdateButtons()
        {
            if (inputHandler.SelectedElement is Vertice v)
            {
                foreach (var button in EditEdgeGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = false;
                foreach (var button in EditVerticeGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = true;
                foreach (var button in EditPolygonGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = true;
            }
            else if (inputHandler.SelectedElement is Edge e)
            {
                foreach (var button in EditVerticeGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = false;
                foreach (var button in EditPolygonGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = true;

                ChangeLengthButton.Enabled = e.Type != EdgeType.FixedLength ? false : true;
                RemoveConstraintsButton.Enabled = e.Type == EdgeType.Normal ? false : true;
                MakeFixedLengthButton.Enabled = e.Type == EdgeType.FixedLength ? false : true;
                MakeHorizontalButton.Enabled = e.Type == EdgeType.Horizontal ? false : true;
                MakeVerticalButton.Enabled = e.Type == EdgeType.Vertical ? false : true;
                SplitButton.Enabled = true;
            }
            else
            {
                foreach (var button in EditEdgeGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = false;
                foreach (var button in EditVerticeGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = false;
                foreach (var button in EditPolygonGroupBox.FindAllChildrenByType<Button>())
                    button.Enabled = false;
            }
        }
    }
}
