using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form2 : Form
    {
        public Button btnConfirm = new ConfirmButton();

        public TextBox input = new TextBox()
        {
            Location = new Point(400, 150),
            Size = new Size(100, 20),
        };

        public Label result = new Label()
        {
            Text = string.Empty,
            Location = new Point(350, 350),
            Size = new Size(200, 20),
        };
        public Form2()
        {
            InitializeComponent();
            Controls.Add(new Label()
            {
                Text = "成绩：",
                Location = new Point(200, 150),
                Size = new Size(200, 20),
            });
            Controls.Add(input);
            Controls.Add(result);

            btnConfirm.Click += btn_click;
            Controls.Add(btnConfirm);
        }

        private void btn_click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(input.Text);

            result.Text = score switch
            {
                < 60 => "不及格",
                <= 69 => "及格",
                <= 79 => "中",
                <= 89 => "良",
                _ => "优秀",
            };
        }

    }
}
