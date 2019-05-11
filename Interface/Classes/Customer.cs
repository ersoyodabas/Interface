using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class Customer :  IMainInterface
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Email{ get; set; }


        public bool Insert()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public DataTable GetList()
        {
            return new DataTable();
        }

        public string ShowMessage()
        {
            return "Müşteri mesajı";
        }
    }
}
