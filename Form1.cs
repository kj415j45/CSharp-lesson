using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form1 : Form
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
        public Form1()
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
            int inputYear = Convert.ToInt32(input.Text);

            result.Text = IsLeapYear(inputYear) ? "是闰年" : "不是闰年";
        }

        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) //能被4整除但不能被100整除
            {
                return true;
            }
            else if (year % 400 == 0) //或 能被400整除
            {
                return true;
            }
            return false;
        }

    }
}
