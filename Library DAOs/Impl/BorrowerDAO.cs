using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;
using Library_DAOs.SQL;

namespace Library_DAOs
{
    public class BorrowerDAO : LibraryDAO, IBorrowerDAO
    {
        public void insert(Borrower borrower)
        {
            string query = Queries.BorrowerInsert(borrower);
            ExecuteNonQuery(query);
        }
    }
}
