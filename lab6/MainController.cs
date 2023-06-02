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
        DB db = new DB();
        public DataTable table = new DataTable();

        public DataTable getListMunicipalContract()
        {
            table = db.ListMunicipalContractsSelect();

            return table;
            /* Это не стирать
            form.dataGridView1.DataSource = table;
            form.dataGridView1.Columns[0].Visible = false;
            form.dataGridView1.Update();*/
        }
        public DataTable getListOrganizationContract()
        {
            table = db.ListOrganizationSelect();

            return table;
        }
        public DataTable getListPlanSchedule()
        {
            table = db.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleDeleted(int idSelectedPlanSchedule)
        {
            
            db.ListPlanScheduleDelete(idSelectedPlanSchedule);
            table = db.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleInserted(ArrayList record)
        {

            db.ListPlanScheduleInsert(record);
            table = db.ListPlanScheduleSelect();
            return table;
        }
        public DataTable getListPlanScheduleUpdated(int idSelectedPlanSchedule,ArrayList record)
        {

            db.ListPlanScheduleUpdate(idSelectedPlanSchedule, record);
            table = db.ListPlanScheduleSelect();
            return table;
        }
    }
}
