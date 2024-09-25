using Microsoft.EntityFrameworkCore;
using Pipe.DTO;
using Pipe.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe.Repo
{
    public interface IMainRepo
    {
        Task<IEnumerable<PipeModel>> GetAllPipesAsync();
        IEnumerable<PipeDTO> GetAllPipes();
    }

    public class MainRepo : IMainRepo
    {
        public async Task<IEnumerable<PipeModel>> GetAllPipesAsync()
        {
            using (var db = new PipeContext())
            {
                return await db.Pipes.ToListAsync();
            }
        }

        public IEnumerable<PipeDTO> GetAllPipes()
        {
            using (var db = new PipeContext())
            {
                var allPipes = db.Pipes
                                 .Select(item => new PipeDTO()
                                 {
                                     PipeId = item.Id,
                                     Number = item.Number,
                                     IsDefective = (item.IsDefective) ? "Брак" : "Годная",
                                     SteelName = item.Steel.SteelName,
                                     Diameter = item.Diameter,
                                     Thickness = item.Thickness,
                                     Length = item.Length,
                                     Weight = item.Weight,
                                 })
                                 .ToList();
                return allPipes;
            }
        }
    }
}
