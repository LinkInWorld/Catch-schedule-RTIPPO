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
        Thread th;
        public DataTable table = new DataTable();

        public DataTable getListMunicipalContract()
        {
            table = DB.ListMunicipalContractsSelect();

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
    }
}
