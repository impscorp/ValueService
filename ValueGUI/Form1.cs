using System.Drawing.Design;
using ValueService.Lib;
using static ValueService.Lib.ValueServices;

namespace ValueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initComboBox();
        }

        private void initComboBox()
        {
            ValueServices vs = new ValueServices();
                        comboBox.DataSource = vs.PostFactors;
                        comboBox.DisplayMember = "Text";
                        comboBox.ValueMember = "TextShort";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValueServices vs = new ValueServices();
            if (UserInputWhitout.Text != String.Empty) result.Text = vs.GetDisplayValue(Convert.ToDecimal(UserInputWhitout.Text), Convert.ToInt32(precision.Value), (string)comboBox.SelectedValue);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValueServices vs = new ValueServices();
            if (UserInput.Text != String.Empty) result.Text = Convert.ToString(vs.GetDecimal(UserInput.Text));
        }
        private void ValueChanged(object sender, EventArgs e)
        {
            if (UserInputWhitout.Text != String.Empty) button1_Click(sender, e);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (result.Text != String.Empty) button1_Click(sender, e);
        }
    }
}