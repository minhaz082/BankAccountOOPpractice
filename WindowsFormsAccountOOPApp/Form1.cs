using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAccountOOPApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Account aAccount = new Account();
        private void creatButton_Click(object sender, EventArgs e)
        {
            string accNo = accountNoTextBox.Text;
            string CustomerName = customerNameTextBox.Text;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {

        }
    }
}
