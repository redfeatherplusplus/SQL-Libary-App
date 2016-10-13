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
            return exception.Message;
        }
    }
}