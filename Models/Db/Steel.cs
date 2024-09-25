using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe.Models.Db
{
    public class Steel
    {
        public long Id { get; set; }
        public string SteelName { get; set; }

        public List<PipeModel> Pipes { get; set; } = new List<PipeModel>();
    }
}
