using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Errors.Models
{
   public class Error
    {
        public int ErrorID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Message { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    }
}
