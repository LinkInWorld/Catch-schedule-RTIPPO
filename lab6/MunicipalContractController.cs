using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;
using DataTable = System.Data.DataTable;

namespace lab6
{
    internal class MunicipalContractController
    {
        public User user;
        public DataTable table = new DataTable();
        public string filt;

        public DataTable getListMunicipalContract(User user, string filt)
        {
            this.user = user;
            MainForm form = new MainForm(user);
            table = DB.ListMunicipalContractsSelect(user, filt);
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

        public DataTable getListLocaity()
        {
            table = DB.ListLocalitySelectid_Locality();
            return table;
        }

        public DataTable CreateMunicipalContract(ArrayList record, ArrayList arrayLocalityContract)
        {

            DB.SelectCreateMunicipalContract(record, arrayLocalityContract);
            table = DB.ListMunicipalContractsSelect(user, filt);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";
            return table;
        }

        public DataTable SelectDeleteMunicipalContract(int id_MunicipalContract, User user)
        {
            DB.SelectDeleteMunicipalContract(id_MunicipalContract);
            table = DB.ListMunicipalContractsSelect(user, filt);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";
            return table;
        }
    }
}
