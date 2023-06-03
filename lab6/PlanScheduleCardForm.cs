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
        MainController controller = new MainController();
        public PlanScheduleCardForm(DataTable table)
        { 
            this.table = table;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanScheduleCardForm_Load(object sender, EventArgs e)
        {
            List<string> localityList = controller.getListlocality();
            
            comboBox2.DataSource = localityList;
            foreach (DataRow row in table.Rows)
            {
                textBox1.Text = row[0].ToString();
                comboBox2.SelectedItem = row[1].ToString();
                comboBox1.SelectedItem = row[2].ToString();
                textBox4.Text = row[3].ToString();
                
            }
            MessageBox.Show(table.Rows.Count.ToString());
            
            //ArrayList record = controller.record;
            
            //comboBox2.SelectedItem = record[1].ToString();
            //comboBox1.SelectedItem = record[2].ToString();
            //textBox4.Text= record[3].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
