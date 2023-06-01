using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Infrastructure;
using System.Threading;

namespace lab6
{
    internal class MainController
    {
        public User user;
        Thread th;
        DB db = new DB();
        DataTable table = new DataTable();
        MainForm form = new MainForm();

        public void getListMunicipalContract()
        {
            string sql = "SELECT * FROM Municipal_contract";
            table = db.SelectFromDB(sql);

            form.dataGridView1.DataSource = table;
            form.dataGridView1.Columns[0].Visible = false;
            form.dataGridView1.Update();
        }

        public void getListOrganizationt()
        { 
            string sql = "SELECT * FROM Organization";
            table = db.SelectFromDB(sql);

            form.dataGridView1.DataSource = table;
            form.dataGridView1.Columns[0].Visible = false;
            form.dataGridView1.Update();
        }
    }
}
