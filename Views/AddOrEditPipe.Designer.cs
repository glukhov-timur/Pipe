﻿namespace Pipe.Views
{
    partial class AddOrEditPipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiameterTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ThicknessTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LengthTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IsDefectedCheckBox = new System.Windows.Forms.CheckBox();
            this.SteelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ActionTypeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // NumberLabel
            // 
            this.NumberLabel.Location = new System.Drawing.Point(110, 89);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(287, 22);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberLabel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Годность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сталь";
            // 
            // DiameterTB
            // 
            this.DiameterTB.Location = new System.Drawing.Point(110, 171);
            this.DiameterTB.Name = "DiameterTB";
            this.DiameterTB.Size = new System.Drawing.Size(287, 22);
            this.DiameterTB.TabIndex = 8;
            this.DiameterTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiameterTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Диаметр";
            // 
            // ThicknessTB
            // 
            this.ThicknessTB.Location = new System.Drawing.Point(110, 199);
            this.ThicknessTB.Name = "ThicknessTB";
            this.ThicknessTB.Size = new System.Drawing.Size(287, 22);
            this.ThicknessTB.TabIndex = 10;
            this.ThicknessTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThicknessTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Толщина";
            // 
            // LengthTB
            // 
            this.LengthTB.Location = new System.Drawing.Point(110, 227);
            this.LengthTB.Name = "LengthTB";
            this.LengthTB.Size = new System.Drawing.Size(287, 22);
            this.LengthTB.TabIndex = 12;
            this.LengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LengthTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Длина";
            // 
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(110, 255);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(287, 22);
            this.WeightTB.TabIndex = 14;
            this.WeightTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTB_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вес";
            // 
            // IsDefectedCheckBox
            // 
            this.IsDefectedCheckBox.AutoSize = true;
            this.IsDefectedCheckBox.Location = new System.Drawing.Point(110, 115);
            this.IsDefectedCheckBox.Name = "IsDefectedCheckBox";
            this.IsDefectedCheckBox.Size = new System.Drawing.Size(58, 20);
            this.IsDefectedCheckBox.TabIndex = 15;
            this.IsDefectedCheckBox.Text = "Брак";
            this.IsDefectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteelTypeComboBox
            // 
            this.SteelTypeComboBox.FormattingEnabled = true;
            this.SteelTypeComboBox.Location = new System.Drawing.Point(110, 141);
            this.SteelTypeComboBox.Name = "SteelTypeComboBox";
            this.SteelTypeComboBox.Size = new System.Drawing.Size(287, 24);
            this.SteelTypeComboBox.TabIndex = 16;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(110, 304);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(287, 38);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ActionTypeLabel
            // 
            this.ActionTypeLabel.AutoSize = true;
            this.ActionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionTypeLabel.Location = new System.Drawing.Point(25, 20);
            this.ActionTypeLabel.Name = "ActionTypeLabel";
            this.ActionTypeLabel.Size = new System.Drawing.Size(237, 37);
            this.ActionTypeLabel.TabIndex = 18;
            this.ActionTypeLabel.Text = "Добавить трубу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.886957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(107, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "*Дробные значения вводятся через запятую";
            // 
            // AddOrEditPipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 372);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ActionTypeLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SteelTypeComboBox);
            this.Controls.Add(this.IsDefectedCheckBox);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LengthTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ThicknessTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiameterTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditPipe";
            this.Text = "AddOrEditPipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiameterTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ThicknessTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LengthTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox IsDefectedCheckBox;
        private System.Windows.Forms.ComboBox SteelTypeComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ActionTypeLabel;
        private System.Windows.Forms.Label label8;
    }
}