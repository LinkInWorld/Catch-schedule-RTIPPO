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
    internal class AuthController
    {
        public User user;
        Thread th;
        DB db = new DB();
        DataTable table = new DataTable();

        public void AythMatod(string loginUser, string passUser)
        {
            string sql = "SELECT *, Role.Name AS Rolename FROM User INNER JOIN Role ON User.id_Role = Role.id_Role WHERE Login = " + loginUser + " AND Password = " + passUser;
            table = db.SelectFromDB(sql);


            //label1.Text = user.role.name;
            if (table.Rows.Count > 0)
            {
                user = new User(table);
                //user.role.id;
                Application.Exit();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Введенные данные не верны!");
            }
        }

        void open(object obj)
        {
            Application.Run(new MainForm());
        }

    }
}
