namespace quanlydatsan
{
    public partial class Form1 : Form
    {

        private Form currentChildform;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildform(Form Childform)
        {
            if (currentChildform != null)
            {
                currentChildform.Close();
            }

            currentChildform = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;

            panelMain.Controls.Add(Childform);
            panelMain.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildform(new TrangchuQTV());
        }

        private void btnTrangchu_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildform(new TrangchuQTV());
        }

        private void btnTaikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildform(new Khachhangvataikhoan());
        }
    }
}
