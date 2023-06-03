using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab6
{
    public class MainController
    {
        public User user;
        public DataTable table = new DataTable();

        public DataTable getListMunicipalContract(User user)
        {
            table = DB.ListMunicipalContractsSelect(user);
            table.Columns["Number"].ColumnName = "Номер";
            table.Columns["Date_of_conclusion"].ColumnName = "Дата Заключения";
            table.Columns["Date_of_execution"].ColumnName = "Дата действия";
            table.Columns["Customer"].ColumnName = "Заказчик";
            table.Columns["Executor"].ColumnName = "Исполнитель";

            return table;
            /* Это не стирать
            form.dataGridView1.DataSource = table;
            form.dataGridView1.Columns[0].Visible = false;
            form.dataGridView1.Update();*/
        }
        public DataTable getListOrganizationContract()
        {
            table = DB.ListOrganizationSelect();

            return table;
        }
        public DataTable getListPlanSchedule()
        {
            table = DB.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleDeleted(int idSelectedPlanSchedule)
        {

            DB.ListPlanScheduleDelete(idSelectedPlanSchedule);
            table = DB.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleInserted(ArrayList record)
        {

            DB.ListPlanScheduleInsert(record);
            table = DB.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleUpdated(int idSelectedPlanSchedule,ArrayList record)
        {

            DB.ListPlanScheduleUpdate(idSelectedPlanSchedule, record);
            table = DB.ListPlanScheduleSelect();
            return table;
        }
        public List<string> getListlocality()
        {
            List<string> lst = new List<string>();
            table = DB.ListLocaitySelect();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                lst.Add(table.Rows[i][0].ToString());
            }
            
            return lst;
        }
        public DataTable CreateMunicipalContract(ArrayList record)
        {

            DB.SelectCreateMunicipalContract(record);
            return getListMunicipalContract();
        }
    }
}
