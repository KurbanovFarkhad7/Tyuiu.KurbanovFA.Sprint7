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
            buttonAboutInfo_KFA = new Button();
            panelNavigateSide_KFA = new Panel();
            panelNavigateSide_KFA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoods_KFA
            // 
            buttonGoods_KFA.BackgroundImage = Properties.Resources.button_back;
            buttonGoods_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGoods_KFA.FlatStyle = FlatStyle.Popup;
            buttonGoods_KFA.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGoods_KFA.ForeColor = Color.Cornsilk;
            buttonGoods_KFA.Location = new Point(3, 57);
            buttonGoods_KFA.Name = "buttonGoods_KFA";
            buttonGoods_KFA.Size = new Size(193, 61);
            buttonGoods_KFA.TabIndex = 0;
            buttonGoods_KFA.Text = "Товары";
            buttonGoods_KFA.UseVisualStyleBackColor = true;
            buttonGoods_KFA.Click += buttonGoods_KFA_Click;
            // 
            // buttonSuppliers_KFA
            // 
            buttonSuppliers_KFA.BackgroundImage = Properties.Resources.button_back;
            buttonSuppliers_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSuppliers_KFA.FlatStyle = FlatStyle.Popup;
            buttonSuppliers_KFA.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSuppliers_KFA.ForeColor = Color.Cornsilk;
            buttonSuppliers_KFA.Location = new Point(3, 135);
            buttonSuppliers_KFA.Name = "buttonSuppliers_KFA";
            buttonSuppliers_KFA.Size = new Size(193, 62);
            buttonSuppliers_KFA.TabIndex = 1;
            buttonSuppliers_KFA.Text = "        Поставщики";
            buttonSuppliers_KFA.UseVisualStyleBackColor = true;
            buttonSuppliers_KFA.Click += buttonSuppliers_KFA_Click;
            // 
            // buttonAboutInfo_KFA
            // 
            buttonAboutInfo_KFA.BackColor = Color.Transparent;
            buttonAboutInfo_KFA.BackgroundImage = Properties.Resources.Button_info;
            buttonAboutInfo_KFA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAboutInfo_KFA.FlatStyle = FlatStyle.Popup;
            buttonAboutInfo_KFA.Location = new Point(13, 379);
            buttonAboutInfo_KFA.Name = "buttonAboutInfo_KFA";
            buttonAboutInfo_KFA.Size = new Size(69, 65);
            buttonAboutInfo_KFA.TabIndex = 3;
            buttonAboutInfo_KFA.UseVisualStyleBackColor = false;
            buttonAboutInfo_KFA.Click += buttonAboutInfo_KFA_Click;
            // 
            // panelNavigateSide_KFA
            // 
            panelNavigateSide_KFA.BackColor = Color.SteelBlue;
            panelNavigateSide_KFA.Controls.Add(buttonAboutInfo_KFA);
            panelNavigateSide_KFA.Controls.Add(buttonSuppliers_KFA);
            panelNavigateSide_KFA.Controls.Add(buttonGoods_KFA);
            panelNavigateSide_KFA.Location = new Point(-1, -6);
            panelNavigateSide_KFA.Name = "panelNavigateSide_KFA";
            panelNavigateSide_KFA.Size = new Size(202, 466);
            panelNavigateSide_KFA.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroud_Image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(437, 450);
            Controls.Add(panelNavigateSide_KFA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт 7 | Проект | Вариант 5 | Курбанов Ф.А.";
            Load += FormMain_Load;
            panelNavigateSide_KFA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoods_KFA;
        private Button buttonSuppliers_KFA;
        private Button buttonAboutInfo_KFA;
        private Panel panelNavigateSide_KFA;
    }
}
