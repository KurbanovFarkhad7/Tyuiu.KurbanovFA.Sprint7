namespace Tyuiu.KurbanovFA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonAboutInfo_KFA.FlatStyle = FlatStyle.Flat;
            buttonAboutInfo_KFA.BackColor = Color.Transparent;
            buttonAboutInfo_KFA.FlatAppearance.BorderSize = 0;
            buttonAboutInfo_KFA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAboutInfo_KFA.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonGoods_KFA.FlatStyle = FlatStyle.Flat;
            buttonGoods_KFA.BackColor = Color.Transparent;
            buttonGoods_KFA.FlatAppearance.BorderSize = 0;
            buttonGoods_KFA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGoods_KFA.FlatAppearance.MouseOverBackColor = Color.Transparent;

            buttonSuppliers_KFA.FlatStyle = FlatStyle.Flat;
            buttonSuppliers_KFA.BackColor = Color.Transparent;
            buttonSuppliers_KFA.FlatAppearance.BorderSize = 0;
            buttonSuppliers_KFA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSuppliers_KFA.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void buttonGoods_KFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGoods fgoods = new FormGoods();
            fgoods.ShowDialog();
        }

        private void buttonSuppliers_KFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSuppliers fsuppliers = new FormSuppliers();
            fsuppliers.ShowDialog();
        }

        private void buttonAboutInfo_KFA_Click(object sender, EventArgs e)
        {
            
            FormAboutInfo faboutInfo = new FormAboutInfo();
            faboutInfo.ShowDialog();
        }
    }
}
