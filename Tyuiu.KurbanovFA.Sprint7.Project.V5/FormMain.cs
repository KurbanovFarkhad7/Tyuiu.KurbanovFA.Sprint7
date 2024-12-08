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
    }
}
