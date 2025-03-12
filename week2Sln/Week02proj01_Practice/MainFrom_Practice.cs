using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02proj01_Practice
{
    public partial class MainForm_Practice: Form
    {
        public MainForm_Practice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char test1 = '쀍'; //49165
            
            byte result = (byte)test1;
            char test2 = (char)result;
            label1.Text = result.ToString();
        }
    }
}
