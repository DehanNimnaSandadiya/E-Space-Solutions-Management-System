using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace E_Space_Solutions
{
    public partial class Dashboard : KryptonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
          
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Dependent dependent = new Dependent();
            this.Hide();
            dependent.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Jet jet = new Jet();
            this.Hide();
            jet.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Pilot pilot = new Pilot();
            this.Hide();
            pilot.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            this.Hide();
            trip.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            HouseForm houseForm = new HouseForm();
            this.Hide();
            houseForm.Show();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            this.Hide();
            job.Show();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Colonist colonist = new Colonist();
            this.Hide();
            colonist.Show();
        }
    }
}
