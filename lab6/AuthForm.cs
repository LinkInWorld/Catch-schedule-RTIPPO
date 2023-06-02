using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Infrastructure;
using System.Threading;

namespace lab6
{
    public partial class AuthForm : Form
    {
        Thread th;
        public User user;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AuthController authController = new AuthController();
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            authController.AythMetod(loginUser, passUser);
        }
    }
}
