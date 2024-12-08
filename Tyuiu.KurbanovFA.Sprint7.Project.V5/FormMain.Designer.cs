namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGoods_KFA = new Button();
            buttonSuppliers_KFA = new Button();
            SuspendLayout();
            // 
            // buttonGoods_KFA
            // 
            buttonGoods_KFA.Location = new Point(113, 114);
            buttonGoods_KFA.Name = "buttonGoods_KFA";
            buttonGoods_KFA.Size = new Size(194, 67);
            buttonGoods_KFA.TabIndex = 0;
            buttonGoods_KFA.Text = "Товары";
            buttonGoods_KFA.UseVisualStyleBackColor = true;
            buttonGoods_KFA.Click += buttonGoods_KFA_Click;
            // 
            // buttonSuppliers_KFA
            // 
            buttonSuppliers_KFA.Location = new Point(391, 114);
            buttonSuppliers_KFA.Name = "buttonSuppliers_KFA";
            buttonSuppliers_KFA.Size = new Size(199, 63);
            buttonSuppliers_KFA.TabIndex = 1;
            buttonSuppliers_KFA.Text = "Поставщики";
            buttonSuppliers_KFA.UseVisualStyleBackColor = true;
            buttonSuppliers_KFA.Click += buttonSuppliers_KFA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSuppliers_KFA);
            Controls.Add(buttonGoods_KFA);
            Name = "FormMain";
            Text = "Спринт 6 | Проект | Вариант 5 | Курбанов Ф.А.";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoods_KFA;
        private Button buttonSuppliers_KFA;
    }
}
