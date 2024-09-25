using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe.Views
{
    public partial class MainForm : Form, IMainForm
    {
        #region properties
        private BindingSource _pipesBindingSource;
        public BindingSource PipesBindingSource
        {
            get
            {
                return _pipesBindingSource;
            }
            set
            {
                _pipesBindingSource = value;
                PipesDGW.DataSource = _pipesBindingSource;
            }
        }

        public int TotalCount { set => TotalCountLabel.Text = value.ToString(); }
        public int NonDefectiveCount { set => NonDefectiveCountLabel.Text = value.ToString(); }
        public int DefectiveCount { set => DefectiveCountLabel.Text = value.ToString(); }
        public int TotalWeight { set => TotalWeightLabel.Text = value.ToString(); }

        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void PipesDGW_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grd = sender as DataGridView;
            if (grd.Rows[e.RowIndex].Cells[2].Value.ToString() == "Брак")
            {
                grd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

        }
    }
}
