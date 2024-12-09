namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    partial class FormSuppliers
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
            buttonGoMain = new Button();
            buttonImportCSV_KFA = new Button();
            dataGridViewSuppliers_KFA = new DataGridView();
            buttonExportCVS_KFA = new Button();
            buttonDeleteSupplier_KFA = new Button();
            buttonFindValue_KFA = new Button();
            textBoxFindValue_KFA = new TextBox();
            groupBoxCalculation_KFA = new GroupBox();
            buttonSearchMaxNumber_KFA = new Button();
            buttonSearchMinPrice_KFA = new Button();
            buttonSearchTotalPrice_KFA = new Button();
            textBoxResultCalculation_KFA = new TextBox();
            buttonSearchMiddlePrice_KFA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_KFA).BeginInit();
            groupBoxCalculation_KFA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoMain
            // 
            buttonGoMain.Location = new Point(12, 362);
            buttonGoMain.Name = "buttonGoMain";
            buttonGoMain.Size = new Size(154, 76);
            buttonGoMain.TabIndex = 0;
            buttonGoMain.Text = "Меню";
            buttonGoMain.UseVisualStyleBackColor = true;
            buttonGoMain.Click += buttonGoMain_Click;
            // 
            // buttonImportCSV_KFA
            // 
            buttonImportCSV_KFA.Location = new Point(415, 414);
            buttonImportCSV_KFA.Name = "buttonImportCSV_KFA";
            buttonImportCSV_KFA.Size = new Size(22, 24);
            buttonImportCSV_KFA.TabIndex = 1;
            buttonImportCSV_KFA.Text = "Import";
            buttonImportCSV_KFA.UseVisualStyleBackColor = true;
            buttonImportCSV_KFA.Visible = false;
            buttonImportCSV_KFA.Click += buttonImportCSV_KFA_Click;
            // 
            // dataGridViewSuppliers_KFA
            // 
            dataGridViewSuppliers_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers_KFA.Location = new Point(12, 12);
            dataGridViewSuppliers_KFA.Name = "dataGridViewSuppliers_KFA";
            dataGridViewSuppliers_KFA.Size = new Size(776, 232);
            dataGridViewSuppliers_KFA.TabIndex = 2;
            // 
            // buttonExportCVS_KFA
            // 
            buttonExportCVS_KFA.Location = new Point(12, 250);
            buttonExportCVS_KFA.Name = "buttonExportCVS_KFA";
            buttonExportCVS_KFA.Size = new Size(123, 34);
            buttonExportCVS_KFA.TabIndex = 3;
            buttonExportCVS_KFA.Text = "Save";
            buttonExportCVS_KFA.UseVisualStyleBackColor = true;
            buttonExportCVS_KFA.Click += buttonExportCVS_KFA_Click;
            // 
            // buttonDeleteSupplier_KFA
            // 
            buttonDeleteSupplier_KFA.Location = new Point(141, 250);
            buttonDeleteSupplier_KFA.Name = "buttonDeleteSupplier_KFA";
            buttonDeleteSupplier_KFA.Size = new Size(123, 34);
            buttonDeleteSupplier_KFA.TabIndex = 4;
            buttonDeleteSupplier_KFA.Text = "Delete";
            buttonDeleteSupplier_KFA.UseVisualStyleBackColor = true;
            buttonDeleteSupplier_KFA.Click += buttonDeleteSupplier_KFA_Click;
            // 
            // buttonFindValue_KFA
            // 
            buttonFindValue_KFA.Location = new Point(12, 290);
            buttonFindValue_KFA.Name = "buttonFindValue_KFA";
            buttonFindValue_KFA.Size = new Size(252, 30);
            buttonFindValue_KFA.TabIndex = 5;
            buttonFindValue_KFA.Text = "Найти";
            buttonFindValue_KFA.UseVisualStyleBackColor = true;
            buttonFindValue_KFA.Click += buttonFindValue_KFA_Click;
            // 
            // textBoxFindValue_KFA
            // 
            textBoxFindValue_KFA.Location = new Point(12, 326);
            textBoxFindValue_KFA.Name = "textBoxFindValue_KFA";
            textBoxFindValue_KFA.Size = new Size(252, 23);
            textBoxFindValue_KFA.TabIndex = 6;
            // 
            // groupBoxCalculation_KFA
            // 
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMaxNumber_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMinPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchTotalPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(textBoxResultCalculation_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMiddlePrice_KFA);
            groupBoxCalculation_KFA.Location = new Point(488, 250);
            groupBoxCalculation_KFA.Name = "groupBoxCalculation_KFA";
            groupBoxCalculation_KFA.Size = new Size(300, 188);
            groupBoxCalculation_KFA.TabIndex = 9;
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
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCalculation_KFA);
            Controls.Add(textBoxFindValue_KFA);
            Controls.Add(buttonFindValue_KFA);
            Controls.Add(buttonDeleteSupplier_KFA);
            Controls.Add(buttonExportCVS_KFA);
            Controls.Add(dataGridViewSuppliers_KFA);
            Controls.Add(buttonImportCSV_KFA);
            Controls.Add(buttonGoMain);
            Name = "FormSuppliers";
            Text = "Suppliers";
            Load += FormSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_KFA).EndInit();
            groupBoxCalculation_KFA.ResumeLayout(false);
            groupBoxCalculation_KFA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoMain;
        private Button buttonImportCSV_KFA;
        private DataGridView dataGridViewSuppliers_KFA;
        private Button buttonExportCVS_KFA;
        private Button buttonDeleteSupplier_KFA;
        private Button buttonFindValue_KFA;
        private TextBox textBoxFindValue_KFA;
        private GroupBox groupBoxCalculation_KFA;
        private Button buttonSearchMaxNumber_KFA;
        private Button buttonSearchMinPrice_KFA;
        private Button buttonSearchTotalPrice_KFA;
        private TextBox textBoxResultCalculation_KFA;
        private Button buttonSearchMiddlePrice_KFA;
    }
}