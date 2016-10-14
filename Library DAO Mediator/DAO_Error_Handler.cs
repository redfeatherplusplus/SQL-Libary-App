using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Library_DAO_Mediator
{
    public class DAO_Error_Handler
    {
        private static readonly DAO_Error_Handler instance = new DAO_Error_Handler();

        private DAO_Error_Handler() { }

        //getters and setters
        public static DAO_Error_Handler Instance
        {
            get { return DAO_Error_Handler.instance; }
        }

        public string getMessage(Exception exception) 
        {
            string message = exception.Message;

            if (message.Contains("\'uk_Borrower_Ssn\'"))
            {
                message = "Only one card per Ssn allowed.";
            }
            else if (message.Contains("\'fk_Book_Loans_Isbn\'"))
            {
                message = "No book exists for that Isbn.";
            }
            else if (message.Contains("Column \'Ssn\' cannot be null"))
            {
                message = "Ssn field cannot be empty.";
            }
            else if (message.Contains("Column \'Fname\' cannot be null"))
            {
                message = "First name field cannot be empty.";
            }
            else if (message.Contains("Column \'Lname\' cannot be null"))
            {
                message = "Last name field cannot be empty.";
            }
            else if (message.Contains("Column \'Address\' cannot be null"))
            {
                message = "Address field cannot be empty.";
            }
            else if (message.Contains("You have an error"))
            {
                message = "Invalid input, please input missing field(s).";
            }

            return message;
        }
    }
}