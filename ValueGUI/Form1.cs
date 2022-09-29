using System.Drawing.Design;
using System.Linq.Expressions;
using ValueService.Lib;
using static ValueService.Lib.ValueServices;

namespace ValueGUI
{
    public partial class Form1 : Form
    {
        private static IValueService _vs;

        public Form1(IValueService ValueService)
        {
            _vs = ValueService;
            InitializeComponent();
            initComboBox();
        }

        private void initComboBox()
        {
                        comboBox.DataSource = _vs.PostFactors;
                        comboBox.DisplayMember = "Text";
                        comboBox.ValueMember = "TextShort";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserInputWhitout.Text != String.Empty ) result.Text = _vs.GetDisplayValue(Convert.ToDecimal(UserInputWhitout.Text), Convert.ToInt32(precision.Value), (string)comboBox.SelectedValue);
                else result.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error wrong format");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (UserInput.Text != String.Empty) result.Text = Convert.ToString(_vs.GetDecimal(UserInput.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("please enter one of the following Postfactors: " + _vs.PostFactors.Select(x => x.TextShort).Aggregate((x, y) => x + ", " + y));
            }

           
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