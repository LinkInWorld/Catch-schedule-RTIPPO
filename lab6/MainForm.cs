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
using System.Text.RegularExpressions;

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
            List<string> localityList= controller.getListlocality();
            //controller.getListPlanScheduleInserted(new ArrayList { "Тюмень", "May", "2077" });
            //controller.getListPlanScheduleUpdated(2,new ArrayList{"Тюмень", "May","2027"});
            //controller.getListPlanScheduleDeleted(2);
            catchScheduleComboBox1.DataSource= localityList;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void catchPlanScheduleButton1_Click(object sender, EventArgs e)
        {
            // Добавление
            Regex regex = new Regex("^\\d{4}$");
            if (regex.IsMatch(catchSheduleTextBox1.Text))
            {
                controller.getListPlanScheduleInserted(new ArrayList { catchScheduleComboBox1.Text, catchScheduleComboBox2.Text, catchSheduleTextBox1.Text });
                ExceptionLabel1.Text = "Успех!";

            }
            else
                ExceptionLabel1.Text = "Некорректный формат года";
            table = controller.getListPlanSchedule();
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
        }
    }
}
