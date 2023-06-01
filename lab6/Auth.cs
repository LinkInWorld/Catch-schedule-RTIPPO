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
    public partial class Auth : Form
    {
        Thread th;
        public User user;
        public Auth()
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
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            /*SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM User WHERE Login = @loginUser AND Password = @passUser", db.getConnection());
            cmd.Parameters.AddWithValue("@loginUser", loginUser);
            cmd.Parameters.AddWithValue("@passUser", passUser);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);*/
            string sql = "SELECT *, Role.Name AS Rolename FROM User INNER JOIN Role ON User.id_Role = Role.id_Role WHERE Login = " + loginUser + " AND Password = " + passUser;
            table = db.SelectFromDB(sql);

            
            //label1.Text = user.role.name;
            if (table.Rows.Count > 0)
            {
                user = new User(table);
                //user.role.id;
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


            }
            else
            {
                MessageBox.Show("Ошибка1");
            }
        }

        public void open(object obj)
        {
            Application.Run(new Main(user));
        }
    }
}
