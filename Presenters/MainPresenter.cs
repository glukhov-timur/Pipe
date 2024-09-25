using Pipe.Repo;
using Pipe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe.Presenters
{
    internal class MainPresenter : IMainPresenter
    {
        private IMainForm _mainForm;
        private IMainRepo _mainRepo;
        private BindingSource _pipesBindingSource;

        public MainPresenter(IMainForm mainForm)
        {
            _mainForm = mainForm;
            _mainRepo = new MainRepo();

            _pipesBindingSource = new BindingSource();
            _mainForm.PipesBindingSource = _pipesBindingSource;

            LoadData();
        }

        private void LoadData()
        {
            var allPipes = _mainRepo.GetAllPipes();
            _pipesBindingSource.DataSource = allPipes;
            _mainForm.TotalCount = allPipes.Count();
            _mainForm.NonDefectiveCount = allPipes.Where(item => item.IsDefective == "Годная").Count();
            _mainForm.DefectiveCount = allPipes.Where(item => item.IsDefective == "Брак").Count();
            _mainForm.TotalWeight = allPipes.Select(item => item.Weight).Sum();
        }
    }
}
