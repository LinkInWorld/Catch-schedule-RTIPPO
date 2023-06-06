using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace lab6
{
    internal class MunicipalContractController
    {
        public User user = Session.GetCurrentUser();
        public PMFactory PMFactory = new PMFactory();
        public DataTable table = new DataTable();
        public string filt;
        Thread th;

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
            filt = "";
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
            filt = "";
            DB.SelectDeleteMunicipalContract(id_MunicipalContract);
            table = DB.ListMunicipalContractsSelect(user, filt);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";
            return table;
        }

        public DataTable DeleteMunicipalContract(MunicipalContract municipalContract)
        {
            PM pm = PMFactory.GetUserPM(user);

            MessageBox.Show(pm.ToString());
            return table;
        }

        public void ViewMunicipalConrtactCard()
        {
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void open(object obj)
        {
            Application.Run(new MunicipalContractCard());
        }
    }
}
