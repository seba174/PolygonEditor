using System;
using System.Windows.Forms;

namespace PolygonEditor
{
    public partial class EdgeLenghtPicker : Form
    {
        public int Lenght { get; private set; }

        public EdgeLenghtPicker()
        {
            InitializeComponent();

            EdgeLenghtErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            OkButton.Click += OkButtonClick;
            CancelButton.Click += CancelButtonClick;
            EdgeLengthTextBox.TextChanged += (object s, EventArgs e) => ValidateTextBox();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            ValidateTextBox();
            if (EdgeLenghtErrorProvider.GetError(EdgeLengthTextBox) == string.Empty)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ValidateTextBox()
        {
            string enteredLenght = EdgeLengthTextBox.Text;
            bool isParsed = int.TryParse(enteredLenght, out int lenght);
            if (!isParsed || lenght <= 0)
            {
                EdgeLenghtErrorProvider.SetError(EdgeLengthTextBox, "Provide an integer greater than 0");
            }
            else
            {
                Lenght = lenght;
                EdgeLenghtErrorProvider.SetError(EdgeLengthTextBox, "");
            }
        }
    }
}
