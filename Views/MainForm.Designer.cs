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
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDefective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PipeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PipesDGW)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PipesDGW
            // 
            this.PipesDGW.AllowUserToAddRows = false;
            this.PipesDGW.AllowUserToDeleteRows = false;
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
            this.PipeId});
            this.PipesDGW.Location = new System.Drawing.Point(12, 66);
            this.PipesDGW.Name = "PipesDGW";
            this.PipesDGW.ReadOnly = true;
            this.PipesDGW.RowHeadersVisible = false;
            this.PipesDGW.RowHeadersWidth = 49;
            this.PipesDGW.RowTemplate.Height = 24;
            this.PipesDGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PipesDGW.Size = new System.Drawing.Size(934, 482);
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
            this.panel1.Location = new System.Drawing.Point(12, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 34);
            this.panel1.TabIndex = 1;
            // 
            // DefectiveCountLabel
            // 
            this.DefectiveCountLabel.AutoSize = true;
            this.DefectiveCountLabel.Location = new System.Drawing.Point(310, 7);
            this.DefectiveCountLabel.Name = "DefectiveCountLabel";
            this.DefectiveCountLabel.Size = new System.Drawing.Size(16, 16);
            this.DefectiveCountLabel.TabIndex = 7;
            this.DefectiveCountLabel.Text = "...";
            // 
            // NonDefectiveCountLabel
            // 
            this.NonDefectiveCountLabel.AutoSize = true;
            this.NonDefectiveCountLabel.Location = new System.Drawing.Point(188, 7);
            this.NonDefectiveCountLabel.Name = "NonDefectiveCountLabel";
            this.NonDefectiveCountLabel.Size = new System.Drawing.Size(16, 16);
            this.NonDefectiveCountLabel.TabIndex = 6;
            this.NonDefectiveCountLabel.Text = "...";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.AutoSize = true;
            this.TotalCountLabel.Location = new System.Drawing.Point(62, 7);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(16, 16);
            this.TotalCountLabel.TabIndex = 5;
            this.TotalCountLabel.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Брак:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Годные:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Общее:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Общий:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Вес";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TotalWeightLabel);
            this.panel2.Location = new System.Drawing.Point(390, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 34);
            this.panel2.TabIndex = 4;
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.AutoSize = true;
            this.TotalWeightLabel.Location = new System.Drawing.Point(62, 7);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(16, 16);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 58);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.UpdateToolStripMenuItem.Text = "Изменить";
            // 
            // AddPipeBtn
            // 
            this.AddPipeBtn.Location = new System.Drawing.Point(12, 29);
            this.AddPipeBtn.Name = "AddPipeBtn";
            this.AddPipeBtn.Size = new System.Drawing.Size(85, 31);
            this.AddPipeBtn.TabIndex = 5;
            this.AddPipeBtn.Text = "Добавить";
            this.AddPipeBtn.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.AddPipeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PipesDGW);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.PipesDGW)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PipeId;
    }
}