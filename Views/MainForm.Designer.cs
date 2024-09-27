namespace Pipe.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PipesDGW = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DefectiveCountLabel = new System.Windows.Forms.Label();
            this.NonDefectiveCountLabel = new System.Windows.Forms.Label();
            this.TotalCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalWeightLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPipeBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDefective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PipeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDefectiveBool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteelNameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PipesDGW)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PipesDGW
            // 
            this.PipesDGW.AllowUserToAddRows = false;
            this.PipesDGW.AllowUserToDeleteRows = false;
            this.PipesDGW.AllowUserToResizeRows = false;
            this.PipesDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PipesDGW.BackgroundColor = System.Drawing.Color.White;
            this.PipesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PipesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.IsDefective,
            this.SteelName,
            this.Diameter,
            this.Thickness,
            this.Length,
            this.Weight,
            this.PipeId,
            this.IsDefectiveBool,
            this.SteelNameId,
            this.PacketId,
            this.PacketNumber});
            this.PipesDGW.Location = new System.Drawing.Point(5, 32);
            this.PipesDGW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipesDGW.Name = "PipesDGW";
            this.PipesDGW.ReadOnly = true;
            this.PipesDGW.RowHeadersVisible = false;
            this.PipesDGW.RowHeadersWidth = 49;
            this.PipesDGW.RowTemplate.Height = 24;
            this.PipesDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PipesDGW.Size = new System.Drawing.Size(700, 392);
            this.PipesDGW.TabIndex = 0;
            this.PipesDGW.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.PipesDGW_RowPrePaint);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DefectiveCountLabel);
            this.panel1.Controls.Add(this.NonDefectiveCountLabel);
            this.panel1.Controls.Add(this.TotalCountLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 28);
            this.panel1.TabIndex = 1;
            // 
            // DefectiveCountLabel
            // 
            this.DefectiveCountLabel.AutoSize = true;
            this.DefectiveCountLabel.Location = new System.Drawing.Point(232, 6);
            this.DefectiveCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DefectiveCountLabel.Name = "DefectiveCountLabel";
            this.DefectiveCountLabel.Size = new System.Drawing.Size(16, 13);
            this.DefectiveCountLabel.TabIndex = 7;
            this.DefectiveCountLabel.Text = "...";
            // 
            // NonDefectiveCountLabel
            // 
            this.NonDefectiveCountLabel.AutoSize = true;
            this.NonDefectiveCountLabel.Location = new System.Drawing.Point(141, 6);
            this.NonDefectiveCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NonDefectiveCountLabel.Name = "NonDefectiveCountLabel";
            this.NonDefectiveCountLabel.Size = new System.Drawing.Size(16, 13);
            this.NonDefectiveCountLabel.TabIndex = 6;
            this.NonDefectiveCountLabel.Text = "...";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.AutoSize = true;
            this.TotalCountLabel.Location = new System.Drawing.Point(46, 6);
            this.TotalCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(16, 13);
            this.TotalCountLabel.TabIndex = 5;
            this.TotalCountLabel.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Брак:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Годные:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общее:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Общий:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Вес";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TotalWeightLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(292, 436);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 28);
            this.panel2.TabIndex = 4;
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.AutoSize = true;
            this.TotalWeightLabel.Location = new System.Drawing.Point(46, 6);
            this.TotalWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(16, 13);
            this.TotalWeightLabel.TabIndex = 6;
            this.TotalWeightLabel.Text = "...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.UpdateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 54);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.UpdateToolStripMenuItem.Text = "Изменить";
            // 
            // AddPipeBtn
            // 
            this.AddPipeBtn.Location = new System.Drawing.Point(5, 2);
            this.AddPipeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPipeBtn.Name = "AddPipeBtn";
            this.AddPipeBtn.Size = new System.Drawing.Size(66, 25);
            this.AddPipeBtn.TabIndex = 5;
            this.AddPipeBtn.Text = "Добавить";
            this.AddPipeBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Фильтр:";
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Location = new System.Drawing.Point(597, 7);
            this.FilterCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(108, 21);
            this.FilterCB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "- брак";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 426);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Обозначения";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(394, 436);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 28);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(11, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 12);
            this.panel4.TabIndex = 11;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // IsDefective
            // 
            this.IsDefective.DataPropertyName = "IsDefective";
            this.IsDefective.HeaderText = "Качество";
            this.IsDefective.MinimumWidth = 6;
            this.IsDefective.Name = "IsDefective";
            this.IsDefective.ReadOnly = true;
            // 
            // SteelName
            // 
            this.SteelName.DataPropertyName = "SteelName";
            this.SteelName.HeaderText = "Сталь";
            this.SteelName.MinimumWidth = 6;
            this.SteelName.Name = "SteelName";
            this.SteelName.ReadOnly = true;
            // 
            // Diameter
            // 
            this.Diameter.DataPropertyName = "Diameter";
            this.Diameter.HeaderText = "Диаметр";
            this.Diameter.MinimumWidth = 6;
            this.Diameter.Name = "Diameter";
            this.Diameter.ReadOnly = true;
            // 
            // Thickness
            // 
            this.Thickness.DataPropertyName = "Thickness";
            this.Thickness.HeaderText = "Толщина";
            this.Thickness.MinimumWidth = 6;
            this.Thickness.Name = "Thickness";
            this.Thickness.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Длина";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // PipeId
            // 
            this.PipeId.DataPropertyName = "PipeId";
            this.PipeId.HeaderText = "PipeId";
            this.PipeId.MinimumWidth = 6;
            this.PipeId.Name = "PipeId";
            this.PipeId.ReadOnly = true;
            this.PipeId.Visible = false;
            // 
            // IsDefectiveBool
            // 
            this.IsDefectiveBool.DataPropertyName = "IsDefectiveBool";
            this.IsDefectiveBool.HeaderText = "IsDefectiveBool";
            this.IsDefectiveBool.MinimumWidth = 6;
            this.IsDefectiveBool.Name = "IsDefectiveBool";
            this.IsDefectiveBool.ReadOnly = true;
            this.IsDefectiveBool.Visible = false;
            // 
            // SteelNameId
            // 
            this.SteelNameId.DataPropertyName = "SteelNameId";
            this.SteelNameId.HeaderText = "SteelNameId";
            this.SteelNameId.MinimumWidth = 6;
            this.SteelNameId.Name = "SteelNameId";
            this.SteelNameId.ReadOnly = true;
            this.SteelNameId.Visible = false;
            // 
            // PacketId
            // 
            this.PacketId.DataPropertyName = "PacketId";
            this.PacketId.HeaderText = "PacketId";
            this.PacketId.Name = "PacketId";
            this.PacketId.ReadOnly = true;
            this.PacketId.Visible = false;
            // 
            // PacketNumber
            // 
            this.PacketNumber.DataPropertyName = "PacketNumber";
            this.PacketNumber.HeaderText = "Пакет";
            this.PacketNumber.Name = "PacketNumber";
            this.PacketNumber.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 493);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddPipeBtn);
            this.tabPage1.Controls.Add(this.PipesDGW);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.FilterCB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование пакетов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 496);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "ТМК++. Тестовое задание";
            ((System.ComponentModel.ISupportInitialize)(this.PipesDGW)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PipesDGW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DefectiveCountLabel;
        private System.Windows.Forms.Label NonDefectiveCountLabel;
        private System.Windows.Forms.Label TotalCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalWeightLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.Button AddPipeBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PipeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDefectiveBool;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelNameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}