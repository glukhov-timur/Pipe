using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Pipe.Models.Db
{
    public class PipeModel
    {
        public long Id { get; set; }
        public int Number { get; set; }
        public bool IsDefective { get; set; }
        public long SteelId { get; set; }
        [ForeignKey("SteelId")]
        public Steel Steel { get; set; }
        public decimal Diameter { get; set; }
        public decimal Thickness { get; set; }
        public decimal Length { get; set; }
        public decimal Weight { get; set; }
        public long? PacketId { get; set; }
        [ForeignKey("PacketId")]
        public Packet Packet { get; set; }
    }
}
