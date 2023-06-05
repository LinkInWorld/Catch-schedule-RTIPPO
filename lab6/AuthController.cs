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
        PMFactory PMFactory = new PMFactory();


        public void AythMetod(string loginUser, string passUser) // сделать, чтоб возвращал USer
        {
            table = DB.AuthSelectInBD(loginUser, passUser);
            if (table.Rows.Count > 0)
            {
                user = new User(table);
                PM pm = PMFactory.GetUserPM(user);
                Session.SetContext(user, pm);
                Application.Exit();
                th = new Thread(open); // создавать должна форма
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                bool b = Session.GetCurrentPM().CanUpdate(new MunicipalContract());
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
