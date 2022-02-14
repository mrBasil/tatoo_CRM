using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tatoo_CRM.dataBase;

namespace tatoo_CRM
{
    public class MainClass
    {
        public DataBaseContext db { get; set; }

        public MainClass() { 
            db = new DataBaseContext();
        }

    }
}
