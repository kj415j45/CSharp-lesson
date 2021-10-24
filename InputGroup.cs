using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public class InputGroup
    {
        private readonly Size standardSize = new Size(100, 20);
        public Label label {get; private set;}

        public TextBox textBox {get; private set;}

        public string input { get => textBox.Text; }

        public InputGroup(int x, int y, string text,
                          Size? specialSizeForLabel = null,
                          Size? specialSizeForTextBox = null)
        {
            this.label = new Label
            {
                Text = text,
                Location = new Point(x, y),
                Size = specialSizeForLabel ?? this.standardSize,
            };

            this.textBox = new TextBox
            {
                Location = new Point(x + standardSize.Width + 10, y),
                Size = specialSizeForTextBox ?? this.standardSize,
            };
        }

    }
}