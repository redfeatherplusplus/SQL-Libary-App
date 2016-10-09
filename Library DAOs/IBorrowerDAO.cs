using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public interface IBorrowerDAO
    {
        void insert(Borrower borrower);
    }
}
