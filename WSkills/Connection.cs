using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WSkills
{
    class Connection
    {
        public string text { get; set; }
        public string value { get; set; }
        public override string ToString()
        {
            return this.text;
        }
    }
}
