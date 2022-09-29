using System.Drawing.Design;
using ValueService.Lib;
namespace ValueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValueServices vs = new ValueServices();
            result.Text = vs.GetDisplayValue(Convert.ToDecimal(UserInputWhitout.Text), Convert.ToInt32(precision.Value));

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}