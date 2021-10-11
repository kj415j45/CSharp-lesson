using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
            Controls.Add(new Label()
            {
                Text = "请输入一个整数：",
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
            int number = Convert.ToInt32(input.Text);

            result.Text = IsPrime(number) ? "是素数" : "不是素数";
        }

        private static bool IsPrime(int number)
        {
            int border = Convert.ToInt32(Math.Sqrt(number));
            for (int i = 2; i <= border; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
                else
                {
                    //TODO 记忆化搜索
                    continue;
                }
            }
            return true;
        }

    }
}
