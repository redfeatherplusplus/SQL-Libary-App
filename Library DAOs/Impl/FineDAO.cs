using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;

namespace Library_DAOs
{
    public class FineDAO : LibraryDAO, IFineDAO
    {
        public void setPaid(Fine fine)
        {
            throw new NotImplementedException();
        }

        public List<Fine> search(string cardID)
        {
            throw new NotImplementedException();
        }

        public List<Fine> search(string cardID, FineSearchType searchType)
        {
            throw new NotImplementedException();
        }
    }
}
