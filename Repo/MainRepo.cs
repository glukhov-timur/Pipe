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
        IEnumerable<PipeDTO> GetAllPipes();
        IEnumerable<PipeDTO> GetAllPipes(bool isDefective);
        void DeletePipe(long id);
        IEnumerable<Steel> GetAllSteels();
        void AddPipe(PipeModel pipeModel);
        void UpdatePipe(PipeModel pipeModel);
    }

    public class MainRepo : IMainRepo
    {

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
                                     IsDefectiveBool = item.IsDefective,
                                     SteelNameId = item.SteelId,
                                 })
                                 .ToList();
                return allPipes;
            }
        }

        public IEnumerable<PipeDTO> GetAllPipes(bool isDefective)
        {
            using (var db = new PipeContext())
            {
                var allPipes = db.Pipes
                                 .Where(item => item.IsDefective == isDefective)
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
                                     IsDefectiveBool = item.IsDefective,
                                     SteelNameId = item.SteelId,
                                 })
                                 .ToList();
                return allPipes;
            }
        }

        public void DeletePipe(long id)
        {
            using (var db = new PipeContext())
            {
                var pipe = new PipeModel { Id = id };
                db.Pipes.Attach(pipe);
                db.Pipes.Remove(pipe);
                db.SaveChanges();
            }            
        }

        public void AddPipe(PipeModel pipeModel)
        {
            using (var db = new PipeContext())
            {
                db.Pipes.Add(pipeModel);
                db.SaveChanges();
            }
        }

        public void UpdatePipe(PipeModel pipeModel)
        {
            using (var db = new PipeContext())
            {
                var pipe = db.Pipes
                             .Where(item => item.Id == pipeModel.Id)
                             .FirstOrDefault();
                pipe.IsDefective = pipeModel.IsDefective;
                pipe.SteelId = pipeModel.SteelId;
                pipe.Number = pipeModel.Number;
                pipe.Diameter = pipeModel.Diameter;
                pipe.Thickness = pipeModel.Thickness;
                pipe.Length = pipeModel.Length;
                pipe.Weight = pipeModel.Weight;

                db.SaveChanges();
            }
        }

        public IEnumerable<Steel> GetAllSteels()
        {
            using (var db = new PipeContext())
            {
                return db.Steels.ToList();
            }
        }


    }
}
