using Pipe.DTO;
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

            _mainForm.DeletePipe += DeleteSelectedPipe;
            _mainForm.AddPipe += AddNewPipe;

            LoadData();
        }

        private void AddNewPipe(object sender, EventArgs e)
        {
            IAddOrEditPipe addOrEditForm = new AddOrEditPipe(ModalFormType.Add, null, _mainRepo.GetAllSteels());
            addOrEditForm.SavePipe += AddOrEditForm_SavePipe;
            addOrEditForm.ShowDialog();
        }

        private void AddOrEditForm_SavePipe(object sender, EventArgs e)
        {
            _mainRepo.AddPipe(((IAddOrEditPipe)sender).NewPipe);
            LoadData();
        }

        private void DeleteSelectedPipe(object sender, EventArgs e)
        {
            var selectedPipeId = ((PipeDTO)_pipesBindingSource.Current).PipeId;
            _mainRepo.DeletePipe(selectedPipeId);
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
