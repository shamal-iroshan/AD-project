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
    public partial class ParkingSpace : Form
    {
        Main main;

        public ParkingSpace(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.loadForm(new Apartment(main));
        }
    }
}
