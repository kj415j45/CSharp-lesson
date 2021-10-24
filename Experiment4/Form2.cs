using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp.Experiemnt4
{
    using DrawingPoint = System.Drawing.Point;
    public partial class Form2 : Form
    {
        Time time = new Time();

        public TextBox hour = new TextBox()
        {
            Location = new DrawingPoint(50, 20),
            Size = StandardSize,
        };

        public TextBox minute = new TextBox()
        {
            Location = new DrawingPoint(100, 20),
            Size = StandardSize,
        };

        public TextBox second = new TextBox()
        {
            Location = new DrawingPoint(150, 20),
            Size = StandardSize,
        };

        private static readonly Size StandardSize = new Size(30, 20);

        public Button plusButton = new Button()
        {
            Text = "+",
            Size = new Size(40, 40),
            Location = new DrawingPoint(200, 20),
        };

        public Form2()
        {
            InitializeComponent();

            hour.Text = $"{this.time.hour}";
            minute.Text = $"{this.time.minute}";
            second.Text = $"{this.time.second}";

            Controls.Add(hour);
            Controls.Add(new Label()
            {
                Text = ":",
                Location = new DrawingPoint(80, 20),
                Size = new Size(20, 20),
            });
            Controls.Add(minute);
            Controls.Add(new Label()
            {
                Text = ":",
                Location = new DrawingPoint(130, 20),
                Size = new Size(20, 20),
            });
            Controls.Add(second);

            plusButton.Click += btn_click;
            Controls.Add(plusButton);
        }

        private void btn_click(object sender, EventArgs e)
        {
            this.time = new Time(Convert.ToInt32(hour.Text),
                                 Convert.ToInt32(minute.Text),
                                 Convert.ToInt32(second.Text));
            this.time.Plus1Second();
            hour.Text = $"{this.time.hour}";
            minute.Text = $"{this.time.minute}";
            second.Text = $"{this.time.second}";
        }

    }
}
