using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DAO_Mediator
{
    public class DAO_ErrorHandler
    {
        private static readonly DAO_ErrorHandler instance = new DAO_ErrorHandler();  //singleton instance

        private DAO_ErrorHandler() { }

        //getters and setters
        public static DAO_ErrorHandler Instance
        {
            get { return DAO_ErrorHandler.instance; }
        }
    }
}
