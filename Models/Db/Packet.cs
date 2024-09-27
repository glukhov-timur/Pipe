using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe.Models.Db
{
    public class Packet
    {
        public long Id { get; set; }
        public int PacketNumber { get; set; }
        public DateTime PacketDate { get; set; }

        public List<PipeModel> Pipes { get; set; } = new List<PipeModel>();
    }
}
