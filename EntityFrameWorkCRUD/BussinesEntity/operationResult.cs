using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public class operationResult
    {
        public int succes { get; set; }
        public string innerException { get; set; }
        public string errorMessage { get; set; }
        public string AdditionInformation {get; set;}
    }
}
