using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public class Controller
    {
        private static readonly Controller instance = new Controller();  //singleton instance

        private Controller() { }

        //getters and setters
        public static Controller Instance
        {
            get { return Controller.instance; }
        } 
    }
}
