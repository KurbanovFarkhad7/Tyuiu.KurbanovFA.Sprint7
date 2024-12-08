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
            dataGridViewGoods_KFA.Size = new Size(745, 223);
            dataGridViewGoods_KFA.TabIndex = 1;
            // 
            // buttonExportCVS_KFA
            // 
            buttonExportCVS_KFA.Location = new Point(575, 401);
            buttonExportCVS_KFA.Name = "buttonExportCVS_KFA";
            buttonExportCVS_KFA.Size = new Size(22, 23);
            buttonExportCVS_KFA.TabIndex = 2;
            buttonExportCVS_KFA.Text = "Export";
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
            // FormGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}