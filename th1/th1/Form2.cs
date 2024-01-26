using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fs = new Form1();
            fs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fs = new Form3();
            fs.ShowDialog();
        }
    }
  
}
