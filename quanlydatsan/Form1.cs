using quanlydatsan.ADD_UC_ADMIN;

namespace quanlydatsan
{
    public partial class Form1 : Form
    {

        private UserControl currentUC;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenUserControl(UserControl uc)
        {

            if (currentUC != null)
            {
                currentUC.Dispose();
            }

            currentUC = uc;
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            panelMain.Tag = uc;
            uc.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenUserControl(new TrangChu());
        }


        private void btnTaikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            OpenUserControl(new UC_QLTK());
        }

        private void btnTrangchu_MouseClick(object sender, MouseEventArgs e)
        {
            OpenUserControl(new TrangChu());
        }

        private void btnLoaisan_MouseClick_1(object sender, MouseEventArgs e)
        {
            OpenUserControl(new QLLS());
        }
    }
}
