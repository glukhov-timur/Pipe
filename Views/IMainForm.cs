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

        event EventHandler DeletePipe;
        event EventHandler AddPipe;

        int TotalCount { set; }
        int NonDefectiveCount { set; }
        int DefectiveCount { set; }
        decimal TotalWeight { set; }
    }
}
