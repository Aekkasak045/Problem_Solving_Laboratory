using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = Microsoft.VisualBasic.Interaction.InputBox ("ใส่เลข 1 ตัว ที่ต้องการหอผมคูณ","รัยค่าตัวเลขจากตีย์บอร์ด", "", 0, 0);
            int num = int.Parse(data);
            int[] NumArray = new int[12];
            for (int i=0; i < 12; i++)
            {
                int j = i + 1;
                NumArray[i] = num * j;
                string txt = "ผลคูณ" + num + "คูณกับ" + j + "เท่ากับ" + NumArray[i];
                listBox1.Items.Add(txt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
