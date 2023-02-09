using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] Matrix1,Matrix2,AddMatrix, MinusMatrix;

        private void button3_Click(object sender, EventArgs e)
        {
            int RowSize= int.Parse(textBox1.Text);
            int ColSize= int.Parse(textBox2.Text);

            AddMatrix = new int[RowSize, ColSize];
            for (int i = 0; i < RowSize; ++i)
            {
                string rowTxt = " ";
                for (int j =0;j<ColSize; ++j)
                {
                    AddMatrix[i,j]= Matrix1[i, j] + Matrix2[i, j];
                    rowTxt += AddMatrix[i, j] + " ";
                }
               listBox3.Items.Add(rowTxt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse(textBox1.Text);
            int ColSize = int.Parse(textBox2.Text);

            MinusMatrix = new int[RowSize, ColSize];
            for (int i = 0; i < RowSize; ++i)
            {
                string rowTxt = " ";
                for (int j = 0; j < ColSize; ++j)
                {
                    MinusMatrix[i, j] = Matrix1[i, j] - Matrix2[i, j];
                    rowTxt += MinusMatrix[i, j] + " ";
                }
                listBox6.Items.Add(rowTxt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse(textBox1.Text);
            int ColSize = int.Parse(textBox2.Text);

            Matrix2 = new int[RowSize, ColSize];
            for (int i = 0; i < RowSize; ++i)
            {
                string rowTxt = "";
                for (int j = 0; j < ColSize; ++j)
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("แถวที่" + i + "หลักที่" + j, "Matrix2", "0", 0, 0);
                    Matrix2[i, j] = int.Parse(data);
                    rowTxt += data + " ";
                }
                listBox2.Items.Add(rowTxt);
                listBox5.Items.Add(rowTxt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowSize = int.Parse(textBox1.Text);
            int ColSize = int.Parse(textBox2.Text);

            Matrix1 = new int[RowSize, ColSize];
            for (int i= 0;i<RowSize;++i)
            {
                string rowTxt = "";
                for (int j=0;j<ColSize;++j)
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("แถวที่" + i + "หลักที่" + j, "Matrix1", "0", 0, 0);
                    Matrix1[i, j] = int.Parse(data);
                    rowTxt += data+" ";
                }
                listBox1.Items.Add(rowTxt);
                listBox4.Items.Add(rowTxt);
            }
        }
    }
}
