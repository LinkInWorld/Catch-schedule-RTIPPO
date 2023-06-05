using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class MunicipalContract
    {
        public int id;
        public int number;
        public string dateOfConclusion;
        public string dateOfExecotion;
        public int customer;
        public int executor;

        public MunicipalContract(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                id = int.Parse(row[0].ToString());
                number = int.Parse(row[1].ToString());
                dateOfConclusion = (row[2].ToString());
                dateOfExecotion = (row[3].ToString());
                customer = int.Parse(row[4].ToString());
                executor = int.Parse(row[5].ToString());
            }

        }
        public MunicipalContract()
        {
           

        }

    }
}
