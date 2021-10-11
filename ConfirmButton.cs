using System.Drawing;
using System.Windows.Forms;

namespace CSharp
{
    public class ConfirmButton : Button
    {

        public ConfirmButton()
        {
            Name = "btnOk";
            Text = "确定";
            Location = new Point(350, 200);
            Size = new Size(80, 30);
        }

    }
}
