using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace lab6
{
    public partial class PlanScheduleCardForm : Form
    {
        public DataTable table;
        public User user;

        PlanScheduleController planSchController = new PlanScheduleController();
        public PlanScheduleCardForm(DataTable table, User user)
        { 
            this.table = table;
            this.user = user;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            table = planSchController.getListPlanScheduleUpdated(user, Convert.ToInt32(textBox1.Text), new ArrayList { comboBox2.SelectedItem, comboBox1.SelectedItem , textBox4.Text, textBox2.Text });
            main.dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanScheduleCardForm_Load(object sender, EventArgs e)
        {
            List<string> localityList = planSchController.getListlocality();
            
            comboBox2.DataSource = localityList;
            foreach (DataRow row in table.Rows)
            {
                textBox1.Text = row[0].ToString();
                comboBox2.SelectedItem = row[1].ToString();
                comboBox1.SelectedItem = row[2].ToString();
                textBox4.Text = row[3].ToString();
                textBox2.Text = row[4].ToString();
            }
            userRoleLabel1.Text = user.role.name;
            if (user.role.name != "Оператор по отлову")
            {
                button3.Enabled = false;
                userRoleLabel2.Text = "Нет";
            }
            else
            {
                button3.Enabled = true;
                userRoleLabel2.Text = "Редактирование";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AttachPDF();
        }
        private void AttachPDF()
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = OPF.FileName;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
