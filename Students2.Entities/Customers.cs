using Students2.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students2.Entities
{
    public class Customers:BaseEntity
    {
        Hashtable CustomersTable = new Hashtable();
        public void LoadCustomers()
        {
            SqlQuery.RunCommandResult("select CustomerID, ContactName from Customers", insertToHashTable);
        }

        public object insertToHashTable(SqlDataReader reader)
        {
            CustomersTable.Clear();
            while(reader.Read())
            {
                Model.Customer newCustomer = new Model.Customer();
                newCustomer.CustomerID = reader.GetString(0);
                newCustomer.ContactName = reader.GetString(1);
                CustomersTable.Add(newCustomer.CustomerID, newCustomer);
            }
            return CustomersTable;
        }

        public void insertNewCustomer(string CustomerID, string ContactName, int Age)
        {
            string s = $"stamstring {5 + 5} Hello {Age}";


            DAL.SqlQuery.RunNonQuery($"insert into Customers (CustomerID, ContactName) values ('{CustomerID}', '{ContactName}') ");
        }
    }
}
