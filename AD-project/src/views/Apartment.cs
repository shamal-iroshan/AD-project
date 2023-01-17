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
    public partial class Apartment : Form
    {
        Main main;

        public Apartment(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnMangeBuilding_Click(object sender, EventArgs e)
        {
            main.loadForm(new Building(main));
        }

        private void btnMangeClasses_Click(object sender, EventArgs e)
        {
            main.loadForm(new ApartmentClass(main));
        }

        private void btnManageParkingSlot_Click(object sender, EventArgs e)
        {
            main.loadForm(new ParkingSpace(main));
        }
    }
}
