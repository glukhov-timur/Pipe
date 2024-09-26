using Pipe.DTO;
using Pipe.Repo;
using Pipe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pipe.Presenters
{
    public enum Filter
    {
        Все = 0,
        Годные = 1,
        Брак = 2,
    }

    internal class MainPresenter : IMainPresenter
    {
        private IMainForm _mainForm;
        private IMainRepo _mainRepo;
        private BindingSource _pipesBindingSource;
        private BindingSource _filterBindingSource;

        public MainPresenter(IMainForm mainForm)
        {
            _mainForm = mainForm;
            _mainRepo = new MainRepo();

            _pipesBindingSource = new BindingSource();
            _mainForm.PipesBindingSource = _pipesBindingSource;

            _filterBindingSource = new BindingSource();
            _mainForm.FilterBindingSource = _filterBindingSource;

            _mainForm.DeletePipe += DeleteSelectedPipe;
            _mainForm.AddPipe += AddNewPipe;
            _mainForm.UpdatePipe += UpdatePipe;
            _mainForm.RefreshTable += (sender, e) => LoadData();

            LoadFilter();
            LoadData();
        }

        private void LoadFilter()
        {
            _filterBindingSource.DataSource = Enum.GetValues(typeof(Filter));
        }

        private void UpdatePipe(object sender, EventArgs e)
        {
            var selectedPipe = (PipeDTO)_pipesBindingSource.Current;
            IAddOrEditPipe addOrEditForm = new AddOrEditPipe(ModalFormType.Update, selectedPipe, _mainRepo.GetAllSteels());
            addOrEditForm.SavePipe += AddOrEditForm_SavePipe_Update;
            addOrEditForm.ShowDialog();
        }

        private void AddOrEditForm_SavePipe_Update(object sender, EventArgs e)
        {
            _mainRepo.UpdatePipe(((IAddOrEditPipe)sender).NewPipe);
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
            switch (_mainForm.SelectedFilter)
            {
                case Filter.Все:
                    PipeCounting(_mainRepo.GetAllPipes());
                    break;
                case Filter.Годные:
                    PipeCounting(_mainRepo.GetAllPipes(false));
                    break;
                case Filter.Брак:
                    PipeCounting(_mainRepo.GetAllPipes(true));
                    break;
                default:
                    PipeCounting(_mainRepo.GetAllPipes());
                    break;
            }
        }

        private void PipeCounting(IEnumerable<PipeDTO> allPipes)
        {
            _pipesBindingSource.DataSource = allPipes;
            _mainForm.TotalCount = allPipes.Count();
            _mainForm.NonDefectiveCount = allPipes.Where(item => item.IsDefective == "Годная").Count();
            _mainForm.DefectiveCount = allPipes.Where(item => item.IsDefective == "Брак").Count();
            _mainForm.TotalWeight = allPipes.Select(item => item.Weight).Sum();
        }
    }
}
