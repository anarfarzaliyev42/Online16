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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
       static List<User> users = new List<User>()
            {
                new User()
                {
                    Username="Vader",
                    Password="123"
                },
                new User()
                {
                    Username="Lucy",
                    Password="12345"
                }

            };

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var item in users)
            {
                if (item.Username == textBox1.Text && item.Password == textBox2.Text)
                {
                    Form2 form2 = new Form2(); 
                    form2.SendData(item.Username);
                    form2.ShowDialog();
                   
                    
                    return;
                }
            }
            linkLabel1.Visible = true;
          
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            
        }
        public void AddUser(string username,string password)
        {
           
            users.Add(new User()
            {
                Username = username,
                Password = password
            });

            
        }
    }
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
