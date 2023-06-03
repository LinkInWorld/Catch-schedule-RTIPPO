using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    internal class MunicipalContractController
    {
        public User user;
        public DataTable table = new DataTable();

        public DataTable getListMunicipalContract(User user)
        {
            this.user = user;
            MainForm form = new MainForm(user);
            table = DB.ListMunicipalContractsSelect(user);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";
            return table;
            
        }

        public DataTable getListOrganization()
        {

            table = DB.ListOrganizationNameSelect();
            return table;
        }

        public DataTable CreateMunicipalContract(ArrayList record)
        {

            DB.SelectCreateMunicipalContract(record);
            return getListMunicipalContract(user);
        }
    }
}
