using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public class MainController
    {
        public User user;
        public DataTable table = new DataTable();

        //Для передачи данных в другую форму
        public ArrayList record = new ArrayList();

        
        public DataTable getListOrganizationContract()
        {
            table = DB.ListOrganizationSelect();

            return table;
        }
        public DataTable getListPlanSchedule(User user)
        {
            
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }
        public DataTable getListPlanScheduleDeleted(int idSelectedPlanSchedule)
        {

            DB.ListPlanScheduleDelete(idSelectedPlanSchedule);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }
        public DataTable getListPlanScheduleInserted(ArrayList record)
        {

            DB.ListPlanScheduleInsert(record);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }
        public DataTable getListPlanScheduleUpdated(int idSelectedPlanSchedule,ArrayList record)
        {

            DB.ListPlanScheduleUpdate(idSelectedPlanSchedule, record);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }
        public DataTable getListPlanScheduleFiltered(string filter, string sort)
        {
            table = DB.ListPlanScheduleFilterSelect(filter, sort);
            return table;
        }
        public DataTable getDataPlanScheduleCard(string idSelectedPlanSchedule)
        {
            //table = DB.ListDataPlanScheduleCard(idSelectedPlanSchedule);
            //ArrayList result = new ArrayList();
            //MessageBox.Show(table.Rows[0][0].ToString() + "  " + table.Rows[0][1].ToString() + "  "+ table.Rows[0][2].ToString() + table.Rows[0][3].ToString());
            //for (int i = 0; i < table.Columns.Count; i++)
            //{
            //    result.Add(table.Rows[i][0].ToString());
            //}
            return DB.ListDataPlanScheduleCard(idSelectedPlanSchedule);
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
    }
}
