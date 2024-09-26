using Pipe.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe.Views
{
    internal interface IMainForm
    {
        BindingSource PipesBindingSource { get; set; }
        BindingSource FilterBindingSource { get; set; }     

        event EventHandler DeletePipe;
        event EventHandler AddPipe;
        event EventHandler UpdatePipe;
        event EventHandler RefreshTable;

        int TotalCount { set; }
        int NonDefectiveCount { set; }
        int DefectiveCount { set; }
        decimal TotalWeight { set; }
        Filter SelectedFilter { get; }
    }
}
