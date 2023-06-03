using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class User
    {
        public int id;
        public string surname;
        public string name;
        public string patronymic;
        public int phone;
        public string email;
        public string login;
        public string password;
        public int idOrganization;
        public int role;

        public User(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                id = Convert.ToInt32(row[0].ToString());
                surname = row[1].ToString();
                name = row[2].ToString();
                patronymic = row[3].ToString();
                phone = int.Parse(row[4].ToString());
                email = row[5].ToString();
                login = row[6].ToString();
                password = row[7].ToString();
                idOrganization = Convert.ToInt32(row[8].ToString());
                role = Convert.ToInt32(row[9].ToString());
            }

        }
    }
}
