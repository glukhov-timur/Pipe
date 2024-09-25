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
        public int Diameter { get; set; }
        public int Thickness { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
    }
}
