using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmanager
{
    public class LoggerModel
    {
        public string Method { get; set; }
        public string Database { get; set; }
        public string OperationType { get; set; }
        public string OperationTime { get; set; }
        public string IsSuccess { get; set; }
        public string SystemRemarks { get; set; }
    }
}
