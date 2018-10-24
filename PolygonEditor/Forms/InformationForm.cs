using System;
using System.Windows.Forms;

namespace PolygonEditor
{
    public partial class InformationForm : Form
    {
        public InformationForm(string information)
        {
            InitializeComponent();
            Information.Text = information;
            OkButton.Click += OkClick;
        }

        private void OkClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
