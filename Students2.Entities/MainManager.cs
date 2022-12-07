using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2.Entities
{
    public class MainManager
    {
        private MainManager() { }

        private static readonly MainManager _Instance = new MainManager();
        public static MainManager Instance { get { return _Instance; } }

        public Customers Cstmrs = new Customers();

        public void Init()
        {
            Cstmrs.LoadCustomers();
        }

        

    }
}
