﻿using Microsoft.EntityFrameworkCore;
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
        void DeletePipe(long id);
        IEnumerable<Steel> GetAllSteels();
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

        public IEnumerable<Steel> GetAllSteels()
        {
            using (var db = new PipeContext())
            {
                return db.Steels.ToList();
            }
        }


    }
}
