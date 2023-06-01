using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace lab6
{
    public class MunicipalContract
    {
        public int id;
        public int number;
        public DateTime dateOfConclusion;
        public DateTime dateOfExecotion;
        public int customer;
        public int executor;

        public MunicipalContract(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                id = int.Parse(row[0].ToString());
                number = int.Parse(row[1].ToString());
                dateOfConclusion = DateTime.Parse(row[2].ToString());
                dateOfExecotion = DateTime.Parse(row[3].ToString());
                customer = int.Parse(row[4].ToString());
                executor = int.Parse(row[5].ToString());
            }

        }

    }
}
