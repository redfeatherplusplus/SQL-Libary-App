using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public enum FineSearchType { PaidOrUnpaid, Paid, Unpaid };

    public interface IFineDAO
    {
        void setPaid(Fine fine);
        List<Fine> search(String cardID);
        List<Fine> search(String cardID, FineSearchType searchType);
    }
}
