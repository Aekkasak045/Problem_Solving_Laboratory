using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            if (checkMod(num1, num2))
            
                MessageBox.Show(num1 + "Succes" + num2);
            
            else
            
                MessageBox.Show(num1 + "Fail" + num2);
        }
        public Boolean checkMod(int a, int b)
        {
            if (a % b != 0)
            {
                return false;
            }
            return true;
        }
    }
}
