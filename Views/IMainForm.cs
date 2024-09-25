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
        int TotalCount { set; }
        int NonDefectiveCount { set; }
        int DefectiveCount { set; }
        int TotalWeight { set; }
    }
}
