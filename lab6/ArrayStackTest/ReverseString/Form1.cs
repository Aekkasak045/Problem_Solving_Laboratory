using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            ArrayStack S = new ArrayStack(100);
            string message = inputBox.Text;
            for (int i = 0; i < message.Length; ++i)
            {
                S.push(message[i]);
            }
            string data = "";
            while (!S.isEmpty())
            {
                data = data + S.pop();
            }
            outputBox.Text = data;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
        }
    }
}
