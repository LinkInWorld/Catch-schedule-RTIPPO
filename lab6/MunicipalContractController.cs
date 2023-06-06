using System.Collections;
using System.Threading;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace lab6
{
    internal class MunicipalContractController
    {
        public User user = Session.GetCurrentUser();
        public PM pm = Session.GetCurrentPM();
        
        public DataTable table = new DataTable();
        public string filt;
        Thread th;

        public DataTable getListMunicipalContract(string sort, string filtr)
        {
            bool roleFilter = Session.GetCurrentPM().CanWatchAll(new MunicipalContract());
            table = DB.ListMunicipalContractsSelect(filtr, roleFilter);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";
            table.DefaultView.Sort = sort;
            table = table.DefaultView.ToTable();
            return table;
        }

        public DataTable getListOrganization()
        {
            return DB.ListOrganizationNameSelect();
        }

        public DataTable getListLocaity()
        {
            return DB.ListLocalitySelectid_Locality();
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
            /*PM pm = PMFactory.GetUserPM(user);

            MessageBox.Show(pm.ToString());*/
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
