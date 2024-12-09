namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
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
            textBoxFilePath_KFA = new TextBox();
            buttonDeleteGood_KFA = new Button();
            buttonImportCSV_KFA = new Button();
            saveFileDialogMatrix_KFA = new SaveFileDialog();
            openFileDialogMatrix_KFA = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_KFA).BeginInit();
            SuspendLayout();
            // 
            // buttonGoMain_KFA
            // 
            buttonGoMain_KFA.Location = new Point(28, 384);
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
            dataGridViewGoods_KFA.Location = new Point(28, 12);
            dataGridViewGoods_KFA.Name = "dataGridViewGoods_KFA";
            dataGridViewGoods_KFA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewGoods_KFA.Size = new Size(745, 223);
            dataGridViewGoods_KFA.TabIndex = 1;
            // 
            // buttonExportCVS_KFA
            // 
            buttonExportCVS_KFA.Location = new Point(28, 239);
            buttonExportCVS_KFA.Name = "buttonExportCVS_KFA";
            buttonExportCVS_KFA.Size = new Size(177, 41);
            buttonExportCVS_KFA.TabIndex = 2;
            buttonExportCVS_KFA.Text = "Save";
            buttonExportCVS_KFA.UseVisualStyleBackColor = true;
            buttonExportCVS_KFA.Click += buttonExportCVS_KFA_Click;
            // 
            // textBoxFilePath_KFA
            // 
            textBoxFilePath_KFA.Location = new Point(742, 401);
            textBoxFilePath_KFA.Name = "textBoxFilePath_KFA";
            textBoxFilePath_KFA.Size = new Size(31, 23);
            textBoxFilePath_KFA.TabIndex = 3;
            // 
            // buttonDeleteGood_KFA
            // 
            buttonDeleteGood_KFA.Location = new Point(211, 239);
            buttonDeleteGood_KFA.Name = "buttonDeleteGood_KFA";
            buttonDeleteGood_KFA.Size = new Size(179, 41);
            buttonDeleteGood_KFA.TabIndex = 4;
            buttonDeleteGood_KFA.Text = "Delete";
            buttonDeleteGood_KFA.UseVisualStyleBackColor = true;
            buttonDeleteGood_KFA.Click += buttonDeleteGood_KFA_Click;
            // 
            // buttonImportCSV_KFA
            // 
            buttonImportCSV_KFA.Location = new Point(333, 393);
            buttonImportCSV_KFA.Name = "buttonImportCSV_KFA";
            buttonImportCSV_KFA.Size = new Size(179, 37);
            buttonImportCSV_KFA.TabIndex = 5;
            buttonImportCSV_KFA.Text = "Import";
            buttonImportCSV_KFA.UseVisualStyleBackColor = true;
            buttonImportCSV_KFA.Click += buttonImportCSV_KFA_Click;
            // 
            // openFileDialogMatrix_KFA
            // 
            openFileDialogMatrix_KFA.FileName = "openFileDialog1";
            // 
            // FormGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonImportCSV_KFA);
            Controls.Add(buttonDeleteGood_KFA);
            Controls.Add(textBoxFilePath_KFA);
            Controls.Add(buttonExportCVS_KFA);
            Controls.Add(dataGridViewGoods_KFA);
            Controls.Add(buttonGoMain_KFA);
            Name = "FormGoods";
            Text = "Form1";
            Load += FormGoods_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_KFA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoMain_KFA;
        private DataGridView dataGridViewGoods_KFA;
        private Button buttonExportCVS_KFA;
        private TextBox textBoxFilePath_KFA;
        private Button buttonDeleteGood_KFA;
        private Button buttonImportCSV_KFA;
        private SaveFileDialog saveFileDialogMatrix_KFA;
        private OpenFileDialog openFileDialogMatrix_KFA;
    }
}