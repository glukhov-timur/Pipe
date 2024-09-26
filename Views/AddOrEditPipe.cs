using Pipe.DTO;
using Pipe.Models.Db;
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
    public enum ModalFormType
    {
        Add,
        Update,
    }

    public interface IAddOrEditPipe
    {
        DialogResult ShowDialog();

        PipeModel NewPipe { get; }
        event EventHandler SavePipe;
    }

    public partial class AddOrEditPipe : Form, IAddOrEditPipe
    {
        public event EventHandler SavePipe;
        public PipeModel NewPipe { get; private set; }

        private ModalFormType _modalFormType;
        private PipeDTO _pipeDTO;

        public AddOrEditPipe(ModalFormType modalFormType, PipeDTO pipeDTO, IEnumerable<Steel> steels)
        {
            InitializeComponent();
            InitStyle();
            _modalFormType = modalFormType;
            _pipeDTO = pipeDTO;

            SteelTypeComboBox.DataSource = steels;
            SteelTypeComboBox.DisplayMember = "SteelName";
            SteelTypeComboBox.ValueMember = "Id";

            switch (_modalFormType)
            {
                case ModalFormType.Add:
                    ActionTypeLabel.Text = "Добавить трубу";
                    this.Text = "Добавить трубу";
                    break;
                case ModalFormType.Update:
                    InitPipeEdit();
                    break;
                default:
                    this.Close();
                    break;
            }         
        }

        private void InitStyle()
        {
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitPipeEdit()
        {
            ActionTypeLabel.Text = "Изменить трубу";
            this.Text = "Изменить трубу";
            IsDefectedCheckBox.Checked = _pipeDTO.IsDefectiveBool;
            SteelTypeComboBox.SelectedValue = _pipeDTO.SteelNameId;
            NumberLabel.Text = _pipeDTO.Number.ToString();
            DiameterTB.Text = _pipeDTO.Diameter.ToString();
            ThicknessTB.Text = _pipeDTO.Thickness.ToString();
            LengthTB.Text = _pipeDTO.Length.ToString();
            WeightTB.Text = _pipeDTO.Weight.ToString();
        }

        #region keypress_validating
        private void NumberLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void DiameterTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(DiameterTB.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ThicknessTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(ThicknessTB.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LengthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(LengthTB.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void WeightTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(WeightTB.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        private bool Validate()
        {
            if (Int32.TryParse(NumberLabel.Text, out int number) &&
                Decimal.TryParse(DiameterTB.Text, out decimal diameter) &&
                Decimal.TryParse(ThicknessTB.Text, out decimal thickness) &&
                Decimal.TryParse(LengthTB.Text, out decimal length) &&
                Decimal.TryParse(WeightTB.Text, out decimal weight))
            {
                NewPipe = new PipeModel()
                {
                    Id = (_modalFormType == ModalFormType.Update) ? _pipeDTO.PipeId : 0,
                    Number = number,
                    IsDefective = IsDefectedCheckBox.Checked,
                    SteelId = ((Steel)SteelTypeComboBox.SelectedItem).Id,
                    Diameter = diameter,
                    Thickness = thickness,
                    Length = length,
                    Weight = weight,
                };
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                SavePipe?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка ввода", "Внимание");
            }
        }
    }
}
