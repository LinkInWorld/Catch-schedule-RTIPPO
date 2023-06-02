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
        DataTable table = new DataTable();

        MainController controller = new MainController();
        public MainForm()
        {
            //this.user = user;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            table = controller.getListMunicipalContract();
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = controller.getListOrganizationContract();

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
        }
    }
}
