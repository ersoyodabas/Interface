using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public interface IMainInterface
    {
        bool Insert();
        bool Update();
        bool Delete();
        DataTable GetList();
        string ShowMessage();

    }
}
