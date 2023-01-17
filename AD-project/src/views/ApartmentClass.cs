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
    public partial class ApartmentClass : Form
    {
        Main main;

        public ApartmentClass(Main main)
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
