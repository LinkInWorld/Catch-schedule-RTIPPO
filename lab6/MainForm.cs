﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace lab6
{
    public partial class MainForm : Form
    {
        public User user;
        DataTable table = new DataTable();

        MainController controller = new MainController();
        MunicipalContractController MunicipalContractController = new MunicipalContractController();
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        // Таня
        private void button1_Click(object sender, EventArgs e)
        {
            table = MunicipalContractController.getListMunicipalContract(user);

            AddCustomerContract.DataSource = MunicipalContractController.getListOrganization();
            AddCustomerContract.DisplayMember = "Name";
            AddCustomerContract.ValueMember = "id_Organization";
            AddExecutinContract.DataSource = MunicipalContractController.getListOrganization();
            AddExecutinContract.DisplayMember = "Name";
            AddExecutinContract.ValueMember = "id_Organization";
            dataGridView3.DataSource = table;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Update();
            tabControl1.SelectTab(tabPage3);
        }

        private void ButtonCreateMunicipalContract_Click(object sender, EventArgs e)
        {
            MunicipalContractController.CreateMunicipalContract(new ArrayList { AddNomerContract.Text, AddDateConContract.Text, AddDateExeContract.Text, AddDateConContract.Text, AddCustomerContract.SelectedValue.ToString(), AddExecutinContract.SelectedValue.ToString() });
        }

        // Илья
        private void button2_Click(object sender, EventArgs e)
        {
            table = controller.getListOrganizationContract();

            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Update();
            tabControl1.SelectTab(tabPage2);
        }

        //Никита
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
            tabControl1.SelectTab(tabPage1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> localityList = controller.getListlocality();
            catchScheduleComboBox1.DataSource = localityList;
            dataGridView1.DataSource = controller.getListPlanSchedule();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Update();
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        Thread th;
        private void catchPlanScheduleButton4_Click(object sender, EventArgs e)
        {
            
            table = controller.getDataPlanScheduleCard(dataGridView1.SelectedCells[0].Value.ToString());
            PlanScheduleCardForm planScheduleCardForm = new PlanScheduleCardForm(table);
            planScheduleCardForm.Owner= this;
            planScheduleCardForm.ShowDialog();

        }
        private void catchPlanScheduleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string sort = "";
            if (catchPlanScheduleRadioButton1.Checked) sort = catchPlanScheduleRadioButton1.Tag.ToString();
            if (catchPlanScheduleRadioButton2.Checked) sort = catchPlanScheduleRadioButton2.Tag.ToString();
            if (catchPlanScheduleRadioButton3.Checked) sort = catchPlanScheduleRadioButton3.Tag.ToString();
            table = controller.getListPlanScheduleFiltered(catchSheduleTextBox2.Text, sort);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void selectedIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void catchPlanScheduleButton5_Click(object sender, EventArgs e)
        {
            table = controller.getListPlanScheduleDeleted(Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
        }
        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            selectedIdLabel.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }
    }
}
