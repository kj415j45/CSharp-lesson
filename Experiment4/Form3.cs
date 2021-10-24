using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp.Experiemnt4
{
    using DrawingPoint = System.Drawing.Point;
    public partial class Form3 : Form
    {
        private Grade grade = new Grade();
        private static readonly Size StandardButtonSize = new Size(50, 30);

        private static readonly Size StadardLabelSize = new Size(60, 30);
        private static readonly Size StadardTextBoxSize = new Size(70, 30);

        public InputGroup id = new InputGroup(10, 10, "学号：", StadardLabelSize, StadardTextBoxSize);
        public InputGroup name = new InputGroup(10, 50, "姓名：", StadardLabelSize, StadardTextBoxSize);
        public InputGroup chinese = new InputGroup(10, 90, "语文：", StadardLabelSize, StadardTextBoxSize);
        public InputGroup math = new InputGroup(10, 130, "数学：", StadardLabelSize, StadardTextBoxSize);
        public InputGroup english = new InputGroup(10, 170, "英语：", StadardLabelSize, StadardTextBoxSize);


        public Button addButton = new Button()
        {
            Text = "添加",
            Size = StandardButtonSize,
            Location = new DrawingPoint(200, 50),
        };

        public Button doneButton = new Button()
        {
            Text = "完成",
            Size = StandardButtonSize,
            Location = new DrawingPoint(200, 90),
        };

        public Button queryButton = new Button()
        {
            Text = "查询",
            Size = StandardButtonSize,
            Location = new DrawingPoint(200, 130),
        };

        public RichTextBox result = new RichTextBox()
        {
            Enabled = false,
            Size = new Size(400, 300),
            Location = new DrawingPoint(260, 10)
        };

        public Form3()
        {
            InitializeComponent();

            Controls.Add(id.label);
            Controls.Add(id.textBox);
            Controls.Add(name.label);
            Controls.Add(name.textBox);
            Controls.Add(chinese.label);
            Controls.Add(chinese.textBox);
            Controls.Add(math.label);
            Controls.Add(math.textBox);
            Controls.Add(english.label);
            Controls.Add(english.textBox);

            Controls.Add(result);

            addButton.Click += onAdd;
            Controls.Add(addButton);

            doneButton.Click += onDone;
            Controls.Add(doneButton);

            queryButton.Click += onQuery;
            Controls.Add(queryButton);
        }

        private void onAdd(object sender, EventArgs e)
        {
            this.grade.addStudent(new Student(
                Convert.ToInt32(this.id.textBox.Text),
                this.name.input,
                Convert.ToDouble(this.chinese.input),
                Convert.ToDouble(this.math.input),
                Convert.ToDouble(this.english.input)
            ));
            this.result.Text = $"添加{this.name.input}成功";
        }

        private void onDone(object sender, EventArgs e)
        {
            var averageScore = this.grade.getAverageScore();
            var best3 = this.grade.getBest3();
            var failureListOfChinese = this.grade.getFailureOn("chinese");
            var failureListOfMath = this.grade.getFailureOn("math");
            var failureListOfEnglish = this.grade.getFailureOn("english");
            this.result.Text = string.Format(
@"平均分：【语文】{0:f2}【数学】{1:f2}【英语】{2:f2}
总分前三名：{3}
语文不及格：{4}
数学不及格：{5}
英语不及格：{6}",
averageScore["chinese"], averageScore["math"], averageScore["english"],
best3.toString(),
failureListOfChinese.toString(), failureListOfMath.toString(), failureListOfEnglish.toString());
        }

        private void onQuery(object sender, EventArgs e)
        {
            Student target = this.grade.getStudentByName(this.name.input);
            this.result.Text = $"{target.name}的总成绩为：{target.totalScore}";
        }

    }
}
