using Pipe.DTO;
using Pipe.Presenters;
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
        public event EventHandler DeletePipe;
        public event EventHandler AddPipe;
        public event EventHandler UpdatePipe;
        public event EventHandler RefreshTable;

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

        private BindingSource _filterBindingSource;
        public BindingSource FilterBindingSource
        {
            get
            {
                return _filterBindingSource;
            }
            set
            {
                _filterBindingSource = value;
                FilterCB.DataSource = _filterBindingSource;
            }
        }

        public int TotalCount { set => TotalCountLabel.Text = value.ToString(); }
        public int NonDefectiveCount { set => NonDefectiveCountLabel.Text = value.ToString(); }
        public int DefectiveCount { set => DefectiveCountLabel.Text = value.ToString(); }
        public decimal TotalWeight { set => TotalWeightLabel.Text = value.ToString(); }

        public Filter SelectedFilter { get; private set; }

        #endregion
        public MainForm()
        {
            InitializeComponent();
            Init();
            BindLocalEvents();
        }

        private void Init()
        {
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            PipesDGW.ContextMenuStrip = contextMenuStrip1;
        }

        private void BindLocalEvents()
        {
            DeleteToolStripMenuItem.Click += delegate { DeletePipe?.Invoke(this, EventArgs.Empty); };
            UpdateToolStripMenuItem.Click += delegate { UpdatePipe?.Invoke(this, EventArgs.Empty); };
            AddPipeBtn.Click += delegate { AddPipe?.Invoke(this, EventArgs.Empty); };
            FilterCB.SelectedIndexChanged += delegate 
            {
                SelectedFilter = (Filter)FilterCB.SelectedItem;
                RefreshTable?.Invoke(this, EventArgs.Empty); 
            };
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
