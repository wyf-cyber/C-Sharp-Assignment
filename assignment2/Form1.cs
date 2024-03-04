using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Populate ComboBox with operators
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0; // Set default selection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Run calculation
            double operand1, operand2, result;
            // Parse operands from textboxes
            if (!double.TryParse(textBox1.Text, out operand1))
            {
                MessageBox.Show("Invalid value for Operand 1");
                return;
            }
            if (!double.TryParse(textBox2.Text, out operand2))
            {
                MessageBox.Show("Invalid value for Operand 2");
                return;
            }
            // Perform calculation based on selected operator
            string selectedOperator = comboBox1.SelectedItem.ToString();
            switch (selectedOperator)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = operand1 / operand2;
                    break;
                default:
                    MessageBox.Show("Invalid operator");
                    return;
            }
            // Display result
            res.Text = result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Operators
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form load event
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Textbox text changed event
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Label click event
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Label click event
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Label click event
        }
    }
}
