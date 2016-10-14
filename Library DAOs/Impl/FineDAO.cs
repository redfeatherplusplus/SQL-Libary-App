using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library_Entities;
using Library_DAOs.SQL;

namespace Library_DAOs
{
    public class FineDAO : LibraryDAO, IFineDAO
    {
        public FineDAO() { }

        public void setPaid(int loanID)
        {
            string query = Queries.FineSetPaid(loanID);
            ExecuteNonQuery(query);
        }

        public List<Fine> search(string cardID)
        {
            return search(cardID, FineSearchType.Unpaid);
        }

        public List<Fine> search(string cardID, FineSearchType searchType)
        {
            List<Fine> fines = new List<Fine>();

            string query = Queries.FineSearch(cardID, searchType);
            ReaderCallback readerCallback = reader =>
            {
                while (reader.Read())
                {
                    Fine fine = new Fine();

                    fine.Title = reader.GetString(Tables.Book.Title).Trim();
                    fine.Fine_amt = reader.GetDecimal(Tables.Fines.Fine_amt);
                    fine.Loan_id = reader.GetInt32(Tables.Fines.Loan_id);
                    fine.Paid = reader.GetBoolean(Tables.Fines.Paid);

                    fines.Add(fine);
                }
            };
            ExecuteReader(query, readerCallback);

            //Console.WriteLine("Fine Count: " + fines.Count + "\n");
            //foreach (Fine fine in fines)
            //{
            //    Console.WriteLine(fine.ToString());
            //}

            return fines;
        }
    }
}
