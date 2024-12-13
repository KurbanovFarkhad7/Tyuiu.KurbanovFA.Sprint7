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
            buttonAddSupplier_KFA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_KFA).BeginInit();
            groupBoxCalculation_KFA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoMain
            // 
            buttonGoMain.BackgroundImage = Properties.Resources.button_menu;
            buttonGoMain.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGoMain.Location = new Point(12, 384);
            buttonGoMain.Name = "buttonGoMain";
            buttonGoMain.Size = new Size(57, 54);
            buttonGoMain.TabIndex = 0;
            buttonGoMain.UseVisualStyleBackColor = true;
            buttonGoMain.Click += buttonGoMain_Click;
            // 
            // buttonImportCSV_KFA
            // 
            buttonImportCSV_KFA.Font = new Font("Segoe Print", 9.75F);
            buttonImportCSV_KFA.Location = new Point(460, 408);
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
            dataGridViewSuppliers_KFA.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewSuppliers_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers_KFA.Location = new Point(12, 12);
            dataGridViewSuppliers_KFA.Name = "dataGridViewSuppliers_KFA";
            dataGridViewSuppliers_KFA.Size = new Size(776, 232);
            dataGridViewSuppliers_KFA.TabIndex = 2;
            // 
            // buttonExportCVS_KFA
            // 
            buttonExportCVS_KFA.BackgroundImage = Properties.Resources.button_save;
            buttonExportCVS_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExportCVS_KFA.Location = new Point(147, 250);
            buttonExportCVS_KFA.Name = "buttonExportCVS_KFA";
            buttonExportCVS_KFA.Size = new Size(66, 59);
            buttonExportCVS_KFA.TabIndex = 3;
            buttonExportCVS_KFA.UseVisualStyleBackColor = true;
            buttonExportCVS_KFA.Click += buttonExportCVS_KFA_Click;
            // 
            // buttonDeleteSupplier_KFA
            // 
            buttonDeleteSupplier_KFA.BackgroundImage = Properties.Resources.button_delete;
            buttonDeleteSupplier_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteSupplier_KFA.Location = new Point(79, 250);
            buttonDeleteSupplier_KFA.Name = "buttonDeleteSupplier_KFA";
            buttonDeleteSupplier_KFA.Size = new Size(62, 59);
            buttonDeleteSupplier_KFA.TabIndex = 4;
            buttonDeleteSupplier_KFA.UseVisualStyleBackColor = true;
            buttonDeleteSupplier_KFA.Click += buttonDeleteSupplier_KFA_Click;
            // 
            // buttonFindValue_KFA
            // 
            buttonFindValue_KFA.BackgroundImage = Properties.Resources.button_search;
            buttonFindValue_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFindValue_KFA.Location = new Point(222, 309);
            buttonFindValue_KFA.Name = "buttonFindValue_KFA";
            buttonFindValue_KFA.Size = new Size(60, 55);
            buttonFindValue_KFA.TabIndex = 5;
            buttonFindValue_KFA.UseVisualStyleBackColor = true;
            buttonFindValue_KFA.Click += buttonFindValue_KFA_Click;
            // 
            // textBoxFindValue_KFA
            // 
            textBoxFindValue_KFA.Location = new Point(12, 326);
            textBoxFindValue_KFA.Name = "textBoxFindValue_KFA";
            textBoxFindValue_KFA.Size = new Size(204, 23);
            textBoxFindValue_KFA.TabIndex = 6;
            // 
            // groupBoxCalculation_KFA
            // 
            groupBoxCalculation_KFA.BackColor = SystemColors.ActiveCaption;
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMaxNumber_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMinPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchTotalPrice_KFA);
            groupBoxCalculation_KFA.Controls.Add(textBoxResultCalculation_KFA);
            groupBoxCalculation_KFA.Controls.Add(buttonSearchMiddlePrice_KFA);
            groupBoxCalculation_KFA.Font = new Font("Segoe Print", 9.75F);
            groupBoxCalculation_KFA.Location = new Point(488, 250);
            groupBoxCalculation_KFA.Name = "groupBoxCalculation_KFA";
            groupBoxCalculation_KFA.Size = new Size(300, 198);
            groupBoxCalculation_KFA.TabIndex = 9;
            groupBoxCalculation_KFA.TabStop = false;
            groupBoxCalculation_KFA.Text = "Вычисления";
            // 
            // buttonSearchMaxNumber_KFA
            // 
            buttonSearchMaxNumber_KFA.BackColor = SystemColors.GradientActiveCaption;
            buttonSearchMaxNumber_KFA.FlatStyle = FlatStyle.Flat;
            buttonSearchMaxNumber_KFA.Location = new Point(152, 93);
            buttonSearchMaxNumber_KFA.Name = "buttonSearchMaxNumber_KFA";
            buttonSearchMaxNumber_KFA.Size = new Size(142, 60);
            buttonSearchMaxNumber_KFA.TabIndex = 11;
            buttonSearchMaxNumber_KFA.Text = "Наибольшая поставка";
            buttonSearchMaxNumber_KFA.UseVisualStyleBackColor = false;
            buttonSearchMaxNumber_KFA.Click += buttonSearchMaxNumber_KFA_Click;
            // 
            // buttonSearchMinPrice_KFA
            // 
            buttonSearchMinPrice_KFA.BackColor = SystemColors.GradientActiveCaption;
            buttonSearchMinPrice_KFA.FlatStyle = FlatStyle.Flat;
            buttonSearchMinPrice_KFA.Location = new Point(6, 93);
            buttonSearchMinPrice_KFA.Name = "buttonSearchMinPrice_KFA";
            buttonSearchMinPrice_KFA.Size = new Size(140, 60);
            buttonSearchMinPrice_KFA.TabIndex = 10;
            buttonSearchMinPrice_KFA.Text = "Минимум поставок";
            buttonSearchMinPrice_KFA.UseVisualStyleBackColor = false;
            buttonSearchMinPrice_KFA.Click += buttonSearchMinPrice_KFA_Click;
            // 
            // buttonSearchTotalPrice_KFA
            // 
            buttonSearchTotalPrice_KFA.BackColor = SystemColors.GradientActiveCaption;
            buttonSearchTotalPrice_KFA.FlatStyle = FlatStyle.Flat;
            buttonSearchTotalPrice_KFA.Location = new Point(152, 22);
            buttonSearchTotalPrice_KFA.Name = "buttonSearchTotalPrice_KFA";
            buttonSearchTotalPrice_KFA.Size = new Size(142, 65);
            buttonSearchTotalPrice_KFA.TabIndex = 9;
            buttonSearchTotalPrice_KFA.Text = "Всего поставок";
            buttonSearchTotalPrice_KFA.UseVisualStyleBackColor = false;
            buttonSearchTotalPrice_KFA.Click += buttonSearchTotalPrice_KFA_Click;
            // 
            // textBoxResultCalculation_KFA
            // 
            textBoxResultCalculation_KFA.Location = new Point(8, 162);
            textBoxResultCalculation_KFA.Name = "textBoxResultCalculation_KFA";
            textBoxResultCalculation_KFA.ReadOnly = true;
            textBoxResultCalculation_KFA.Size = new Size(100, 30);
            textBoxResultCalculation_KFA.TabIndex = 8;
            // 
            // buttonSearchMiddlePrice_KFA
            // 
            buttonSearchMiddlePrice_KFA.BackColor = SystemColors.GradientActiveCaption;
            buttonSearchMiddlePrice_KFA.FlatStyle = FlatStyle.Flat;
            buttonSearchMiddlePrice_KFA.Location = new Point(8, 22);
            buttonSearchMiddlePrice_KFA.Name = "buttonSearchMiddlePrice_KFA";
            buttonSearchMiddlePrice_KFA.Size = new Size(138, 65);
            buttonSearchMiddlePrice_KFA.TabIndex = 7;
            buttonSearchMiddlePrice_KFA.Text = "Поставок в среднем";
            buttonSearchMiddlePrice_KFA.UseVisualStyleBackColor = false;
            buttonSearchMiddlePrice_KFA.Click += buttonSearchMiddlePrice_KFA_Click;
            // 
            // buttonAddSupplier_KFA
            // 
            buttonAddSupplier_KFA.BackgroundImage = Properties.Resources.button_add;
            buttonAddSupplier_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddSupplier_KFA.Location = new Point(12, 250);
            buttonAddSupplier_KFA.Name = "buttonAddSupplier_KFA";
            buttonAddSupplier_KFA.Size = new Size(61, 59);
            buttonAddSupplier_KFA.TabIndex = 10;
            buttonAddSupplier_KFA.UseVisualStyleBackColor = true;
            buttonAddSupplier_KFA.Click += buttonAddSupplier_KFA_Click;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroud_Image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 461);
            Controls.Add(buttonAddSupplier_KFA);
            Controls.Add(groupBoxCalculation_KFA);
            Controls.Add(textBoxFindValue_KFA);
            Controls.Add(buttonFindValue_KFA);
            Controls.Add(buttonDeleteSupplier_KFA);
            Controls.Add(buttonImportCSV_KFA);
            Controls.Add(buttonExportCVS_KFA);
            Controls.Add(dataGridViewSuppliers_KFA);
            Controls.Add(buttonGoMain);
            Name = "FormSuppliers";
            Text = "Поставщики";
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
        private Button buttonAddSupplier_KFA;
    }
}