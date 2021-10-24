using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp.Experiemnt4
{
    using DrawingPoint = System.Drawing.Point;

    public partial class Form1 : Form
    {

        public Button btnConfirm = new ConfirmButton(250, 300);

        private static Size labelSize = new Size(80, 20);
        public InputGroup x1 = new InputGroup(100, 100, "x=", labelSize);
        public InputGroup x2 = new InputGroup(350, 100, "x=", labelSize);
        public InputGroup y1 = new InputGroup(100, 150, "y=", labelSize);
        public InputGroup y2 = new InputGroup(350, 150, "y=", labelSize);

        public Label resultLabel = new Label()
        {
            Text = "两点之间的距离为：",
            Location = new DrawingPoint(280, 200),
            Size = new Size(200, 20),
        };
        public TextBox result = new TextBox()
        {
            Enabled = false,
            Text = string.Empty,
            Location = new DrawingPoint(280, 240),
            Size = new Size(100, 20),
        };
        public Form1()
        {
            InitializeComponent();

            Controls.Add(x1.label);
            Controls.Add(x1.textBox);
            Controls.Add(x2.label);
            Controls.Add(x2.textBox);
            Controls.Add(y1.label);
            Controls.Add(y1.textBox);
            Controls.Add(y2.label);
            Controls.Add(y2.textBox);

            Controls.Add(resultLabel);
            Controls.Add(result);

            btnConfirm.Click += btn_click;
            Controls.Add(btnConfirm);
        }

        private void btn_click(object sender, EventArgs e)
        {
            Point p1 = new Point(Convert.ToDouble(x1.input),
                                 Convert.ToDouble(y1.input));

            Point p2 = new Point(Convert.ToDouble(x2.input),
                                 Convert.ToDouble(y2.input));

            result.Text = String.Format("{0:f6}", p1.Distance(p2));
        }

    }
}
