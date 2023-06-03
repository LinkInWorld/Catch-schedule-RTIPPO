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
using System.Collections;

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
            dataGridView3.DataSource = table;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = controller.getListOrganizationContract();

            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = controller.getListPlanSchedule();

            //controller.getListPlanScheduleInserted(new ArrayList { "Тюмень", "May", "2077" });
            //controller.getListPlanScheduleUpdated(2,new ArrayList{"Тюмень", "May","2027"});
            //controller.getListPlanScheduleDeleted(2);
            //catchScheduleComboBox1.DataSource= table;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
        }


    }
}
