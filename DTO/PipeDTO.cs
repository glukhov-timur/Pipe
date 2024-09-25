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
        public string SteelName { get; set; }
        public int Diameter { get; set; }
        public int Thickness { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
    }
}
