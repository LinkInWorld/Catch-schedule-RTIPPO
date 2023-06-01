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
    public partial class MainForm : Form
    {
        public User user;
        MainController controller;
        public MainForm()
        {
            this.user = user;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            controller.getListMunicipalContract();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.getListOrganizationt();
        }
    }
}
