using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace Interface.Model
{
    class Product: IMainInterface
    {

        public int Id { get; set; }
        public int Name { get; set; }
        public string Path { get; set; }

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

        public DataTable GetList() {
            return new DataTable();
        }

        public string ShowMessage()
        {
            return "Ürün mesajı";
        }
    }
}
