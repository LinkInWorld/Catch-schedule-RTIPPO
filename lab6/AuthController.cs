using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public class AuthController
    {
        public User user;
        Thread th;
        DataTable table = new DataTable();


        public void AythMetod(string loginUser, string passUser)
        {
            table = DB.AuthSelectInBD(loginUser, passUser);

            if (table.Rows.Count > 0)
            {
                user = new User(table);
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
            Application.Run(new MainForm(user));
        }
    }
}
