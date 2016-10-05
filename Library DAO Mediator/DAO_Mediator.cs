using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class DAO_Mediator
    {
        private static readonly DAO_Mediator instance = new DAO_Mediator();  //singleton instance

        private DAO_Mediator() { }

        //getters and setters
        public static DAO_Mediator Instance
        {
            get { return DAO_Mediator.instance; }
        } 
    }
}
