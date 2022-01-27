using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace culc_katya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public decimal L1=0;
        public decimal K2=0;
        public decimal Cena=34;

        private void button1_Click(object sender,EventArgs e)
        {
            decimal L1=NumericUpDown1.Value;
            decimal K2=NumericUpDown2.Value;
            textBox1.Text=Convert.ToString(L1*K2/100);
            textBox2.Text=Convert.ToString((L1*K2/100)*Cena);

        }
    }
}
