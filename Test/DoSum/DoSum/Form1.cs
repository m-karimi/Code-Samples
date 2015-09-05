using System;
using System.Windows.Forms;

namespace DoSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumBTN_Click(object sender, EventArgs e)
        {
            Calculator calculator=new Calculator();
            MessageBox.Show(calculator.Sum(int.MaxValue,1).ToString());
        }

       

    }
}
