using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        int AddResult, SubResult, MultResult, DivResult;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            AddResult = Convert.ToInt32(Convert.ToInt32(FirstNumTextBox.Text) + Convert.ToInt32(SecondNumTextBox.Text));
            ResultTextBox.Text = Convert.ToString(AddResult);
        }

        private void SUBbutton_Click(object sender, EventArgs e)
        {
            SubResult = Convert.ToInt32(Convert.ToInt32(FirstNumTextBox.Text) - Convert.ToInt32(SecondNumTextBox.Text));
            ResultTextBox.Text = Convert.ToString(SubResult);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //DivResult = Convert.ToInt32((Convert.ToInt32(FirstNumTextBox.Text )) / (Convert.ToInt32(SecondNumTextBox.Text)));
            //ResultTextBox.Text = Convert.ToString(DivResult);
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            FirstNumTextBox.Text = string.Empty;
            SecondNumTextBox.Text = string.Empty;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {

        }

        private void MULTbutton_Click(object sender, EventArgs e)
        {
            MultResult = Convert.ToInt32(Convert.ToInt32(FirstNumTextBox.Text) * Convert.ToInt32(SecondNumTextBox.Text));
            ResultTextBox.Text = Convert.ToString(MultResult);
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            //ResultTextBox.Text = Convert.ToString(AddResult);
            //ResultTextBox.Text = Convert.ToString(SubResult);
            //ResultTextBox.Text = Convert.ToString(MultResult);
        }
    }
}
