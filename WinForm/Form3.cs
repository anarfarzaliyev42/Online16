using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
          
            if (textBox2.Text == textBox3.Text)
            {
                form1.AddUser(textBox1.Text, textBox2.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Password not same");
            }
          
        }
    }
}
