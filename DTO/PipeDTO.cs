using Pipe.Models.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe.DTO
{
    public class PipeDTO
    {
        public long PipeId { get; set; }
        public int Number { get; set; }
        public string IsDefective { get; set; }
        public bool IsDefectiveBool { get; set; }
        public string SteelName { get; set; }
        public long SteelNameId { get; set; }
        public decimal Diameter { get; set; }
        public decimal Thickness { get; set; }
        public decimal Length { get; set; }
        public decimal Weight { get; set; }
        public long? PacketId { get; set; }
        public int? PacketNumber { get; set; }
    }
}
