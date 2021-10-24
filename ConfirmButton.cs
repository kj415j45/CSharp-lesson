using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public class ConfirmButton : Button
    {

        private readonly Size standardSize = new Size(80, 30);

        public ConfirmButton(int x = 350, int y = 200, Size? specialSize = null)
        {
            Name = "btnOk";
            Text = "确定";
            Location = new Point(x, y);
            Size = specialSize ?? this.standardSize;
        }

    }
}
