﻿namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    partial class FormGoods
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
            buttonGoMain_KFA = new Button();
            dataGridViewGoods_KFA = new DataGridView();
            buttonExportCVS_KFA = new Button();
            textBoxFindValue_KFA = new TextBox();
            buttonDeleteGood_KFA = new Button();
            buttonImportCSV_KFA = new Button();
            saveFileDialogMatrix_KFA = new SaveFileDialog();
            openFileDialogMatrix_KFA = new OpenFileDialog();
            buttonFindValue_KFA = new Button();
            buttonSearchMiddlePrice_KFA = new Button();
            groupBoxCalculation_KFA = new GroupBox();
            buttonSearchMaxNumber_KFA = new Button();
            buttonSearchMinPrice_KFA = new Button();
            buttonSearchTotalPrice_KFA = new Button();
            textBoxResultCalculation_KFA = new TextBox();
            buttonAddGood_KFA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_KFA).BeginInit();
            groupBoxCalculation_KFA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoMain_KFA
            // 
            buttonGoMain_KFA.Location = new Point(12, 384);
            buttonGoMain_KFA.Name = "buttonGoMain_KFA";
            buttonGoMain_KFA.Size = new Size(179, 54);
            buttonGoMain_KFA.TabIndex = 0;
            buttonGoMain_KFA.Text = "Меню";
            buttonGoMain_KFA.UseVisualStyleBackColor = true;
            buttonGoMain_KFA.Click += buttonGoMain_KFA_Click;
            // 
            // dataGridViewGoods_KFA
            // 
            dataGridViewGoods_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGoods_KFA.Location = new Point(12, 10);
            dataGridViewGoods_KFA.Name = "dataGridViewGoods_KFA";
            dataGridViewGoods_KFA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewGoods_KFA.Size = new Size(745, 223);
            dataGridViewGoods_KFA.TabIndex = 1;
            // 
            // buttonExportCVS_KFA
            // 
            buttonExportCVS_KFA.Location = new Point(123, 239);
            buttonExportCVS_KFA.Name = "buttonExportCVS_KFA";
            buttonExportCVS_KFA.Size = new Size(105, 30);
            buttonExportCVS_KFA.TabIndex = 2;
            buttonExportCVS_KFA.Text = "Save";
            buttonExportCVS_KFA.UseVisualStyleBackColor = true;
            buttonExportCVS_KFA.Click += buttonExportCVS_KFA_Click;
            // 
            // textBoxFindValue_KFA
            // 
            textBoxFindValue_KFA.Location = new Point(12, 314);
            textBoxFindValue_KFA.Name = "textBoxFindValue_KFA";
            textBoxFindValue_KFA.Size = new Size(216, 23);
            textBoxFindValue_KFA.TabIndex = 3;
            // 
            // buttonDeleteGood_KFA
            // 
            buttonDeleteGood_KFA.Location = new Point(13, 343);
            buttonDeleteGood_KFA.Name = "buttonDeleteGood_KFA";
            buttonDeleteGood_KFA.Size = new Size(105, 30);
            buttonDeleteGood_KFA.TabIndex = 4;
            buttonDeleteGood_KFA.Text = "Delete";
            buttonDeleteGood_KFA.UseVisualStyleBackColor = true;
            buttonDeleteGood_KFA.Click += buttonDeleteGood_KFA_Click;
            // 
            // buttonImportCSV_KFA
            // 
            buttonImportCSV_KFA.Location = new Point(248, 417);
            buttonImportCSV_KFA.Name = "buttonImportCSV_KFA";
            buttonImportCSV_KFA.Size = new Size(18, 21);
            buttonImportCSV_KFA.TabIndex = 5;
            buttonImportCSV_KFA.Text = "Import";
            buttonImportCSV_KFA.UseVisualStyleBackColor = true;
            buttonImportCSV_KFA.Visible = false;
            buttonImportCSV_KFA.Click += buttonImportCSV_KFA_Click;
            // 
            // openFileDialogMatrix_KFA
            // 
            openFileDialogMatrix_KFA.FileName = "openFileDialog1";
            // 
            // buttonFindValue_KFA
            // 
            buttonFindValue_KFA.Location = new Point(12, 275);
            buttonFindValue_KFA.Name = "buttonFindValue_KFA";
            buttonFindValue_KFA.Size = new Size(216, 34);
            buttonFindValue_KFA.TabIndex = 6;
            buttonFindValue_KFA.Text = "Найти";
            buttonFindValue_KFA.UseVisualStyleBackColor = true;
            buttonFindValue_KFA.Click += buttonFindValue_KFA_Click;
            // 
            // buttonSearchMiddlePrice_KFA
            // 
            buttonSearchMiddlePrice_KFA.Location = new Point(6, 22);
            buttonSearchMiddlePrice_KFA.Name = "buttonSearchMiddlePrice_KFA";
            buttonSearchMiddlePrice_KFA.Size = new Size(126, 37);
            buttonSearchMiddlePrice_KFA.TabIndex = 7;
            buttonSearchMiddlePrice_KFA.Text = "Средняя цена";
            buttonSearchMiddlePrice_KFA.UseVisualStyleBackColor = true;
            buttonSearchMiddlePrice_KFA.Click += buttonSearchMiddlePrice_KFA_Click;
            // 
            // groupBoxCalculation_KFA
            // 
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMaxNumber_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMinPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchTotalPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(textBoxResultCalculation_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMiddlePrice_KFA);
            groupBoxCalculation_KFA.Location = new Point(473, 250);
            groupBoxCalculation_KFA.Name = "groupBoxCalculation_KFA";
            groupBoxCalculation_KFA.Size = new Size(300, 188);
            groupBoxCalculation_KFA.TabIndex = 8;
            groupBoxCalculation_KFA.TabStop = false;
            groupBoxCalculation_KFA.Text = "Вычисления";
            // 
            // buttonSearchMaxNumber_KFA
            // 
            buttonSearchMaxNumber_KFA.Location = new Point(138, 64);
            buttonSearchMaxNumber_KFA.Name = "buttonSearchMaxNumber_KFA";
            buttonSearchMaxNumber_KFA.Size = new Size(142, 42);
            buttonSearchMaxNumber_KFA.TabIndex = 11;
            buttonSearchMaxNumber_KFA.Text = "Максимальное кол-во";
            buttonSearchMaxNumber_KFA.UseVisualStyleBackColor = true;
            buttonSearchMaxNumber_KFA.Click += buttonSearchMaxNumber_KFA_Click;
            // 
            // buttonSearchMinPrice_KFA
            // 
            buttonSearchMinPrice_KFA.Location = new Point(6, 65);
            buttonSearchMinPrice_KFA.Name = "buttonSearchMinPrice_KFA";
            buttonSearchMinPrice_KFA.Size = new Size(126, 41);
            buttonSearchMinPrice_KFA.TabIndex = 10;
            buttonSearchMinPrice_KFA.Text = "Минимальная цена";
            buttonSearchMinPrice_KFA.UseVisualStyleBackColor = true;
            buttonSearchMinPrice_KFA.Click += buttonSearchMinPrice_KFA_Click;
            // 
            // buttonSearchTotalPrice_KFA
            // 
            buttonSearchTotalPrice_KFA.Location = new Point(138, 22);
            buttonSearchTotalPrice_KFA.Name = "buttonSearchTotalPrice_KFA";
            buttonSearchTotalPrice_KFA.Size = new Size(142, 37);
            buttonSearchTotalPrice_KFA.TabIndex = 9;
            buttonSearchTotalPrice_KFA.Text = "Общая стоимость";
            buttonSearchTotalPrice_KFA.UseVisualStyleBackColor = true;
            buttonSearchTotalPrice_KFA.Click += buttonSearchTotalPrice_KFA_Click;
            // 
            // textBoxResultCalculation_KFA
            // 
            textBoxResultCalculation_KFA.Location = new Point(101, 134);
            textBoxResultCalculation_KFA.Name = "textBoxResultCalculation_KFA";
            textBoxResultCalculation_KFA.ReadOnly = true;
            textBoxResultCalculation_KFA.Size = new Size(100, 23);
            textBoxResultCalculation_KFA.TabIndex = 8;
            // 
            // buttonAddGood_KFA
            // 
            buttonAddGood_KFA.Location = new Point(13, 239);
            buttonAddGood_KFA.Name = "buttonAddGood_KFA";
            buttonAddGood_KFA.Size = new Size(104, 30);
            buttonAddGood_KFA.TabIndex = 9;
            buttonAddGood_KFA.Text = "Add";
            buttonAddGood_KFA.UseVisualStyleBackColor = true;
            buttonAddGood_KFA.Click += buttonAddGood_KFA_Click;
            // 
            // FormGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddGood_KFA);
            Controls.Add(groupBoxCalculation_KFA);
            Controls.Add(buttonFindValue_KFA);
            Controls.Add(buttonImportCSV_KFA);
            Controls.Add(buttonDeleteGood_KFA);
            Controls.Add(textBoxFindValue_KFA);
            Controls.Add(buttonExportCVS_KFA);
            Controls.Add(dataGridViewGoods_KFA);
            Controls.Add(buttonGoMain_KFA);
            Name = "FormGoods";
            Text = "Goods";
            Load += FormGoods_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_KFA).EndInit();
            groupBoxCalculation_KFA.ResumeLayout(false);
            groupBoxCalculation_KFA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoMain_KFA;
        private DataGridView dataGridViewGoods_KFA;
        private Button buttonExportCVS_KFA;
        private TextBox textBoxFindValue_KFA;
        private Button buttonDeleteGood_KFA;
        private Button buttonImportCSV_KFA;
        private SaveFileDialog saveFileDialogMatrix_KFA;
        private OpenFileDialog openFileDialogMatrix_KFA;
        private Button buttonFindValue_KFA;
        private Button buttonSearchMiddlePrice_KFA;
        private GroupBox groupBoxCalculation_KFA;
        private TextBox textBoxResultCalculation_KFA;
        private Button buttonSearchTotalPrice_KFA;
        private Button buttonSearchMinPrice_KFA;
        private Button buttonSearchMaxNumber_KFA;
        private Button buttonAddGood_KFA;
    }
}