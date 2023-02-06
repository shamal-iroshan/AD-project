using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.views
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public void loadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
            {
                this.pnlMain.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            this.pnlMain.Tag = form;
            form.Show();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLease_Click(object sender, EventArgs e)
        {
            loadForm(new LeaseAggrement());
        }

        private void btnApartment_Click(object sender, EventArgs e)
        {
            loadForm(new Apartment(this));
        }

        private void btnOccupent_Click(object sender, EventArgs e)
        {
            loadForm(new ChiefOccupent());
        }

        private void btnDependants_Click(object sender, EventArgs e)
        {
            loadForm(new Dependants());
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            loadForm(new ParkingSpace());
        }

        private void btnWaitingList_Click(object sender, EventArgs e)
        {
            loadForm(new WaitingList());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadForm(new Search());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            loadForm(new ApproveExtention());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
